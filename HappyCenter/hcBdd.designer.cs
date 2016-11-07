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
    partial void InsertActivites(Activites instance);
    partial void UpdateActivites(Activites instance);
    partial void DeleteActivites(Activites instance);
    partial void InsertMoniteurs(Moniteurs instance);
    partial void UpdateMoniteurs(Moniteurs instance);
    partial void DeleteMoniteurs(Moniteurs instance);
    partial void InsertPersonnes(Personnes instance);
    partial void UpdatePersonnes(Personnes instance);
    partial void DeletePersonnes(Personnes instance);
    partial void InsertSalles(Salles instance);
    partial void UpdateSalles(Salles instance);
    partial void DeleteSalles(Salles instance);
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
		
		public System.Data.Linq.Table<Activites> Activites
		{
			get
			{
				return this.GetTable<Activites>();
			}
		}
		
		public System.Data.Linq.Table<Moniteurs> Moniteurs
		{
			get
			{
				return this.GetTable<Moniteurs>();
			}
		}
		
		public System.Data.Linq.Table<Personnes> Personnes
		{
			get
			{
				return this.GetTable<Personnes>();
			}
		}
		
		public System.Data.Linq.Table<Salles> Salles
		{
			get
			{
				return this.GetTable<Salles>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Activites")]
	public partial class Activites : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private System.TimeSpan _Heure_Debut;
		
		private System.TimeSpan _Heure_Fin;
		
		private int _Age_Min;
		
		private int _Age_Max;
		
		private System.Data.Linq.Binary _Photo;
		
		private System.Nullable<int> _Id_Moniteur;
		
		private System.Nullable<int> _Id_Personne;
		
		private EntitySet<Personnes> _Personnes1;
		
		private EntityRef<Moniteurs> _Moniteurs;
		
		private EntityRef<Personnes> _Personnes;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnHeure_DebutChanging(System.TimeSpan value);
    partial void OnHeure_DebutChanged();
    partial void OnHeure_FinChanging(System.TimeSpan value);
    partial void OnHeure_FinChanged();
    partial void OnAge_MinChanging(int value);
    partial void OnAge_MinChanged();
    partial void OnAge_MaxChanging(int value);
    partial void OnAge_MaxChanged();
    partial void OnPhotoChanging(System.Data.Linq.Binary value);
    partial void OnPhotoChanged();
    partial void OnId_MoniteurChanging(System.Nullable<int> value);
    partial void OnId_MoniteurChanged();
    partial void OnId_PersonneChanging(System.Nullable<int> value);
    partial void OnId_PersonneChanged();
    #endregion
		
		public Activites()
		{
			this._Personnes1 = new EntitySet<Personnes>(new Action<Personnes>(this.attach_Personnes1), new Action<Personnes>(this.detach_Personnes1));
			this._Moniteurs = default(EntityRef<Moniteurs>);
			this._Personnes = default(EntityRef<Personnes>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Heure_Debut", DbType="Time NOT NULL")]
		public System.TimeSpan Heure_Debut
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Heure_Fin", DbType="Time NOT NULL")]
		public System.TimeSpan Heure_Fin
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Photo", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Moniteur", DbType="Int")]
		public System.Nullable<int> Id_Moniteur
		{
			get
			{
				return this._Id_Moniteur;
			}
			set
			{
				if ((this._Id_Moniteur != value))
				{
					if (this._Moniteurs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_MoniteurChanging(value);
					this.SendPropertyChanging();
					this._Id_Moniteur = value;
					this.SendPropertyChanged("Id_Moniteur");
					this.OnId_MoniteurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Personne", DbType="Int")]
		public System.Nullable<int> Id_Personne
		{
			get
			{
				return this._Id_Personne;
			}
			set
			{
				if ((this._Id_Personne != value))
				{
					if (this._Personnes.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activites_Personnes", Storage="_Personnes1", ThisKey="Id", OtherKey="Id_Activite")]
		public EntitySet<Personnes> Personnes1
		{
			get
			{
				return this._Personnes1;
			}
			set
			{
				this._Personnes1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Moniteurs_Activites", Storage="_Moniteurs", ThisKey="Id_Moniteur", OtherKey="Id", IsForeignKey=true)]
		public Moniteurs Moniteurs
		{
			get
			{
				return this._Moniteurs.Entity;
			}
			set
			{
				Moniteurs previousValue = this._Moniteurs.Entity;
				if (((previousValue != value) 
							|| (this._Moniteurs.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Moniteurs.Entity = null;
						previousValue.Activites.Remove(this);
					}
					this._Moniteurs.Entity = value;
					if ((value != null))
					{
						value.Activites.Add(this);
						this._Id_Moniteur = value.Id;
					}
					else
					{
						this._Id_Moniteur = default(Nullable<int>);
					}
					this.SendPropertyChanged("Moniteurs");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Personnes_Activites", Storage="_Personnes", ThisKey="Id_Personne", OtherKey="Id", IsForeignKey=true)]
		public Personnes Personnes
		{
			get
			{
				return this._Personnes.Entity;
			}
			set
			{
				Personnes previousValue = this._Personnes.Entity;
				if (((previousValue != value) 
							|| (this._Personnes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Personnes.Entity = null;
						previousValue.Activites.Remove(this);
					}
					this._Personnes.Entity = value;
					if ((value != null))
					{
						value.Activites.Add(this);
						this._Id_Personne = value.Id;
					}
					else
					{
						this._Id_Personne = default(Nullable<int>);
					}
					this.SendPropertyChanged("Personnes");
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
		
		private void attach_Personnes1(Personnes entity)
		{
			this.SendPropertyChanging();
			entity.Activites1 = this;
		}
		
		private void detach_Personnes1(Personnes entity)
		{
			this.SendPropertyChanging();
			entity.Activites1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Moniteurs")]
	public partial class Moniteurs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Prenom;
		
		private EntitySet<Activites> _Activites;
		
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
    #endregion
		
		public Moniteurs()
		{
			this._Activites = new EntitySet<Activites>(new Action<Activites>(this.attach_Activites), new Action<Activites>(this.detach_Activites));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Moniteurs_Activites", Storage="_Activites", ThisKey="Id", OtherKey="Id_Moniteur")]
		public EntitySet<Activites> Activites
		{
			get
			{
				return this._Activites;
			}
			set
			{
				this._Activites.Assign(value);
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
		
		private void attach_Activites(Activites entity)
		{
			this.SendPropertyChanging();
			entity.Moniteurs = this;
		}
		
		private void detach_Activites(Activites entity)
		{
			this.SendPropertyChanging();
			entity.Moniteurs = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Personnes")]
	public partial class Personnes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom;
		
		private string _Prenom;
		
		private int _Age;
		
		private System.Nullable<int> _Id_Activite;
		
		private EntitySet<Activites> _Activites;
		
		private EntityRef<Activites> _Activites1;
		
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
    partial void OnId_ActiviteChanging(System.Nullable<int> value);
    partial void OnId_ActiviteChanged();
    #endregion
		
		public Personnes()
		{
			this._Activites = new EntitySet<Activites>(new Action<Activites>(this.attach_Activites), new Action<Activites>(this.detach_Activites));
			this._Activites1 = default(EntityRef<Activites>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Activite", DbType="Int")]
		public System.Nullable<int> Id_Activite
		{
			get
			{
				return this._Id_Activite;
			}
			set
			{
				if ((this._Id_Activite != value))
				{
					if (this._Activites1.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Personnes_Activites", Storage="_Activites", ThisKey="Id", OtherKey="Id_Personne")]
		public EntitySet<Activites> Activites
		{
			get
			{
				return this._Activites;
			}
			set
			{
				this._Activites.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Activites_Personnes", Storage="_Activites1", ThisKey="Id_Activite", OtherKey="Id", IsForeignKey=true)]
		public Activites Activites1
		{
			get
			{
				return this._Activites1.Entity;
			}
			set
			{
				Activites previousValue = this._Activites1.Entity;
				if (((previousValue != value) 
							|| (this._Activites1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Activites1.Entity = null;
						previousValue.Personnes1.Remove(this);
					}
					this._Activites1.Entity = value;
					if ((value != null))
					{
						value.Personnes1.Add(this);
						this._Id_Activite = value.Id;
					}
					else
					{
						this._Id_Activite = default(Nullable<int>);
					}
					this.SendPropertyChanged("Activites1");
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
		
		private void attach_Activites(Activites entity)
		{
			this.SendPropertyChanging();
			entity.Personnes = this;
		}
		
		private void detach_Activites(Activites entity)
		{
			this.SendPropertyChanging();
			entity.Personnes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Salles")]
	public partial class Salles : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nom_Activite;
		
		private string _Description;
		
		private string _Nom_Moniteur;
		
		private System.TimeSpan _Duree_Activite;
		
		private int _Effectif_Max;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNom_ActiviteChanging(string value);
    partial void OnNom_ActiviteChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnNom_MoniteurChanging(string value);
    partial void OnNom_MoniteurChanged();
    partial void OnDuree_ActiviteChanging(System.TimeSpan value);
    partial void OnDuree_ActiviteChanged();
    partial void OnEffectif_MaxChanging(int value);
    partial void OnEffectif_MaxChanged();
    #endregion
		
		public Salles()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom_Activite", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom_Activite
		{
			get
			{
				return this._Nom_Activite;
			}
			set
			{
				if ((this._Nom_Activite != value))
				{
					this.OnNom_ActiviteChanging(value);
					this.SendPropertyChanging();
					this._Nom_Activite = value;
					this.SendPropertyChanged("Nom_Activite");
					this.OnNom_ActiviteChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom_Moniteur", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Nom_Moniteur
		{
			get
			{
				return this._Nom_Moniteur;
			}
			set
			{
				if ((this._Nom_Moniteur != value))
				{
					this.OnNom_MoniteurChanging(value);
					this.SendPropertyChanging();
					this._Nom_Moniteur = value;
					this.SendPropertyChanged("Nom_Moniteur");
					this.OnNom_MoniteurChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duree_Activite", DbType="Time NOT NULL")]
		public System.TimeSpan Duree_Activite
		{
			get
			{
				return this._Duree_Activite;
			}
			set
			{
				if ((this._Duree_Activite != value))
				{
					this.OnDuree_ActiviteChanging(value);
					this.SendPropertyChanging();
					this._Duree_Activite = value;
					this.SendPropertyChanged("Duree_Activite");
					this.OnDuree_ActiviteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Effectif_Max", DbType="Int NOT NULL")]
		public int Effectif_Max
		{
			get
			{
				return this._Effectif_Max;
			}
			set
			{
				if ((this._Effectif_Max != value))
				{
					this.OnEffectif_MaxChanging(value);
					this.SendPropertyChanging();
					this._Effectif_Max = value;
					this.SendPropertyChanged("Effectif_Max");
					this.OnEffectif_MaxChanged();
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
