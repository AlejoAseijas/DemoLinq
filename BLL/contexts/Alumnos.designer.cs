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

namespace BLL.contexts
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LINQ_SQL")]
	public partial class AlumnosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertalumnos(alumnos instance);
    partial void Updatealumnos(alumnos instance);
    partial void Deletealumnos(alumnos instance);
    partial void Insertmaterias(materias instance);
    partial void Updatematerias(materias instance);
    partial void Deletematerias(materias instance);
    partial void Insertnotas(notas instance);
    partial void Updatenotas(notas instance);
    partial void Deletenotas(notas instance);
    #endregion
		
		public AlumnosDataContext() : 
				base(global::BLL.Properties.Settings.Default.LINQ_SQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AlumnosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlumnosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlumnosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AlumnosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<alumnos> alumnos
		{
			get
			{
				return this.GetTable<alumnos>();
			}
		}
		
		public System.Data.Linq.Table<materias> materias
		{
			get
			{
				return this.GetTable<materias>();
			}
		}
		
		public System.Data.Linq.Table<notas> notas
		{
			get
			{
				return this.GetTable<notas>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.alumnos")]
	public partial class alumnos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdAlumno;
		
		private string _Nombre;
		
		private string _Apellido;
		
		private string _DNI;
		
		private EntitySet<notas> _notas;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdAlumnoChanging(int value);
    partial void OnIdAlumnoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnDNIChanging(string value);
    partial void OnDNIChanged();
    #endregion
		
		public alumnos()
		{
			this._notas = new EntitySet<notas>(new Action<notas>(this.attach_notas), new Action<notas>(this.detach_notas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAlumno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdAlumno
		{
			get
			{
				return this._IdAlumno;
			}
			set
			{
				if ((this._IdAlumno != value))
				{
					this.OnIdAlumnoChanging(value);
					this.SendPropertyChanging();
					this._IdAlumno = value;
					this.SendPropertyChanged("IdAlumno");
					this.OnIdAlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Apellido
		{
			get
			{
				return this._Apellido;
			}
			set
			{
				if ((this._Apellido != value))
				{
					this.OnApellidoChanging(value);
					this.SendPropertyChanging();
					this._Apellido = value;
					this.SendPropertyChanged("Apellido");
					this.OnApellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this.OnDNIChanging(value);
					this.SendPropertyChanging();
					this._DNI = value;
					this.SendPropertyChanged("DNI");
					this.OnDNIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="alumnos_notas", Storage="_notas", ThisKey="IdAlumno", OtherKey="IdAlumno")]
		public EntitySet<notas> notas
		{
			get
			{
				return this._notas;
			}
			set
			{
				this._notas.Assign(value);
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
		
		private void attach_notas(notas entity)
		{
			this.SendPropertyChanging();
			entity.alumnos = this;
		}
		
		private void detach_notas(notas entity)
		{
			this.SendPropertyChanging();
			entity.alumnos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.materias")]
	public partial class materias : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdMateria;
		
		private string _Materia;
		
		private EntitySet<notas> _notas;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdMateriaChanging(int value);
    partial void OnIdMateriaChanged();
    partial void OnMateriaChanging(string value);
    partial void OnMateriaChanged();
    #endregion
		
		public materias()
		{
			this._notas = new EntitySet<notas>(new Action<notas>(this.attach_notas), new Action<notas>(this.detach_notas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMateria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdMateria
		{
			get
			{
				return this._IdMateria;
			}
			set
			{
				if ((this._IdMateria != value))
				{
					this.OnIdMateriaChanging(value);
					this.SendPropertyChanging();
					this._IdMateria = value;
					this.SendPropertyChanged("IdMateria");
					this.OnIdMateriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Materia", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Materia
		{
			get
			{
				return this._Materia;
			}
			set
			{
				if ((this._Materia != value))
				{
					this.OnMateriaChanging(value);
					this.SendPropertyChanging();
					this._Materia = value;
					this.SendPropertyChanged("Materia");
					this.OnMateriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="materias_notas", Storage="_notas", ThisKey="IdMateria", OtherKey="IdMateria")]
		public EntitySet<notas> notas
		{
			get
			{
				return this._notas;
			}
			set
			{
				this._notas.Assign(value);
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
		
		private void attach_notas(notas entity)
		{
			this.SendPropertyChanging();
			entity.materias = this;
		}
		
		private void detach_notas(notas entity)
		{
			this.SendPropertyChanging();
			entity.materias = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.notas")]
	public partial class notas : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdNota;
		
		private int _IdAlumno;
		
		private int _IdMateria;
		
		private double _Nota;
		
		private EntityRef<alumnos> _alumnos;
		
		private EntityRef<materias> _materias;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNotaChanging(int value);
    partial void OnIdNotaChanged();
    partial void OnIdAlumnoChanging(int value);
    partial void OnIdAlumnoChanged();
    partial void OnIdMateriaChanging(int value);
    partial void OnIdMateriaChanged();
    partial void OnNotaChanging(double value);
    partial void OnNotaChanged();
    #endregion
		
		public notas()
		{
			this._alumnos = default(EntityRef<alumnos>);
			this._materias = default(EntityRef<materias>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNota", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdNota
		{
			get
			{
				return this._IdNota;
			}
			set
			{
				if ((this._IdNota != value))
				{
					this.OnIdNotaChanging(value);
					this.SendPropertyChanging();
					this._IdNota = value;
					this.SendPropertyChanged("IdNota");
					this.OnIdNotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdAlumno", DbType="Int NOT NULL")]
		public int IdAlumno
		{
			get
			{
				return this._IdAlumno;
			}
			set
			{
				if ((this._IdAlumno != value))
				{
					if (this._alumnos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdAlumnoChanging(value);
					this.SendPropertyChanging();
					this._IdAlumno = value;
					this.SendPropertyChanged("IdAlumno");
					this.OnIdAlumnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMateria", DbType="Int NOT NULL")]
		public int IdMateria
		{
			get
			{
				return this._IdMateria;
			}
			set
			{
				if ((this._IdMateria != value))
				{
					if (this._materias.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdMateriaChanging(value);
					this.SendPropertyChanging();
					this._IdMateria = value;
					this.SendPropertyChanged("IdMateria");
					this.OnIdMateriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nota", DbType="Float NOT NULL")]
		public double Nota
		{
			get
			{
				return this._Nota;
			}
			set
			{
				if ((this._Nota != value))
				{
					this.OnNotaChanging(value);
					this.SendPropertyChanging();
					this._Nota = value;
					this.SendPropertyChanged("Nota");
					this.OnNotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="alumnos_notas", Storage="_alumnos", ThisKey="IdAlumno", OtherKey="IdAlumno", IsForeignKey=true)]
		public alumnos alumnos
		{
			get
			{
				return this._alumnos.Entity;
			}
			set
			{
				alumnos previousValue = this._alumnos.Entity;
				if (((previousValue != value) 
							|| (this._alumnos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._alumnos.Entity = null;
						previousValue.notas.Remove(this);
					}
					this._alumnos.Entity = value;
					if ((value != null))
					{
						value.notas.Add(this);
						this._IdAlumno = value.IdAlumno;
					}
					else
					{
						this._IdAlumno = default(int);
					}
					this.SendPropertyChanged("alumnos");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="materias_notas", Storage="_materias", ThisKey="IdMateria", OtherKey="IdMateria", IsForeignKey=true)]
		public materias materias
		{
			get
			{
				return this._materias.Entity;
			}
			set
			{
				materias previousValue = this._materias.Entity;
				if (((previousValue != value) 
							|| (this._materias.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._materias.Entity = null;
						previousValue.notas.Remove(this);
					}
					this._materias.Entity = value;
					if ((value != null))
					{
						value.notas.Add(this);
						this._IdMateria = value.IdMateria;
					}
					else
					{
						this._IdMateria = default(int);
					}
					this.SendPropertyChanged("materias");
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