//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

using LinqToDB;
using LinqToDB.DataProvider.SqlServer;
using LinqToDB.Extensions;
using LinqToDB.Mapping;

namespace AllTest
{
	/// <summary>
	/// Database       : mydb
	/// Data Source    : .
	/// Server Version : 11.00.2100
	/// </summary>
	public partial class MydbDB : LinqToDB.Data.DataConnection
	{
		public ITable<A1>     A1      { get { return this.GetTable<A1>(); } }
		public ITable<A10>    A10     { get { return this.GetTable<A10>(); } }
		public ITable<A11>    A11     { get { return this.GetTable<A11>(); } }
		public ITable<A2>     A2      { get { return this.GetTable<A2>(); } }
		public ITable<A3>     A3      { get { return this.GetTable<A3>(); } }
		public ITable<A4>     A4      { get { return this.GetTable<A4>(); } }
		public ITable<A5>     A5      { get { return this.GetTable<A5>(); } }
		public ITable<A6>     A6      { get { return this.GetTable<A6>(); } }
		public ITable<A7>     A7      { get { return this.GetTable<A7>(); } }
		public ITable<A8>     A8      { get { return this.GetTable<A8>(); } }
		public ITable<A9>     A9      { get { return this.GetTable<A9>(); } }
		public ITable<Artist> Artists { get { return this.GetTable<Artist>(); } }
		public ITable<Poco>   Pocoes  { get { return this.GetTable<Poco>(); } }
		public ITable<Track>  Tracks  { get { return this.GetTable<Track>(); } }
		public ITable<TTest>  TTests  { get { return this.GetTable<TTest>(); } }

		public void InitMappingSchema()
		{
		}

		public MydbDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public MydbDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext();

		#region FreeTextTable

		public class FreeTextKey<T>
		{
			public T   Key;
			public int Rank;
		}

		private static MethodInfo _freeTextTableMethod1 = typeof(MydbDB).GetMethod("FreeTextTable", new Type[] { typeof(string), typeof(string) });

		[FreeTextTableExpression]
		public ITable<FreeTextKey<TKey>> FreeTextTable<TTable,TKey>(string field, string text)
		{
			return this.GetTable<FreeTextKey<TKey>>(
				this,
				_freeTextTableMethod1,
				field,
				text);
		}

		private static MethodInfo _freeTextTableMethod2 = 
			typeof(MydbDB).GetMethods()
				.Where(m => m.Name == "FreeTextTable" &&  m.IsGenericMethod && m.GetParameters().Length == 2)
				.Where(m => m.GetParameters()[0].ParameterType.IsGenericTypeEx() && m.GetParameters()[0].ParameterType.GetGenericTypeDefinition() == typeof(Expression<>))
				.Where(m => m.GetParameters()[1].ParameterType == typeof(string))
				.Single();

		[FreeTextTableExpression]
		public ITable<FreeTextKey<TKey>> FreeTextTable<TTable,TKey>(Expression<Func<TTable,string>> fieldSelector, string text)
		{
			return this.GetTable<FreeTextKey<TKey>>(
				this,
				_freeTextTableMethod2,
				fieldSelector,
				text);
		}

		#endregion
	}

	[Table(Schema="dbo", Name="A1")]
	public partial class A1
	{
		[PrimaryKey, Identity] public int    Id   { get; set; } // int
		[Column,     Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A10")]
	public partial class A10
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A11")]
	public partial class A11
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A2")]
	public partial class A2
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A3")]
	public partial class A3
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A4")]
	public partial class A4
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A5")]
	public partial class A5
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A6")]
	public partial class A6
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A7")]
	public partial class A7
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A8")]
	public partial class A8
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="A9")]
	public partial class A9
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="Artist")]
	public partial class Artist
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="Poco")]
	public partial class Poco
	{
		[PrimaryKey, NotNull    ] public int    Id   { get; set; } // int
		[Column,        Nullable] public string Name { get; set; } // varchar(8000)
	}

	[Table(Schema="dbo", Name="Track")]
	public partial class Track
	{
		[PrimaryKey, Identity   ] public int    Id       { get; set; } // int
		[Column,        Nullable] public string Name     { get; set; } // varchar(8000)
		[Column,     NotNull    ] public int    ArtistId { get; set; } // int
		[Column,        Nullable] public string Album    { get; set; } // varchar(8000)
		[Column,     NotNull    ] public int    Year     { get; set; } // int
	}

	[Table(Schema="dbo", Name="T_Test")]
	public partial class TTest
	{
		[PrimaryKey, Identity] public int    Id   { get; set; } // int
		[Column,     Nullable] public string Name { get; set; } // nvarchar(100)
	}

	public static partial class TableExtensions
	{
		public static A1 Find(this ITable<A1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A10 Find(this ITable<A10> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A11 Find(this ITable<A11> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A2 Find(this ITable<A2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A3 Find(this ITable<A3> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A4 Find(this ITable<A4> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A5 Find(this ITable<A5> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A6 Find(this ITable<A6> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A7 Find(this ITable<A7> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A8 Find(this ITable<A8> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static A9 Find(this ITable<A9> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Artist Find(this ITable<Artist> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Poco Find(this ITable<Poco> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static Track Find(this ITable<Track> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TTest Find(this ITable<TTest> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}