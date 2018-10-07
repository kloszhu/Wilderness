﻿using EnvDTE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wilderness.Test
{
    public class 生成多文件
    {
     
            DTE _dte;
            DTE DTE => _dte ?? (_dte = (DTE)((IServiceProvider)Host).GetService(typeof(DTE)));

            ProjectItem _templateProjectItem;
            ProjectItem TemplateProjectItem => _templateProjectItem ?? (_templateProjectItem = DTE.Solution.FindProjectItem(Host.TemplateFile));

            readonly Dictionary<string, int> _fileNames = new Dictionary<string, int>();

            Func<string, string, bool> CompareContent = (s1, s2) => s1 == s2;

            void SaveOutput(string fileName, int fileType = 1)
            {
                var dir = Path.GetDirectoryName(Host.TemplateFile);
                var output = Path.Combine(dir, fileName);
                var newContent = GenerationEnvironment.ToString();
                var oldContent = File.Exists(output) ? File.ReadAllText(output) : "";

                if (!CompareContent(newContent, oldContent))
                {
                    if (DTE.SourceControl != null && DTE.SourceControl.IsItemUnderSCC(output) && !DTE.SourceControl.IsItemCheckedOut(output))
                        DTE.SourceControl.CheckOutItem(output);

                    File.WriteAllText(output, newContent);
                }

                GenerationEnvironment.Length = 0;

                _fileNames.Add(output, fileType);
            }

            void SyncProject()
            {
                var keepFileNames = _fileNames.ToDictionary(f => f.Key);
                var projectFiles = new Dictionary<string, ProjectItem>();
                var templateFileName = TemplateProjectItem.FileNames[0];
                var originalFilePrefix = Path.GetFileNameWithoutExtension(templateFileName) + ".";

                foreach (ProjectItem projectItem in TemplateProjectItem.ProjectItems)
                {
                    projectFiles.Add(projectItem.FileNames[0], projectItem);
                }

                foreach (var pair in projectFiles)
                {
                    if (!keepFileNames.ContainsKey(pair.Key))
                        if (!(Path.GetFileNameWithoutExtension(pair.Key) + ".").StartsWith(originalFilePrefix))
                            //if (pair.Key != templateFileName)
                            pair.Value.Delete();
                }

                // Add missing files to the project.
                //
                foreach (var fileName in keepFileNames)
                {
                    if (!projectFiles.ContainsKey(fileName.Value.Key))
                        if (File.Exists(fileName.Value.Key))
                        {
                            var newItem = TemplateProjectItem.ProjectItems.AddFromFile(fileName.Value.Key);
                            newItem.Properties.Item("BuildAction").Value = fileName.Value.Value;
                        }
                }
            }
        
    }
}
