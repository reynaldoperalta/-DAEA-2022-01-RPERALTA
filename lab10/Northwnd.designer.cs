﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab10
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NORTHWND")]
	public partial class NorthwndDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertProducts(Products instance);
    partial void UpdateProducts(Products instance);
    partial void DeleteProducts(Products instance);
    partial void InsertCategories(Categories instance);
    partial void UpdateCategories(Categories instance);
    partial void DeleteCategories(Categories instance);
    partial void InsertSuppliers(Suppliers instance);
    partial void UpdateSuppliers(Suppliers instance);
    partial void DeleteSuppliers(Suppliers instance);
    #endregion
		
		public NorthwndDataContext() : 
				base(global::lab10.Properties.Settings.Default.NORTHWNDConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwndDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwndDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwndDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwndDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public System.Data.Linq.Table<Categories> Categories
		{
			get
			{
				return this.GetTable<Categories>();
			}
		}
		
		public System.Data.Linq.Table<Suppliers> Suppliers
		{
			get
			{
				return this.GetTable<Suppliers>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Products")]
	public partial class Products : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductID;
		
		private string _ProductName;
		
		private System.Nullable<int> _SupplierID;
		
		private System.Nullable<int> _CategoryID;
		
		private string _QuantityPerUnit;
		
		private System.Nullable<decimal> _UnitPrice;
		
		private System.Nullable<short> _UnitsInStock;
		
		private System.Nullable<short> _UnitsOnOrder;
		
		private System.Nullable<short> _ReorderLevel;
		
		private bool _Discontinued;
		
		private EntityRef<Categories> _Categories;
		
		private EntityRef<Suppliers> _Suppliers;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnSupplierIDChanging(System.Nullable<int> value);
    partial void OnSupplierIDChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    partial void OnQuantityPerUnitChanging(string value);
    partial void OnQuantityPerUnitChanged();
    partial void OnUnitPriceChanging(System.Nullable<decimal> value);
    partial void OnUnitPriceChanged();
    partial void OnUnitsInStockChanging(System.Nullable<short> value);
    partial void OnUnitsInStockChanged();
    partial void OnUnitsOnOrderChanging(System.Nullable<short> value);
    partial void OnUnitsOnOrderChanged();
    partial void OnReorderLevelChanging(System.Nullable<short> value);
    partial void OnReorderLevelChanged();
    partial void OnDiscontinuedChanging(bool value);
    partial void OnDiscontinuedChanged();
    #endregion
		
		public Products()
		{
			this._Categories = default(EntityRef<Categories>);
			this._Suppliers = default(EntityRef<Suppliers>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierID", DbType="Int")]
		public System.Nullable<int> SupplierID
		{
			get
			{
				return this._SupplierID;
			}
			set
			{
				if ((this._SupplierID != value))
				{
					if (this._Suppliers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSupplierIDChanging(value);
					this.SendPropertyChanging();
					this._SupplierID = value;
					this.SendPropertyChanged("SupplierID");
					this.OnSupplierIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._Categories.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuantityPerUnit", DbType="NVarChar(20)")]
		public string QuantityPerUnit
		{
			get
			{
				return this._QuantityPerUnit;
			}
			set
			{
				if ((this._QuantityPerUnit != value))
				{
					this.OnQuantityPerUnitChanging(value);
					this.SendPropertyChanging();
					this._QuantityPerUnit = value;
					this.SendPropertyChanged("QuantityPerUnit");
					this.OnQuantityPerUnitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitPrice", DbType="Money")]
		public System.Nullable<decimal> UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitsInStock", DbType="SmallInt")]
		public System.Nullable<short> UnitsInStock
		{
			get
			{
				return this._UnitsInStock;
			}
			set
			{
				if ((this._UnitsInStock != value))
				{
					this.OnUnitsInStockChanging(value);
					this.SendPropertyChanging();
					this._UnitsInStock = value;
					this.SendPropertyChanged("UnitsInStock");
					this.OnUnitsInStockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitsOnOrder", DbType="SmallInt")]
		public System.Nullable<short> UnitsOnOrder
		{
			get
			{
				return this._UnitsOnOrder;
			}
			set
			{
				if ((this._UnitsOnOrder != value))
				{
					this.OnUnitsOnOrderChanging(value);
					this.SendPropertyChanging();
					this._UnitsOnOrder = value;
					this.SendPropertyChanged("UnitsOnOrder");
					this.OnUnitsOnOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReorderLevel", DbType="SmallInt")]
		public System.Nullable<short> ReorderLevel
		{
			get
			{
				return this._ReorderLevel;
			}
			set
			{
				if ((this._ReorderLevel != value))
				{
					this.OnReorderLevelChanging(value);
					this.SendPropertyChanging();
					this._ReorderLevel = value;
					this.SendPropertyChanged("ReorderLevel");
					this.OnReorderLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discontinued", DbType="Bit NOT NULL")]
		public bool Discontinued
		{
			get
			{
				return this._Discontinued;
			}
			set
			{
				if ((this._Discontinued != value))
				{
					this.OnDiscontinuedChanging(value);
					this.SendPropertyChanging();
					this._Discontinued = value;
					this.SendPropertyChanged("Discontinued");
					this.OnDiscontinuedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categories_Products", Storage="_Categories", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
		public Categories Categories
		{
			get
			{
				return this._Categories.Entity;
			}
			set
			{
				Categories previousValue = this._Categories.Entity;
				if (((previousValue != value) 
							|| (this._Categories.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categories.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Categories.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._CategoryID = value.CategoryID;
					}
					else
					{
						this._CategoryID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categories");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Products", Storage="_Suppliers", ThisKey="SupplierID", OtherKey="SupplierID", IsForeignKey=true)]
		public Suppliers Suppliers
		{
			get
			{
				return this._Suppliers.Entity;
			}
			set
			{
				Suppliers previousValue = this._Suppliers.Entity;
				if (((previousValue != value) 
							|| (this._Suppliers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Suppliers.Entity = null;
						previousValue.Products.Remove(this);
					}
					this._Suppliers.Entity = value;
					if ((value != null))
					{
						value.Products.Add(this);
						this._SupplierID = value.SupplierID;
					}
					else
					{
						this._SupplierID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Suppliers");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Categories : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private string _CategoryName;
		
		private string _Description;
		
		private System.Data.Linq.Binary _Picture;
		
		private EntitySet<Products> _Products;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    #endregion
		
		public Categories()
		{
			this._Products = new EntitySet<Products>(new Action<Products>(this.attach_Products), new Action<Products>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categories_Products", Storage="_Products", ThisKey="CategoryID", OtherKey="CategoryID")]
		public EntitySet<Products> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Products entity)
		{
			this.SendPropertyChanging();
			entity.Categories = this;
		}
		
		private void detach_Products(Products entity)
		{
			this.SendPropertyChanging();
			entity.Categories = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suppliers")]
	public partial class Suppliers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SupplierID;
		
		private string _CompanyName;
		
		private string _ContactName;
		
		private string _ContactTitle;
		
		private string _Address;
		
		private string _City;
		
		private string _Region;
		
		private string _PostalCode;
		
		private string _Country;
		
		private string _Phone;
		
		private string _Fax;
		
		private string _HomePage;
		
		private EntitySet<Products> _Products;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSupplierIDChanging(int value);
    partial void OnSupplierIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnContactNameChanging(string value);
    partial void OnContactNameChanged();
    partial void OnContactTitleChanging(string value);
    partial void OnContactTitleChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnPostalCodeChanging(string value);
    partial void OnPostalCodeChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    partial void OnHomePageChanging(string value);
    partial void OnHomePageChanged();
    #endregion
		
		public Suppliers()
		{
			this._Products = new EntitySet<Products>(new Action<Products>(this.attach_Products), new Action<Products>(this.detach_Products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SupplierID
		{
			get
			{
				return this._SupplierID;
			}
			set
			{
				if ((this._SupplierID != value))
				{
					this.OnSupplierIDChanging(value);
					this.SendPropertyChanging();
					this._SupplierID = value;
					this.SendPropertyChanged("SupplierID");
					this.OnSupplierIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactName", DbType="NVarChar(30)")]
		public string ContactName
		{
			get
			{
				return this._ContactName;
			}
			set
			{
				if ((this._ContactName != value))
				{
					this.OnContactNameChanging(value);
					this.SendPropertyChanging();
					this._ContactName = value;
					this.SendPropertyChanged("ContactName");
					this.OnContactNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContactTitle", DbType="NVarChar(30)")]
		public string ContactTitle
		{
			get
			{
				return this._ContactTitle;
			}
			set
			{
				if ((this._ContactTitle != value))
				{
					this.OnContactTitleChanging(value);
					this.SendPropertyChanging();
					this._ContactTitle = value;
					this.SendPropertyChanged("ContactTitle");
					this.OnContactTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(60)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(15)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="NVarChar(15)")]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="NVarChar(10)")]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(15)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(24)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="NVarChar(24)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HomePage", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string HomePage
		{
			get
			{
				return this._HomePage;
			}
			set
			{
				if ((this._HomePage != value))
				{
					this.OnHomePageChanging(value);
					this.SendPropertyChanging();
					this._HomePage = value;
					this.SendPropertyChanged("HomePage");
					this.OnHomePageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Suppliers_Products", Storage="_Products", ThisKey="SupplierID", OtherKey="SupplierID")]
		public EntitySet<Products> Products
		{
			get
			{
				return this._Products;
			}
			set
			{
				this._Products.Assign(value);
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
		
		private void attach_Products(Products entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = this;
		}
		
		private void detach_Products(Products entity)
		{
			this.SendPropertyChanging();
			entity.Suppliers = null;
		}
	}
}
#pragma warning restore 1591
