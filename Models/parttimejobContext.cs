using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PartTimeJob.Models
{
    public partial class parttimejobContext : DbContext
    {
        public parttimejobContext()
        {
        }

        public parttimejobContext(DbContextOptions<parttimejobContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<Applicantinfo> Applicantinfo { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Companyinfo> Companyinfo { get; set; }
        public virtual DbSet<Intention> Intention { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Personinfo> Personinfo { get; set; }
        public virtual DbSet<Recruit> Recruit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=1478521; database=parttimejob;TreatTinyAsBoolean=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.DId);

                entity.ToTable("admin");

                entity.Property(e => e.DId)
                    .HasColumnName("dId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DPassword)
                    .HasColumnName("dPassword")
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => e.AId);

                entity.ToTable("applicant");

                entity.Property(e => e.AId)
                    .HasColumnName("aId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.APassword)
                    .HasColumnName("aPassword")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.AStatus)
                    .HasColumnName("aStatus")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Applicantinfo>(entity =>
            {
                entity.HasKey(e => e.AId);

                entity.ToTable("applicantinfo");

                entity.Property(e => e.AId)
                    .HasColumnName("aId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.AAddress)
                    .IsRequired()
                    .HasColumnName("aAddress")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.ACollege)
                    .IsRequired()
                    .HasColumnName("aCollege")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.AEmail)
                    .IsRequired()
                    .HasColumnName("aEmail")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.AExper)
                    .HasColumnName("aExper")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.AHobby)
                    .HasColumnName("aHobby")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.ALanguage)
                    .HasColumnName("aLanguage")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.AMajor)
                    .IsRequired()
                    .HasColumnName("aMajor")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.AName)
                    .IsRequired()
                    .HasColumnName("aName")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.ANumber)
                    .IsRequired()
                    .HasColumnName("aNumber")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.ARemark)
                    .HasColumnName("aRemark")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.ASex)
                    .IsRequired()
                    .HasColumnName("aSex")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.ASkill)
                    .HasColumnName("aSkill")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.ATel)
                    .IsRequired()
                    .HasColumnName("aTel")
                    .HasColumnType("varchar(11)");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("company");

                entity.Property(e => e.CId)
                    .HasColumnName("cId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CPassword)
                    .HasColumnName("cPassword")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.CStatus)
                    .HasColumnName("cStatus")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Companyinfo>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("companyinfo");

                entity.Property(e => e.CId)
                    .HasColumnName("cId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CAddress)
                    .IsRequired()
                    .HasColumnName("cAddress")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.CIndustry)
                    .HasColumnName("cIndustry")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.CName)
                    .IsRequired()
                    .HasColumnName("cName")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.CRemark)
                    .HasColumnName("cRemark")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.CSize)
                    .HasColumnName("cSize")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.CTel)
                    .IsRequired()
                    .HasColumnName("cTel")
                    .HasColumnType("varchar(11)");
            });

            modelBuilder.Entity<Intention>(entity =>
            {
                entity.HasKey(e => new { e.AId, e.RId });

                entity.ToTable("intention");

                entity.Property(e => e.AId)
                    .HasColumnName("aId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RId)
                    .HasColumnName("rId")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ICreateTime)
                    .HasColumnName("iCreateTime")
                    .HasColumnType("date");

                entity.Property(e => e.IDealTime)
                    .HasColumnName("iDealTime")
                    .HasColumnType("date");

                entity.Property(e => e.IStatus)
                    .IsRequired()
                    .HasColumnName("iStatus")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("person");

                entity.Property(e => e.PId)
                    .HasColumnName("pId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PPassword)
                    .HasColumnName("pPassword")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.PStatus)
                    .HasColumnName("pStatus")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Personinfo>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("personinfo");

                entity.Property(e => e.PId)
                    .HasColumnName("pId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CRemark)
                    .HasColumnName("cRemark")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.PAddress)
                    .IsRequired()
                    .HasColumnName("pAddress")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.PName)
                    .IsRequired()
                    .HasColumnName("pName")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.PNumber)
                    .IsRequired()
                    .HasColumnName("pNumber")
                    .HasColumnType("varchar(18)");

                entity.Property(e => e.PSex)
                    .IsRequired()
                    .HasColumnName("pSex")
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.PTel)
                    .IsRequired()
                    .HasColumnName("pTel")
                    .HasColumnType("varchar(11)");
            });

            modelBuilder.Entity<Recruit>(entity =>
            {
                entity.HasKey(e => e.RId);

                entity.ToTable("recruit");

                entity.Property(e => e.RId)
                    .HasColumnName("rId")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.CId)
                    .HasColumnName("cId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PId)
                    .HasColumnName("pId")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RAddress)
                    .IsRequired()
                    .HasColumnName("rAddress")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.RCreatTime)
                    .HasColumnName("rCreatTime")
                    .HasColumnType("date");

                entity.Property(e => e.RDescribe)
                    .IsRequired()
                    .HasColumnName("rDescribe")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.RPeople)
                    .IsRequired()
                    .HasColumnName("rPeople")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.RRequire)
                    .HasColumnName("rRequire")
                    .HasColumnType("varchar(256)");

                entity.Property(e => e.RSalary)
                    .IsRequired()
                    .HasColumnName("rSalary")
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.RTel)
                    .IsRequired()
                    .HasColumnName("rTel")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.RType)
                    .IsRequired()
                    .HasColumnName("rType")
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.REndDate).HasColumnType("datetime");

                entity.Property(e => e.RStartDate).HasColumnType("datetime");
            });
        }
    }
}
