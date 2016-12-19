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

namespace SampleMVCLINQ.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Cars")]
	public partial class DataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertOwner(Owner instance);
    partial void UpdateOwner(Owner instance);
    partial void DeleteOwner(Owner instance);
    #endregion
		
		public DataContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CarsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<Owner> Owners
		{
			get
			{
				return this.GetTable<Owner>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Car")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Make;
		
		private string _Model;
		
		private string _Plates;
		
		private int _Yop;
		
		private System.Nullable<int> _ownerId;
		
		private EntityRef<Owner> _Owner;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnMakeChanging(string value);
    partial void OnMakeChanged();
    partial void OnModelChanging(string value);
    partial void OnModelChanged();
    partial void OnPlatesChanging(string value);
    partial void OnPlatesChanged();
    partial void OnYopChanging(int value);
    partial void OnYopChanged();
    partial void OnownerIdChanging(System.Nullable<int> value);
    partial void OnownerIdChanged();
    #endregion
		
		public Car()
		{
			this._Owner = default(EntityRef<Owner>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Make", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Make
		{
			get
			{
				return this._Make;
			}
			set
			{
				if ((this._Make != value))
				{
					this.OnMakeChanging(value);
					this.SendPropertyChanging();
					this._Make = value;
					this.SendPropertyChanged("Make");
					this.OnMakeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Model", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				if ((this._Model != value))
				{
					this.OnModelChanging(value);
					this.SendPropertyChanging();
					this._Model = value;
					this.SendPropertyChanged("Model");
					this.OnModelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plates", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Plates
		{
			get
			{
				return this._Plates;
			}
			set
			{
				if ((this._Plates != value))
				{
					this.OnPlatesChanging(value);
					this.SendPropertyChanging();
					this._Plates = value;
					this.SendPropertyChanged("Plates");
					this.OnPlatesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Yop", DbType="Int NOT NULL")]
		public int Yop
		{
			get
			{
				return this._Yop;
			}
			set
			{
				if ((this._Yop != value))
				{
					this.OnYopChanging(value);
					this.SendPropertyChanging();
					this._Yop = value;
					this.SendPropertyChanged("Yop");
					this.OnYopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ownerId", DbType="Int")]
		public System.Nullable<int> ownerId
		{
			get
			{
				return this._ownerId;
			}
			set
			{
				if ((this._ownerId != value))
				{
					if (this._Owner.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnownerIdChanging(value);
					this.SendPropertyChanging();
					this._ownerId = value;
					this.SendPropertyChanged("ownerId");
					this.OnownerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Owner_Car", Storage="_Owner", ThisKey="ownerId", OtherKey="Id", IsForeignKey=true)]
		public Owner Owner
		{
			get
			{
				return this._Owner.Entity;
			}
			set
			{
				Owner previousValue = this._Owner.Entity;
				if (((previousValue != value) 
							|| (this._Owner.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Owner.Entity = null;
						previousValue.Cars.Remove(this);
					}
					this._Owner.Entity = value;
					if ((value != null))
					{
						value.Cars.Add(this);
						this._ownerId = value.Id;
					}
					else
					{
						this._ownerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Owner");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Owner")]
	public partial class Owner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _DriverLicense;
		
		private System.DateTime _Birthdate;
		
		private EntitySet<Car> _Cars;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnDriverLicenseChanging(string value);
    partial void OnDriverLicenseChanged();
    partial void OnBirthdateChanging(System.DateTime value);
    partial void OnBirthdateChanged();
    #endregion
		
		public Owner()
		{
			this._Cars = new EntitySet<Car>(new Action<Car>(this.attach_Cars), new Action<Car>(this.detach_Cars));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DriverLicense", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string DriverLicense
		{
			get
			{
				return this._DriverLicense;
			}
			set
			{
				if ((this._DriverLicense != value))
				{
					this.OnDriverLicenseChanging(value);
					this.SendPropertyChanging();
					this._DriverLicense = value;
					this.SendPropertyChanged("DriverLicense");
					this.OnDriverLicenseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="Date NOT NULL")]
		public System.DateTime Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Owner_Car", Storage="_Cars", ThisKey="Id", OtherKey="ownerId")]
		public EntitySet<Car> Cars
		{
			get
			{
				return this._Cars;
			}
			set
			{
				this._Cars.Assign(value);
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
		
		private void attach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.Owner = this;
		}
		
		private void detach_Cars(Car entity)
		{
			this.SendPropertyChanging();
			entity.Owner = null;
		}
	}
}
#pragma warning restore 1591
