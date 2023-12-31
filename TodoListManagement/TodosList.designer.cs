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

namespace TodoListManagement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TodoList")]
	public partial class TodosListDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTodo(Todo instance);
    partial void UpdateTodo(Todo instance);
    partial void DeleteTodo(Todo instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public TodosListDataContext() : 
				base(global::TodoListManagement.Properties.Settings.Default.TodoListConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TodosListDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TodosListDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TodosListDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TodosListDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Todo> Todos
		{
			get
			{
				return this.GetTable<Todo>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Todos")]
	public partial class Todo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _tid;
		
		private string _task;
		
		private System.Nullable<System.DateTime> _addedTime;
		
		private string _isCompleted;
		
		private System.Nullable<System.DateTime> _doneTime;
		
		private System.Nullable<int> _uid;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntidChanging(int value);
    partial void OntidChanged();
    partial void OntaskChanging(string value);
    partial void OntaskChanged();
    partial void OnaddedTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnaddedTimeChanged();
    partial void OnisCompletedChanging(string value);
    partial void OnisCompletedChanged();
    partial void OndoneTimeChanging(System.Nullable<System.DateTime> value);
    partial void OndoneTimeChanged();
    partial void OnuidChanging(System.Nullable<int> value);
    partial void OnuidChanged();
    #endregion
		
		public Todo()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int tid
		{
			get
			{
				return this._tid;
			}
			set
			{
				if ((this._tid != value))
				{
					this.OntidChanging(value);
					this.SendPropertyChanging();
					this._tid = value;
					this.SendPropertyChanged("tid");
					this.OntidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_task", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string task
		{
			get
			{
				return this._task;
			}
			set
			{
				if ((this._task != value))
				{
					this.OntaskChanging(value);
					this.SendPropertyChanging();
					this._task = value;
					this.SendPropertyChanged("task");
					this.OntaskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_addedTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> addedTime
		{
			get
			{
				return this._addedTime;
			}
			set
			{
				if ((this._addedTime != value))
				{
					this.OnaddedTimeChanging(value);
					this.SendPropertyChanging();
					this._addedTime = value;
					this.SendPropertyChanged("addedTime");
					this.OnaddedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isCompleted", DbType="VarChar(1)")]
		public string isCompleted
		{
			get
			{
				return this._isCompleted;
			}
			set
			{
				if ((this._isCompleted != value))
				{
					this.OnisCompletedChanging(value);
					this.SendPropertyChanging();
					this._isCompleted = value;
					this.SendPropertyChanged("isCompleted");
					this.OnisCompletedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_doneTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> doneTime
		{
			get
			{
				return this._doneTime;
			}
			set
			{
				if ((this._doneTime != value))
				{
					this.OndoneTimeChanging(value);
					this.SendPropertyChanging();
					this._doneTime = value;
					this.SendPropertyChanged("doneTime");
					this.OndoneTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="Int")]
		public System.Nullable<int> uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_Todo", Storage="_user", ThisKey="uid", OtherKey="uid", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.Todos.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.Todos.Add(this);
						this._uid = value.uid;
					}
					else
					{
						this._uid = default(Nullable<int>);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _email;
		
		private string _password;
		
		private string _name;
		
		private EntitySet<Todo> _Todos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public user()
		{
			this._Todos = new EntitySet<Todo>(new Action<Todo>(this.attach_Todos), new Action<Todo>(this.detach_Todos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_Todo", Storage="_Todos", ThisKey="uid", OtherKey="uid")]
		public EntitySet<Todo> Todos
		{
			get
			{
				return this._Todos;
			}
			set
			{
				this._Todos.Assign(value);
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
		
		private void attach_Todos(Todo entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_Todos(Todo entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
}
#pragma warning restore 1591
