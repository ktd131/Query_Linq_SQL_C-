﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btLinq
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="btLinq")]
	public partial class btLinqConnectDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertclass1(class1 instance);
    partial void Updateclass1(class1 instance);
    partial void Deleteclass1(class1 instance);
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    #endregion
		
		public btLinqConnectDataContext() : 
				base(global::btLinq.Properties.Settings.Default.btLinqConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public btLinqConnectDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public btLinqConnectDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public btLinqConnectDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public btLinqConnectDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<class1> class1s
		{
			get
			{
				return this.GetTable<class1>();
			}
		}
		
		public System.Data.Linq.Table<student> students
		{
			get
			{
				return this.GetTable<student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.class")]
	public partial class class1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Name;
		
		private EntitySet<student> _students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdcChanging(long value);
    partial void OnIdcChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public class1()
		{
			this._students = new EntitySet<student>(new Action<student>(this.attach_students), new Action<student>(this.detach_students));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Id", Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Idc
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdcChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Idc");
					this.OnIdcChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="class_student", Storage="_students", ThisKey="Idc", OtherKey="classId")]
		public EntitySet<student> students
		{
			get
			{
				return this._students;
			}
			set
			{
				this._students.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_students(student entity)
		{
			this.SendPropertyChanging();
			entity.class1 = this;
		}
		
		private void detach_students(student entity)
		{
			this.SendPropertyChanging();
			entity.class1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Name;
		
		private System.Nullable<long> _classId;
		
		private EntityRef<class1> _class;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnclassIdChanging(System.Nullable<long> value);
    partial void OnclassIdChanged();
    #endregion
		
		public student()
		{
			this._class = default(EntityRef<class1>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_classId", DbType="BigInt")]
		public System.Nullable<long> classId
		{
			get
			{
				return this._classId;
			}
			set
			{
				if ((this._classId != value))
				{
					if (this._class.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnclassIdChanging(value);
					this.SendPropertyChanging();
					this._classId = value;
					this.SendPropertyChanged("classId");
					this.OnclassIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="class_student", Storage="_class", ThisKey="classId", OtherKey="Idc", IsForeignKey=true, DeleteRule="SET NULL")]
		public class1 class1
		{
			get
			{
				return this._class.Entity;
			}
			set
			{
				class1 previousValue = this._class.Entity;
				if (((previousValue != value) 
							|| (this._class.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._class.Entity = null;
						previousValue.students.Remove(this);
					}
					this._class.Entity = value;
					if ((value != null))
					{
						value.students.Add(this);
						this._classId = value.Idc;
					}
					else
					{
						this._classId = default(Nullable<long>);
					}
					this.SendPropertyChanged("class1");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591