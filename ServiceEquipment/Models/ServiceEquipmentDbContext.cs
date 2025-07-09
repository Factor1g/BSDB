using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ServiceEquipment.Models;

public partial class ServiceEquipmentDbContext : DbContext
{
    public ServiceEquipmentDbContext()
    {
    }

    public ServiceEquipmentDbContext(DbContextOptions<ServiceEquipmentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alvallalkozok> Alvallalkozoks { get; set; }

    public virtual DbSet<Belimo> Belimos { get; set; }

    public virtual DbSet<Berendezesek> Berendezeseks { get; set; }

    public virtual DbSet<Csapadekviz> Csapadekvizs { get; set; }

    public virtual DbSet<Csovezetekek> Csovezetekeks { get; set; }

    public virtual DbSet<Kazanok> Kazanoks { get; set; }

    public virtual DbSet<Kontaktok> Kontaktoks { get; set; }

    public virtual DbSet<Legcsatornak> Legcsatornaks { get; set; }

    public virtual DbSet<OsztokGyujtok> OsztokGyujtoks { get; set; }

    public virtual DbSet<Projektek> Projekteks { get; set; }

    public virtual DbSet<SplitKlimak> SplitKlimaks { get; set; }

    public virtual DbSet<Szaniter> Szaniters { get; set; }

    public virtual DbSet<Szerelvenyek> Szerelvenyeks { get; set; }

    public virtual DbSet<Szigetele> Szigeteles { get; set; }

    public virtual DbSet<Szivattyuk> Szivattyuks { get; set; }

    public virtual DbSet<Szolgaltatasok> Szolgaltatasoks { get; set; }

    public virtual DbSet<TagulasiTartly> TagulasiTartlies { get; set; }

    public virtual DbSet<TarolokPufferek> TarolokPuffereks { get; set; }

    public virtual DbSet<Tmpclp440161> Tmpclp440161s { get; set; }

    public virtual DbSet<Vizlagyitok> Vizlagyitoks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ServiceEquipmentDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alvallalkozok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Alvallalkozok$PrimaryKey");

            entity.ToTable("Alvallalkozok");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nev)
                .HasMaxLength(255)
                .HasColumnName("nev");
            entity.Property(e => e.Terulet)
                .HasMaxLength(255)
                .HasColumnName("terulet");
        });

        modelBuilder.Entity<Belimo>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Belimo$PrimaryKey");

            entity.ToTable("Belimo");

            entity.HasIndex(e => e.AlvallalkozoId, "Belimo$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagEur)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_EUR");
            entity.Property(e => e.Cikkszam)
                .HasMaxLength(255)
                .HasColumnName("cikkszam");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.Leiras).HasColumnName("leiras");
            entity.Property(e => e.Megjegyzes)
                .HasMaxLength(255)
                .HasColumnName("megjegyzes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Belimos)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Belimo$AlvallalkozokBelimo");
        });

        modelBuilder.Entity<Berendezesek>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Berendezesek$PrimaryKey");

            entity.ToTable("Berendezesek");

            entity.HasIndex(e => e.AlvallalkozoId, "Berendezesek$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Berendezes)
                .HasMaxLength(255)
                .HasColumnName("berendezes");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.Termek)
                .HasMaxLength(255)
                .HasColumnName("termek");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Berendezeseks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Berendezesek$AlvallalkozokBerendezesek");
        });

        modelBuilder.Entity<Csapadekviz>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Csapadekviz$PrimaryKey");

            entity.ToTable("Csapadekviz");

            entity.HasIndex(e => e.AlvallalkozoId, "Csapadekviz$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.Anyag)
                .HasMaxLength(255)
                .HasColumnName("anyag");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megjegyzes)
                .HasMaxLength(255)
                .HasColumnName("megjegyzes");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.Meret)
                .HasMaxLength(255)
                .HasColumnName("meret");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Csapadekvizs)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Csapadekviz$AlvallalkozokCsapadekviz");

            entity.HasOne(d => d.ProjektSzamNavigation).WithMany(p => p.Csapadekvizs)
                .HasForeignKey(d => d.ProjektSzam)
                .HasConstraintName("Csapadekviz$ProjektekCsapadekviz");
        });

        modelBuilder.Entity<Csovezetekek>(entity =>
        {
            entity.HasKey(e => e.Azonosito).HasName("Csovezetekek$PrimaryKey");

            entity.ToTable("Csovezetekek");

            entity.HasIndex(e => e.AlvallalkozoId, "Csovezetekek$alvallalkozo_ID");

            entity.HasIndex(e => e.Idomokkal, "Csovezetekek$idomokkal");

            entity.Property(e => e.Azonosito).HasColumnName("azonosito");
            entity.Property(e => e.AjanlatDatum)
                .HasPrecision(0)
                .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(1)))")
                .HasColumnName("ajanlat_datum");
            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.Anyag)
                .HasMaxLength(255)
                .HasColumnName("anyag");
            entity.Property(e => e.AnyagEur)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_EUR");
            entity.Property(e => e.AnyagHuf)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Atmero)
                .HasDefaultValue(0f)
                .HasColumnName("atmero");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Dn)
                .HasDefaultValue(0)
                .HasColumnName("dn");
            entity.Property(e => e.Falvastagag)
                .HasDefaultValue(0f)
                .HasColumnName("falvastagag");
            entity.Property(e => e.Feluletkezeles)
                .HasMaxLength(255)
                .HasColumnName("feluletkezeles");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Idomokkal)
                .HasDefaultValue(false)
                .HasColumnName("idomokkal");
            entity.Property(e => e.Megjegyzes)
                .HasMaxLength(255)
                .HasColumnName("megjegyzes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Szabvany)
                .HasMaxLength(255)
                .HasColumnName("szabvany");
            entity.Property(e => e.Varrat)
                .HasMaxLength(255)
                .HasColumnName("varrat");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Csovezetekeks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Csovezetekek$AlvallalkozokAcelcsovek");
        });

        modelBuilder.Entity<Kazanok>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Kazanok$PrimaryKey");

            entity.ToTable("Kazanok");

            entity.HasIndex(e => e.AlvallalkozoId, "Kazanok$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.FutoTeljesitmenyKW)
                .HasDefaultValue(0)
                .HasColumnName("futo_teljesitmeny_kW");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");
        });

        modelBuilder.Entity<Kontaktok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Kontaktok$PrimaryKey");

            entity.ToTable("Kontaktok");

            entity.HasIndex(e => e.Telefonszam, "Kontaktok$Mobiltelefonszám");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alvallakozo)
                .HasDefaultValue(0)
                .HasColumnName("alvallakozo");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Nev)
                .HasMaxLength(255)
                .HasColumnName("nev");
            entity.Property(e => e.Telefonszam)
                .HasMaxLength(255)
                .HasColumnName("telefonszam");

            entity.HasOne(d => d.AlvallakozoNavigation).WithMany(p => p.Kontaktoks)
                .HasForeignKey(d => d.Alvallakozo)
                .HasConstraintName("Kontaktok$AlvallalkozokKontaktok");
        });

        modelBuilder.Entity<Legcsatornak>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Legcsatornak$PrimaryKey");

            entity.ToTable("legcsatornak");

            entity.HasIndex(e => e.AlvallalkozoId, "Legcsatornak$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Anyagminoseg)
                .HasMaxLength(255)
                .HasColumnName("anyagminoseg");
            entity.Property(e => e.Cikkszam)
                .HasMaxLength(255)
                .HasColumnName("cikkszam");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Egyseg)
                .HasMaxLength(255)
                .HasColumnName("egyseg");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.MeretMm)
                .HasMaxLength(255)
                .HasColumnName("meret_mm");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Legcsatornaks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Legcsatornak$AlvallalkozokLegcsatornak");
        });

        modelBuilder.Entity<OsztokGyujtok>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Osztok_gyujtok$PrimaryKey");

            entity.ToTable("Osztok_gyujtok");

            entity.HasIndex(e => e.AlvallalkozoId, "Osztok_gyujtok$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.HosszMm)
                .HasMaxLength(255)
                .HasColumnName("hossz_mm");
            entity.Property(e => e.Korok)
                .HasMaxLength(255)
                .HasColumnName("korok");
            entity.Property(e => e.Megjegyzes)
                .HasMaxLength(255)
                .HasColumnName("megjegyzes");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
        });

        modelBuilder.Entity<Projektek>(entity =>
        {
            entity.HasKey(e => e.ProjektSzam).HasName("Projektek$PrimaryKey");

            entity.ToTable("Projektek");

            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.Beruhazo)
                .HasMaxLength(255)
                .HasColumnName("beruhazo");
            entity.Property(e => e.Helyszin)
                .HasMaxLength(255)
                .HasColumnName("helyszin");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");
        });

        modelBuilder.Entity<SplitKlimak>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Split_klimak$PrimaryKey");

            entity.ToTable("Split_klimak");

            entity.HasIndex(e => e.AlvallalkozoId, "Split_klimak$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagEur)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_EUR");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Cikkszam)
                .HasMaxLength(255)
                .HasColumnName("cikkszam");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.TeljesitmenyKW)
                .HasDefaultValue(0f)
                .HasColumnName("teljesitmeny_kW");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.SplitKlimaks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Split_klimak$AlvallalkozokSplit_klimak");
        });

        modelBuilder.Entity<Szaniter>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Szaniter$PrimaryKey");

            entity.ToTable("Szaniter");

            entity.HasIndex(e => e.AlvallalkozoId, "Szaniter$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
        });

        modelBuilder.Entity<Szerelvenyek>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Szerelvenyek$PrimaryKey");

            entity.ToTable("Szerelvenyek");

            entity.HasIndex(e => e.AlvallalkozoId, "Szerelvenyek$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.Anyag)
                .HasMaxLength(255)
                .HasColumnName("anyag");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Atmero)
                .HasDefaultValue(0)
                .HasColumnName("atmero");
            entity.Property(e => e.Csatlakozas)
                .HasMaxLength(255)
                .HasColumnName("csatlakozas");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megjegyzes)
                .HasMaxLength(255)
                .HasColumnName("megjegyzes");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.Nyomas)
                .HasDefaultValue(0)
                .HasColumnName("nyomas");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.TerfogataramLh).HasColumnName("terfogataram_lh");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Szerelvenyeks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Szerelvenyek$AlvallalkozokSzelepek");
        });

        modelBuilder.Entity<Szigetele>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Szigeteles$PrimaryKey");

            entity.HasIndex(e => e.AlvallalkozoId, "Szigeteles$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.CsoDn)
                .HasDefaultValue(0)
                .HasColumnName("cso_DN");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Egyseg)
                .HasMaxLength(255)
                .HasColumnName("egyseg");
            entity.Property(e => e.Falvastagsag)
                .HasDefaultValue(0f)
                .HasColumnName("falvastagsag");
            entity.Property(e => e.KulsoAtmero)
                .HasDefaultValue(0)
                .HasColumnName("kulso_atmero");
            entity.Property(e => e.Mező1).HasMaxLength(255);
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Szigeteles)
                .HasMaxLength(255)
                .HasColumnName("szigeteles");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Szigeteles)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Szigeteles$AlvallalkozokSzigeteles");
        });

        modelBuilder.Entity<Szivattyuk>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Szivattyuk$PrimaryKey");

            entity.ToTable("Szivattyuk");

            entity.HasIndex(e => e.AlvallalkozoId, "Szivattyuk$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Cikkszam)
                .HasMaxLength(255)
                .HasColumnName("cikkszam");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megjegyzes)
                .HasMaxLength(255)
                .HasColumnName("megjegyzes");
            entity.Property(e => e.NyomasBar)
                .HasDefaultValue(0f)
                .HasColumnName("nyomas_bar");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.SzallitomagassagM)
                .HasDefaultValue(0f)
                .HasColumnName("szallitomagassag_m");
            entity.Property(e => e.TeljesitmenyKW)
                .HasDefaultValue(0f)
                .HasColumnName("teljesitmeny_kW");
            entity.Property(e => e.TerfogataramM3h)
                .HasDefaultValue(0f)
                .HasColumnName("terfogataram_m3h");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Szivattyuks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Szivattyuk$AlvallalkozokSzivattyuk");
        });

        modelBuilder.Entity<Szolgaltatasok>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Szolgaltatasok$PrimaryKey");

            entity.ToTable("Szolgaltatasok");

            entity.HasIndex(e => e.AlvallalkozoId, "Szolgaltatasok$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Egyseg)
                .HasMaxLength(255)
                .HasColumnName("egyseg");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Szolgaltatasoks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Szolgaltatasok$AlvallalkozokSzolgaltatasok");
        });

        modelBuilder.Entity<TagulasiTartly>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Tagulasi_tartly$PrimaryKey");

            entity.ToTable("Tagulasi_tartly");

            entity.HasIndex(e => e.AlvallalkozoId, "Tagulasi_tartly$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.MeretL)
                .HasDefaultValue(0)
                .HasColumnName("meret_l");
            entity.Property(e => e.NyomasBar)
                .HasDefaultValue(0)
                .HasColumnName("nyomas_bar");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.TagulasiTartlies)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Tagulasi_tartly$AlvallalkozokTagulasi_tartly");
        });

        modelBuilder.Entity<TarolokPufferek>(entity =>
        {
            entity.HasKey(e => e.Azonosito).HasName("Tarolok_pufferek$PrimaryKey");

            entity.ToTable("Tarolok_pufferek");

            entity.HasIndex(e => e.AlvallalkozoId, "Tarolok_pufferek$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.NyomasBar)
                .HasMaxLength(255)
                .HasColumnName("nyomas_bar");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");
            entity.Property(e => e.UrtartalomL)
                .HasDefaultValue(0f)
                .HasColumnName("urtartalom_l");
        });

        modelBuilder.Entity<Tmpclp440161>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("~TMPCLP440161");

            entity.Property(e => e.F1).HasMaxLength(255);
        });

        modelBuilder.Entity<Vizlagyitok>(entity =>
        {
            entity.HasKey(e => e.Azonosító).HasName("Vizlagyitok$PrimaryKey");

            entity.ToTable("Vizlagyitok");

            entity.HasIndex(e => e.AlvallalkozoId, "Vizlagyitok$alvallalkozo_ID");

            entity.Property(e => e.AlvallalkozoId)
                .HasDefaultValue(0)
                .HasColumnName("alvallalkozo_ID");
            entity.Property(e => e.AnyagHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("anyag_HUF");
            entity.Property(e => e.Datum)
                .HasPrecision(0)
                .HasColumnName("datum");
            entity.Property(e => e.DijHuf)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("dij_HUF");
            entity.Property(e => e.Gyarto)
                .HasMaxLength(255)
                .HasColumnName("gyarto");
            entity.Property(e => e.KapacitasM3H)
                .HasDefaultValue(0f)
                .HasColumnName("kapacitas_m3/h");
            entity.Property(e => e.Megnevezes)
                .HasMaxLength(255)
                .HasColumnName("megnevezes");
            entity.Property(e => e.ProjektSzam)
                .HasMaxLength(255)
                .HasColumnName("projekt_szam");
            entity.Property(e => e.SsmaTimeStamp)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("SSMA_TimeStamp");
            entity.Property(e => e.Tipus)
                .HasMaxLength(255)
                .HasColumnName("tipus");

            entity.HasOne(d => d.Alvallalkozo).WithMany(p => p.Vizlagyitoks)
                .HasForeignKey(d => d.AlvallalkozoId)
                .HasConstraintName("Vizlagyitok$AlvallalkozokVizlagyitok");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
