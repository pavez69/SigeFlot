using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SigeFlot.Entidades
{
    public partial class BD_FLOTA_VEHICULOSContext : DbContext
    {
        public BD_FLOTA_VEHICULOSContext()
        {
        }

        public BD_FLOTA_VEHICULOSContext(DbContextOptions<BD_FLOTA_VEHICULOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdministradorCorreo> AdministradorCorreos { get; set; } = null!;
        public virtual DbSet<ArchivoXml> ArchivoXmls { get; set; } = null!;
        public virtual DbSet<ArchivoXmlGrupoArchivoXml> ArchivoXmlGrupoArchivoXmls { get; set; } = null!;
        public virtual DbSet<Choferxxx> Choferxxxes { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Destino> Destinos { get; set; } = null!;
        public virtual DbSet<EncuestaFlotaVehiculo> EncuestaFlotaVehiculos { get; set; } = null!;
        public virtual DbSet<EncuestaFlotaVehiculoMasiva> EncuestaFlotaVehiculoMasivas { get; set; } = null!;
        public virtual DbSet<EstadoChofer> EstadoChofers { get; set; } = null!;
        public virtual DbSet<EstadoSolicitudVehiculo> EstadoSolicitudVehiculos { get; set; } = null!;
        public virtual DbSet<EstadoVehiculo> EstadoVehiculos { get; set; } = null!;
        public virtual DbSet<EstadoViaje> EstadoViajes { get; set; } = null!;
        public virtual DbSet<GrupoArchivoXml> GrupoArchivoXmls { get; set; } = null!;
        public virtual DbSet<Mantencion> Mantencions { get; set; } = null!;
        public virtual DbSet<Marca> Marcas { get; set; } = null!;
        public virtual DbSet<Origen> Origens { get; set; } = null!;
        public virtual DbSet<TipoCarrocerium> TipoCarroceria { get; set; } = null!;
        public virtual DbSet<TipoCombustible> TipoCombustibles { get; set; } = null!;
        public virtual DbSet<TipoMantencion> TipoMantencions { get; set; } = null!;
        public virtual DbSet<TipoVehiculo> TipoVehiculos { get; set; } = null!;
        public virtual DbSet<Traccion> Traccions { get; set; } = null!;
        public virtual DbSet<Vehiculo> Vehiculos { get; set; } = null!;
        public virtual DbSet<Viaje> Viajes { get; set; } = null!;
        public virtual DbSet<ViajeSolicitud> ViajeSolicituds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ACUARIO\\DESARROLLO; Database=BD_FLOTA_VEHICULOS; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AdministradorCorreo>(entity =>
            {
                entity.HasKey(e => new { e.Rut, e.IdProvincia })
                    .HasName("PK_ADMINISTRADOR_CORREO");

                entity.ToTable("Administrador_Correo");

                entity.Property(e => e.IdProvincia).HasColumnName("Id_Provincia");
            });

            modelBuilder.Entity<ArchivoXml>(entity =>
            {
                entity.HasKey(e => e.IdArchivoXml)
                    .HasName("PK_ARCHIVO_XML");

                entity.ToTable("Archivo_Xml");

                entity.Property(e => e.IdArchivoXml)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Archivo_Xml");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivoXml)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Archivo_Xml");
            });

            modelBuilder.Entity<ArchivoXmlGrupoArchivoXml>(entity =>
            {
                entity.HasKey(e => new { e.IdArchivoXml, e.IdGrupoArchivoXml })
                    .HasName("PK_ARCHIVO_XML_GRUPO_ARCHIVO_XML");

                entity.ToTable("Archivo_Xml_Grupo_Archivo_Xml");

                entity.Property(e => e.IdArchivoXml).HasColumnName("Id_Archivo_Xml");

                entity.Property(e => e.IdGrupoArchivoXml).HasColumnName("Id_Grupo_Archivo_Xml");

                entity.Property(e => e.AltoVentana).HasColumnName("Alto_Ventana");

                entity.Property(e => e.AnchoVentana).HasColumnName("Ancho_Ventana");

                entity.Property(e => e.FiltroAcno).HasColumnName("Filtro_Acno");

                entity.Property(e => e.FiltroAcnoMes).HasColumnName("Filtro_Acno_Mes");

                entity.Property(e => e.FiltroChofer).HasColumnName("Filtro_Chofer");

                entity.Property(e => e.FiltroFecha).HasColumnName("Filtro_Fecha");

                entity.Property(e => e.FiltroVehiculo).HasColumnName("Filtro_Vehiculo");

                entity.Property(e => e.OpcionFechaAcnoMes).HasColumnName("Opcion_Fecha_Acno_Mes");
            });

            modelBuilder.Entity<Choferxxx>(entity =>
            {
                entity.HasKey(e => e.RutChofer)
                    .HasName("PK_CHOFER")
                    .IsClustered(false);

                entity.ToTable("CHOFERxxx");

                entity.HasIndex(e => e.IdEstadoChofer, "CHOFER_ESTADO_CHOFER_FK");

                entity.Property(e => e.RutChofer)
                    .ValueGeneratedNever()
                    .HasColumnName("RUT_CHOFER");

                entity.Property(e => e.IdEstadoChofer).HasColumnName("ID_ESTADO_CHOFER");

                entity.Property(e => e.IdProvincia).HasColumnName("ID_PROVINCIA");

                entity.HasOne(d => d.IdEstadoChoferNavigation)
                    .WithMany(p => p.Choferxxxes)
                    .HasForeignKey(d => d.IdEstadoChofer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CHOFER_CHOFER_ES_ESTADO_C");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.IdColor)
                    .HasName("PK_COLOR")
                    .IsClustered(false);

                entity.ToTable("Color");

                entity.Property(e => e.IdColor).HasColumnName("Id_Color");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreColor)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Color");
            });

            modelBuilder.Entity<Destino>(entity =>
            {
                entity.HasKey(e => e.IdDestino);

                entity.ToTable("Destino");

                entity.Property(e => e.IdDestino).HasColumnName("Id_Destino");

                entity.Property(e => e.IdComuna).HasColumnName("Id_Comuna");

                entity.Property(e => e.IdLocalidad).HasColumnName("Id_Localidad");

                entity.Property(e => e.IdViaje).HasColumnName("Id_Viaje");

                entity.Property(e => e.TipoDestino).HasColumnName("Tipo_Destino");
            });

            modelBuilder.Entity<EncuestaFlotaVehiculo>(entity =>
            {
                entity.HasKey(e => new { e.IdViaje, e.IdSolicitud })
                    .HasName("PK_ENCUESTA_FLOTA_VEHICULO");

                entity.ToTable("Encuesta_Flota_Vehiculo");

                entity.Property(e => e.IdViaje).HasColumnName("Id_Viaje");

                entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");

                entity.Property(e => e.FechaRespuesta)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Respuesta");
            });

            modelBuilder.Entity<EncuestaFlotaVehiculoMasiva>(entity =>
            {
                entity.HasKey(e => e.Rut)
                    .HasName("PK_ENCUESTA_FLOTA_VEHICULO_MASIVA");

                entity.ToTable("Encuesta_Flota_Vehiculo_Masiva");

                entity.Property(e => e.Rut).ValueGeneratedNever();

                entity.Property(e => e.FechaRespuesta)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Respuesta");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoChofer>(entity =>
            {
                entity.HasKey(e => e.IdEstadoChofer)
                    .HasName("PK_ESTADO_CHOFER")
                    .IsClustered(false);

                entity.ToTable("Estado_Chofer");

                entity.Property(e => e.IdEstadoChofer)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Estado_Chofer");

                entity.Property(e => e.NombreEstadoChofer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Estado_Chofer");
            });

            modelBuilder.Entity<EstadoSolicitudVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdEstadoSolicitudVehiculo);

                entity.ToTable("Estado_Solicitud_Vehiculo");

                entity.Property(e => e.IdEstadoSolicitudVehiculo)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Estado_Solicitud_Vehiculo");

                entity.Property(e => e.NombreEstadoSolicitudVehiculo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Estado_Solicitud_Vehiculo");
            });

            modelBuilder.Entity<EstadoVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdEstadoVehiculo)
                    .HasName("PK_ESTADO_VEHICULO");

                entity.ToTable("Estado_Vehiculo");

                entity.Property(e => e.IdEstadoVehiculo).HasColumnName("Id_Estado_Vehiculo");

                entity.Property(e => e.NombreEstadoVehiculo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Estado_Vehiculo");
            });

            modelBuilder.Entity<EstadoViaje>(entity =>
            {
                entity.HasKey(e => e.IdEstadoViaje)
                    .HasName("PK_ESTADO_VIAJE");

                entity.ToTable("Estado_Viaje");

                entity.Property(e => e.IdEstadoViaje)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Estado_Viaje");

                entity.Property(e => e.NombreEstadoViaje)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Estado_Viaje");
            });

            modelBuilder.Entity<GrupoArchivoXml>(entity =>
            {
                entity.HasKey(e => e.IdGrupoArchivoXml)
                    .HasName("PK_GRUPO_ARCHIVO_XML");

                entity.ToTable("Grupo_Archivo_Xml");

                entity.Property(e => e.IdGrupoArchivoXml)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Grupo_Archivo_Xml");

                entity.Property(e => e.NombreGrupoArchivoXml)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Grupo_Archivo_Xml");
            });

            modelBuilder.Entity<Mantencion>(entity =>
            {
                entity.HasKey(e => e.IdMantencion)
                    .HasName("PK_MANTENCION")
                    .IsClustered(false);

                entity.ToTable("Mantencion");

                entity.HasIndex(e => e.IdTipoMantencion, "MANTENCION_TIPO_MANTENCION_FK");

                entity.HasIndex(e => e.IdVehiculo, "VEHICULO_MANTENCION_FK");

                entity.Property(e => e.IdMantencion)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Mantencion");

                entity.Property(e => e.DescripcionMantencion)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("Descripcion_Mantencion");

                entity.Property(e => e.FechaMantencion)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Mantencion");

                entity.Property(e => e.IdTipoMantencion).HasColumnName("Id_Tipo_Mantencion");

                entity.Property(e => e.IdVehiculo).HasColumnName("Id_Vehiculo");

                entity.HasOne(d => d.IdTipoMantencionNavigation)
                    .WithMany(p => p.Mantencions)
                    .HasForeignKey(d => d.IdTipoMantencion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MANTENCI_MANTENCIO_TIPO_MAN");

                entity.HasOne(d => d.IdVehiculoNavigation)
                    .WithMany(p => p.Mantencions)
                    .HasForeignKey(d => d.IdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MANTENCI_VEHICULO__VEHICULO");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK_MARCA")
                    .IsClustered(false);

                entity.ToTable("Marca");

                entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreMarca)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Marca");
            });

            modelBuilder.Entity<Origen>(entity =>
            {
                entity.HasKey(e => e.IdOrigen)
                    .HasName("PK_ORIGEN")
                    .IsClustered(false);

                entity.ToTable("Origen");

                entity.Property(e => e.IdOrigen).HasColumnName("Id_Origen");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreOrigen)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Origen");
            });

            modelBuilder.Entity<TipoCarrocerium>(entity =>
            {
                entity.HasKey(e => e.IdTipoCarroceria)
                    .HasName("PK_TIPO_CARROCERIA")
                    .IsClustered(false);

                entity.ToTable("Tipo_Carroceria");

                entity.Property(e => e.IdTipoCarroceria).HasColumnName("Id_Tipo_Carroceria");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreTipoCarroceria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Tipo_Carroceria");
            });

            modelBuilder.Entity<TipoCombustible>(entity =>
            {
                entity.HasKey(e => e.IdTipoCombustible)
                    .HasName("PK_TIPO_COMBUSTIBLE")
                    .IsClustered(false);

                entity.ToTable("Tipo_Combustible");

                entity.Property(e => e.IdTipoCombustible).HasColumnName("Id_Tipo_Combustible");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreTipoCombustible)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Tipo_Combustible");
            });

            modelBuilder.Entity<TipoMantencion>(entity =>
            {
                entity.HasKey(e => e.IdTipoMantencion)
                    .HasName("PK_TIPO_MANTENCION")
                    .IsClustered(false);

                entity.ToTable("Tipo_Mantencion");

                entity.Property(e => e.IdTipoMantencion)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Tipo_Mantencion");

                entity.Property(e => e.NombreTipoMantencion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Tipo_Mantencion");
            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdTipoVehiculo)
                    .HasName("PK_TIPO_VEHICULO")
                    .IsClustered(false);

                entity.ToTable("Tipo_Vehiculo");

                entity.Property(e => e.IdTipoVehiculo).HasColumnName("Id_Tipo_Vehiculo");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreTipoVehiculo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Tipo_Vehiculo");
            });

            modelBuilder.Entity<Traccion>(entity =>
            {
                entity.HasKey(e => e.IdTraccion)
                    .HasName("PK_TRACCION")
                    .IsClustered(false);

                entity.ToTable("Traccion");

                entity.Property(e => e.IdTraccion).HasColumnName("Id_Traccion");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.NombreTraccion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Traccion");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehiculo)
                    .HasName("PK_VEHICULO")
                    .IsClustered(false);

                entity.ToTable("Vehiculo");

                entity.HasIndex(e => e.IdColor, "VEHICULO_COLOR_VEHICULO_FK");

                entity.HasIndex(e => e.IdMarca, "VEHICULO_MARCA_FK");

                entity.HasIndex(e => e.IdOrigen, "VEHICULO_ORIGEN_VEHICULO_FK");

                entity.HasIndex(e => e.IdTipoCarroceria, "VEHICULO_TIPO_CARROCERIA_FK");

                entity.HasIndex(e => e.IdTipoCombustible, "VEHICULO_TIPO_COMBUSTIBLE_FK");

                entity.HasIndex(e => e.IdTipoVehiculo, "VEHICULO_TIPO_VEHICULO_FK");

                entity.HasIndex(e => e.IdTraccion, "VEHICULO_TRACCION_FK");

                entity.Property(e => e.IdVehiculo).HasColumnName("Id_Vehiculo");

                entity.Property(e => e.IdColor).HasColumnName("Id_Color");

                entity.Property(e => e.IdEstadoVehiculo).HasColumnName("Id_Estado_Vehiculo");

                entity.Property(e => e.IdMarca).HasColumnName("Id_Marca");

                entity.Property(e => e.IdOrigen).HasColumnName("Id_Origen");

                entity.Property(e => e.IdProvincia).HasColumnName("Id_Provincia");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.IdTipoCarroceria).HasColumnName("Id_Tipo_Carroceria");

                entity.Property(e => e.IdTipoCombustible).HasColumnName("Id_Tipo_Combustible");

                entity.Property(e => e.IdTipoVehiculo).HasColumnName("Id_Tipo_Vehiculo");

                entity.Property(e => e.IdTraccion).HasColumnName("Id_Traccion");

                entity.Property(e => e.KmActual).HasColumnName("Km_Actual");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroAsientos).HasColumnName("Numero_Asientos");

                entity.Property(e => e.NumeroChasis)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Chasis");

                entity.Property(e => e.NumeroInventario)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Inventario");

                entity.Property(e => e.NumeroMotor)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Numero_Motor");

                entity.Property(e => e.Patente)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdColorNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdColor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__COLOR");

                entity.HasOne(d => d.IdEstadoVehiculoNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdEstadoVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_ESTADO_VEHICULO");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdMarca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__MARCA");

                entity.HasOne(d => d.IdOrigenNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__ORIGEN");

                entity.HasOne(d => d.IdTipoCarroceriaNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdTipoCarroceria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__TIPO_CAR");

                entity.HasOne(d => d.IdTipoCombustibleNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdTipoCombustible)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__TIPO_COM");

                entity.HasOne(d => d.IdTipoVehiculoNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdTipoVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__TIPO_VEH");

                entity.HasOne(d => d.IdTraccionNavigation)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.IdTraccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULO_VEHICULO__TRACCION");
            });

            modelBuilder.Entity<Viaje>(entity =>
            {
                entity.HasKey(e => e.IdViaje)
                    .HasName("PK_VIAJE")
                    .IsClustered(false);

                entity.ToTable("Viaje");

                entity.HasIndex(e => e.RutAdmin, "VIAJE_CHOFER_FK");

                entity.HasIndex(e => e.IdVehiculo, "VIAJE_VEHICULO_FK");

                entity.Property(e => e.IdViaje).HasColumnName("Id_Viaje");

                entity.Property(e => e.Destino)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Inicio");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Termino");

                entity.Property(e => e.FechaViaje)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Viaje");

                entity.Property(e => e.IdEstadoViaje).HasColumnName("Id_Estado_Viaje");

                entity.Property(e => e.IdHoraInicio).HasColumnName("Id_Hora_Inicio");

                entity.Property(e => e.IdHoraTermino).HasColumnName("Id_Hora_Termino");

                entity.Property(e => e.IdProvincia).HasColumnName("Id_Provincia");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.IdVehiculo).HasColumnName("Id_Vehiculo");

                entity.Property(e => e.KmInicio).HasColumnName("Km_Inicio");

                entity.Property(e => e.KmTermino).HasColumnName("Km_Termino");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RutAdmin).HasColumnName("Rut_Admin");

                entity.Property(e => e.RutChofer).HasColumnName("Rut_Chofer");

                entity.HasOne(d => d.IdEstadoViajeNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdEstadoViaje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIAJE_ESTADO_VIAJE");

                entity.HasOne(d => d.IdVehiculoNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdVehiculo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VIAJE_VIAJE_VEH_VEHICULO");
            });

            modelBuilder.Entity<ViajeSolicitud>(entity =>
            {
                entity.HasKey(e => new { e.IdViaje, e.IdSolicitud });

                entity.ToTable("Viaje_Solicitud");

                entity.Property(e => e.IdViaje).HasColumnName("Id_Viaje");

                entity.Property(e => e.IdSolicitud).HasColumnName("Id_Solicitud");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
