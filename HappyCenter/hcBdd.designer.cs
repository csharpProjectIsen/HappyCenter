﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HappyCenter
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="happyCenterBdd")]
	public partial class hcBddDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertUtilisateurs(Utilisateurs instance);
    partial void UpdateUtilisateurs(Utilisateurs instance);
    partial void DeleteUtilisateurs(Utilisateurs instance);
    partial void InsertActivites(Activites instance);
    partial void UpdateActivites(Activites instance);
    partial void DeleteActivites(Activites instance);
    #endregion
		
		public hcBddDataContext() : 
				base(global::HappyCenter.Properties.Settings.Default.happyCenterBddConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public hcBddDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hcBddDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hcBddDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public hcBddDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Utilisateurs> Utilisateurs
		{
			get
			{
				return this.GetTable<Utilisateurs>();
			}
		}
		
		public System.Data.Linq.Table<Activites> Activites
		{
			get
			{
				return this.GetTable<Activites>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Utilisateurs")]
	public partial class Utilisateurs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Prenom;
		
		private int _Age;
		
		private int _Id_Activite;
		
		private string _Jour_Activite;
		
		private string _Horaires_Activite;
		
		private EntitySet<Activites> _Activites1;
		
		private EntityRef<Activites> _Activites;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnAgeChanging(int value);
    partial void OnAgeChanged();
    partial void OnId_ActiviteChanging(int value);
    partial void OnId_ActiviteChanged();
    partial void OnJour_ActiviteChanging(string value);
    partial void OnJour_ActiviteChanged();
    partial void OnHoraires_ActiviteChanging(string value);
    partial void OnHoraires_ActiviteChanged();
    #endregion
		
		public Utilisateurs()
		{
			this._Activites1 = new EntitySet<Activites>(new Action<Activites>(this.attach_Activites1), new Action<Activites>(this.detach_Activites1));
			this._Activites = default(EntityRef<Activites>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int NOT NULL")]
		public int Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Activite", DbType="Int NOT NULL")]
		public int Id_Activite
		{
			get
			{
				return this._Id_Activite;
			}
			set
			{
				if ((this._Id_Activite != value))
				{
					if (this._Activites.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_ActiviteChanging(value);
					this.SendPropertyChanging();
					this._Id_Activite = value;
					this.SendPropertyChanged("Id_Activite");
					this.OnId_ActiviteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Jour_Activite", DbType="NChar(10)")]
		public string Jour_Activite
		{
			get
			{
				return this._Jour_Activite;
			}
			set
			{
				if ((this._Jour_Activite != value))
				{
					this.OnJour_ActiviteChanging(value);
					this.SendPropertyChanging();
					this._Jour_Activite = value;
					this.SendPropertyChanged("Jour_Activite");
					this.OnJour_ActiviteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Horaires_Activite", DbType="NChar(50)")]
		public string Horaires_Activite
		{
			get
			{
				return this._Horaires_Activite;
			}
			set
			{
				if ((this._Horaires_Activite != value))
				{
					this.OnHoraires_ActiviteChanging(value);
					this.SendPropertyChanging();
					this._Horaires_Activite = value;
					this.SendPropertyChanged("Horaires_Activite");
					this.OnHoraires_ActiviteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Utilisateurs_Activites", Storage="_Activites1", ThisKey="Id", OtherKey="Id_Personne")]
		public EntitySet<Activites> Activites1
		{
			get
			{
				return this._Activites1;
			}
			set
			{
				this._Activites1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activites_Utilisateurs", Storage="_Activites", ThisKey="Id_Activite", OtherKey="Id", IsForeignKey=true)]
		public Activites Activites
		{
			get
			{
				return this._Activites.Entity;
			}
			set
			{
				Activites previousValue = this._Activites.Entity;
				if (((previousValue != value) 
							|| (this._Activites.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Activites.Entity = null;
						previousValue.Utilisateurs.Remove(this);
					}
					this._Activites.Entity = value;
					if ((value != null))
					{
						value.Utilisateurs.Add(this);
						this._Id_Activite = value.Id;
					}
					else
					{
						this._Id_Activite = default(int);
					}
					this.SendPropertyChanged("Activites");
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
		
		private void attach_Activites1(Activites entity)
		{
			this.SendPropertyChanging();
			entity.Utilisateurs1 = this;
		}
		
		private void detach_Activites1(Activites entity)
		{
			this.SendPropertyChanging();
			entity.Utilisateurs1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Activites")]
	public partial class Activites : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Description;
		
		private System.DateTime _Heure_Debut;
		
		private System.DateTime _Heure_Fin;
		
		private int _Age_Min;
		
		private int _Age_Max;
		
		private System.Data.Linq.Binary _Photo;
		
		private string _Etat;
		
		private int _Id_Personne;
		
		private EntitySet<Utilisateurs> _Utilisateurs;
		
		private EntityRef<Utilisateurs> _Utilisateurs1;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnHeure_DebutChanging(System.DateTime value);
    partial void OnHeure_DebutChanged();
    partial void OnHeure_FinChanging(System.DateTime value);
    partial void OnHeure_FinChanged();
    partial void OnAge_MinChanging(int value);
    partial void OnAge_MinChanged();
    partial void OnAge_MaxChanging(int value);
    partial void OnAge_MaxChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    partial void OnEtatChanging(string value);
    partial void OnEtatChanged();
    partial void OnId_PersonneChanging(int value);
    partial void OnId_PersonneChanged();
    #endregion
		
		public Activites()
		{
			this._Utilisateurs = new EntitySet<Utilisateurs>(new Action<Utilisateurs>(this.attach_Utilisateurs), new Action<Utilisateurs>(this.detach_Utilisateurs));
			this._Utilisateurs1 = default(EntityRef<Utilisateurs>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Heure_Debut", DbType="DateTime NOT NULL")]
		public System.DateTime Heure_Debut
		{
			get
			{
				return this._Heure_Debut;
			}
			set
			{
				if ((this._Heure_Debut != value))
				{
					this.OnHeure_DebutChanging(value);
					this.SendPropertyChanging();
					this._Heure_Debut = value;
					this.SendPropertyChanged("Heure_Debut");
					this.OnHeure_DebutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Heure_Fin", DbType="DateTime NOT NULL")]
		public System.DateTime Heure_Fin
		{
			get
			{
				return this._Heure_Fin;
			}
			set
			{
				if ((this._Heure_Fin != value))
				{
					this.OnHeure_FinChanging(value);
					this.SendPropertyChanging();
					this._Heure_Fin = value;
					this.SendPropertyChanged("Heure_Fin");
					this.OnHeure_FinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age_Min", DbType="Int NOT NULL")]
		public int Age_Min
		{
			get
			{
				return this._Age_Min;
			}
			set
			{
				if ((this._Age_Min != value))
				{
					this.OnAge_MinChanging(value);
					this.SendPropertyChanging();
					this._Age_Min = value;
					this.SendPropertyChanged("Age_Min");
					this.OnAge_MinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age_Max", DbType="Int NOT NULL")]
		public int Age_Max
		{
			get
			{
				return this._Age_Max;
			}
			set
			{
				if ((this._Age_Max != value))
				{
					this.OnAge_MaxChanging(value);
					this.SendPropertyChanging();
					this._Age_Max = value;
					this.SendPropertyChanged("Age_Max");
					this.OnAge_MaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Photo
		{
			get
			{
				return this._Photo;
			}
			set
			{
				if ((this._Photo != value))
				{
					this.OnPhotoChanging(value);
					this.SendPropertyChanging();
					this._Photo = value;
					this.SendPropertyChanged("Photo");
					this.OnPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Etat", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Etat
		{
			get
			{
				return this._Etat;
			}
			set
			{
				if ((this._Etat != value))
				{
					this.OnEtatChanging(value);
					this.SendPropertyChanging();
					this._Etat = value;
					this.SendPropertyChanged("Etat");
					this.OnEtatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Personne", DbType="Int NOT NULL")]
		public int Id_Personne
		{
			get
			{
				return this._Id_Personne;
			}
			set
			{
				if ((this._Id_Personne != value))
				{
					if (this._Utilisateurs1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_PersonneChanging(value);
					this.SendPropertyChanging();
					this._Id_Personne = value;
					this.SendPropertyChanged("Id_Personne");
					this.OnId_PersonneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activites_Utilisateurs", Storage="_Utilisateurs", ThisKey="Id", OtherKey="Id_Activite")]
		public EntitySet<Utilisateurs> Utilisateurs
		{
			get
			{
				return this._Utilisateurs;
			}
			set
			{
				this._Utilisateurs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Utilisateurs_Activites", Storage="_Utilisateurs1", ThisKey="Id_Personne", OtherKey="Id", IsForeignKey=true)]
		public Utilisateurs Utilisateurs1
		{
			get
			{
				return this._Utilisateurs1.Entity;
			}
			set
			{
				Utilisateurs previousValue = this._Utilisateurs1.Entity;
				if (((previousValue != value) 
							|| (this._Utilisateurs1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Utilisateurs1.Entity = null;
						previousValue.Activites1.Remove(this);
					}
					this._Utilisateurs1.Entity = value;
					if ((value != null))
					{
						value.Activites1.Add(this);
						this._Id_Personne = value.Id;
					}
					else
					{
						this._Id_Personne = default(int);
					}
					this.SendPropertyChanged("Utilisateurs1");
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
		
		private void attach_Utilisateurs(Utilisateurs entity)
		{
			this.SendPropertyChanging();
			entity.Activites = this;
		}
		
		private void detach_Utilisateurs(Utilisateurs entity)
		{
			this.SendPropertyChanging();
			entity.Activites = null;
		}
	}
}
#pragma warning restore 1591
