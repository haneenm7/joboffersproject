using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutu> Aboutus { get; set; }
        public virtual DbSet<Aboutuspety> Aboutuspeties { get; set; }
        public virtual DbSet<Adoptionfarah> Adoptionfarahs { get; set; }
        public virtual DbSet<Categorey> Categoreys { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Categoryh7> Categoryh7s { get; set; }
        public virtual DbSet<Cliniccenterfarah> Cliniccenterfarahs { get; set; }
        public virtual DbSet<Contactu> Contactus { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Customerh7> Customerh7s { get; set; }
        public virtual DbSet<EmpDeptView> EmpDeptViews { get; set; }
        public virtual DbSet<Header> Headers { get; set; }
        public virtual DbSet<Home> Homes { get; set; }
        public virtual DbSet<Homepety> Homepeties { get; set; }
        public virtual DbSet<Leavemessage> Leavemessages { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Loginl> Loginls { get; set; }
        public virtual DbSet<Petfarah> Petfarahs { get; set; }
        public virtual DbSet<Pettypefarah> Pettypefarahs { get; set; }
        public virtual DbSet<ProductCustomerh7> ProductCustomerh7s { get; set; }
        public virtual DbSet<Producth7> Producth7s { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Reservationfarah> Reservationfarahs { get; set; }
        public virtual DbSet<Reservationtypefarah> Reservationtypefarahs { get; set; }
        public virtual DbSet<Restcategory> Restcategories { get; set; }
        public virtual DbSet<Restcustomer> Restcustomers { get; set; }
        public virtual DbSet<Restproduct> Restproducts { get; set; }
        public virtual DbSet<Restproductcustomer> Restproductcustomers { get; set; }
        public virtual DbSet<Restrole> Restroles { get; set; }
        public virtual DbSet<Restuserlogin> Restuserlogins { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Rolefarah> Rolefarahs { get; set; }
        public virtual DbSet<Rolel> Rolels { get; set; }
        public virtual DbSet<Rolesh7> Rolesh7s { get; set; }
        public virtual DbSet<Ror> Rors { get; set; }
        public virtual DbSet<StdCourse> StdCourses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Testmonial> Testmonials { get; set; }
        public virtual DbSet<Testmonialpety> Testmonialpeties { get; set; }
        public virtual DbSet<TrainUser06Category> TrainUser06Categories { get; set; }
        public virtual DbSet<TrainUser06Customer> TrainUser06Customers { get; set; }
        public virtual DbSet<TrainUser06Product> TrainUser06Products { get; set; }
        public virtual DbSet<TrainUser06ProductCustomer> TrainUser06ProductCustomers { get; set; }
        public virtual DbSet<TrainUser06Role> TrainUser06Roles { get; set; }
        public virtual DbSet<TrainUser06UserLogin> TrainUser06UserLogins { get; set; }
        public virtual DbSet<UserLoginh7> UserLoginh7s { get; set; }
        public virtual DbSet<Useraccountfarah> Useraccountfarahs { get; set; }
        public virtual DbSet<Visa> Visas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("User ID=JOR15_USER99;PASSWORD=1234;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("JOR15_USER99")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Aboutu>(entity =>
            {
                entity.HasKey(e => e.Titleimage)
                    .HasName("SYS_C00268225");

                entity.ToTable("ABOUTUS");

                entity.Property(e => e.Titleimage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLEIMAGE");

                entity.Property(e => e.Choseimage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CHOSEIMAGE");

                entity.Property(e => e.Descriptionchose1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONCHOSE1");

                entity.Property(e => e.Descriptionchose2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONCHOSE2");

                entity.Property(e => e.Descriptionchose3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONCHOSE3");

                entity.Property(e => e.Descriptionchose4)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONCHOSE4");

                entity.Property(e => e.Descriptionchose5)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONCHOSE5");

                entity.Property(e => e.Descriptiontitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTITLE1");

                entity.Property(e => e.Descriptiontitle2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTITLE2");

                entity.Property(e => e.Descriptiontitle3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTITLE3");

                entity.Property(e => e.Descriptiontitle4)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTITLE4");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Title1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE1");

                entity.Property(e => e.Title2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE2");

                entity.Property(e => e.Title3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE3");

                entity.Property(e => e.Title4)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLE4");

                entity.Property(e => e.Titlechose1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLECHOSE1");

                entity.Property(e => e.Titlechose2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLECHOSE2");

                entity.Property(e => e.Titlechose3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLECHOSE3");

                entity.Property(e => e.Titlechose4)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLECHOSE4");

                entity.Property(e => e.Titlechose5)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLECHOSE5");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aboutus)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268227");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Aboutus)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268226");
            });

            modelBuilder.Entity<Aboutuspety>(entity =>
            {
                entity.HasKey(e => e.Aboutid)
                    .HasName("SYS_C00310777");

                entity.ToTable("ABOUTUSPETY");

                entity.Property(e => e.Aboutid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ABOUTID");

                entity.Property(e => e.Adoptid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ADOPTID");

                entity.Property(e => e.Descriptiontext1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTEXT1");

                entity.Property(e => e.Descriptiontext2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONTEXT2");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Text1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TEXT1");

                entity.Property(e => e.Text2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TEXT2");

                entity.Property(e => e.Titleimage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TITLEIMAGE");

                entity.Property(e => e.Titletext)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TITLETEXT");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Adopt)
                    .WithMany(p => p.Aboutuspeties)
                    .HasForeignKey(d => d.Adoptid)
                    .HasConstraintName("SYS_C00310778");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aboutuspeties)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00313561");
            });

            modelBuilder.Entity<Adoptionfarah>(entity =>
            {
                entity.HasKey(e => e.Adoptionid)
                    .HasName("SYS_C00307703");

                entity.ToTable("ADOPTIONFARAH");

                entity.Property(e => e.Adoptionid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ADOPTIONID");

                entity.Property(e => e.Adoptionage)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ADOPTIONAGE");

                entity.Property(e => e.Adoptionname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADOPTIONNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Pettypeid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PETTYPEID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Pettype)
                    .WithMany(p => p.Adoptionfarahs)
                    .HasForeignKey(d => d.Pettypeid)
                    .HasConstraintName("SYS_C00312867");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Adoptionfarahs)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00307704");
            });

            modelBuilder.Entity<Categorey>(entity =>
            {
                entity.ToTable("CATEGOREY");

                entity.Property(e => e.Categoreyid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGOREYID");

                entity.Property(e => e.Categoreyname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CATEGOREYNAME");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYNAME");
            });

            modelBuilder.Entity<Categoryh7>(entity =>
            {
                entity.ToTable("CATEGORYH7");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");
            });

            modelBuilder.Entity<Cliniccenterfarah>(entity =>
            {
                entity.HasKey(e => e.Clinicid)
                    .HasName("SYS_C00307682");

                entity.ToTable("CLINICCENTERFARAH");

                entity.Property(e => e.Clinicid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CLINICID");

                entity.Property(e => e.Cliniclocation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLINICLOCATION");

                entity.Property(e => e.Clinicname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLINICNAME");

                entity.Property(e => e.Clinicsatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLINICSATUS");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasKey(e => e.Mailtitle)
                    .HasName("SYS_C00268235");

                entity.ToTable("CONTACTUS");

                entity.Property(e => e.Mailtitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MAILTITLE");

                entity.Property(e => e.Call)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CALL");

                entity.Property(e => e.Descriptioncall)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONCALL");

                entity.Property(e => e.Descriptionmail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONMAIL");

                entity.Property(e => e.Descriptionvisit)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONVISIT");

                entity.Property(e => e.Descriptionwork)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONWORK");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Visittitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VISITTITLE");

                entity.Property(e => e.Work)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("WORK");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Contactus)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268237");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Contactus)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268236");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("COURSE");

                entity.Property(e => e.Courseid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COURSEID");

                entity.Property(e => e.Categoreyid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGOREYID");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("COURSENAME");

                entity.Property(e => e.Imagename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMAGENAME");

                entity.HasOne(d => d.Categorey)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.Categoreyid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CATCOURSE");
            });

            modelBuilder.Entity<Customerh7>(entity =>
            {
                entity.ToTable("CUSTOMERH7");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LNAME");
            });

            modelBuilder.Entity<EmpDeptView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EMP_DEPT_VIEW");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DEPT_NAME");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.HasKey(e => e.Rights)
                    .HasName("SYS_C00268260");

                entity.ToTable("HEADER");

                entity.Property(e => e.Rights)
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("RIGHTS");

                entity.Property(e => e.Contact1)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT1");

                entity.Property(e => e.Contact2)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT2");

                entity.Property(e => e.Contact3)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT3");

                entity.Property(e => e.Contact4)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT4");

                entity.Property(e => e.News)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NEWS");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Title1)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE1");

                entity.Property(e => e.Title2)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE2");

                entity.Property(e => e.Title3)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE3");

                entity.Property(e => e.Title4)
                    .IsRequired()
                    .HasMaxLength(155)
                    .IsUnicode(false)
                    .HasColumnName("TITLE4");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Headers)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268262");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Headers)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268261");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.HasKey(e => e.Sliderimage)
                    .HasName("SYS_C00268197");

                entity.ToTable("HOME");

                entity.Property(e => e.Sliderimage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SLIDERIMAGE");

                entity.Property(e => e.Descriptionservice1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSERVICE1");

                entity.Property(e => e.Descriptionservice2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSERVICE2");

                entity.Property(e => e.Descriptionservice3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSERVICE3");

                entity.Property(e => e.Descriptionslider1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSLIDER1");

                entity.Property(e => e.Descriptionslider2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSLIDER2");

                entity.Property(e => e.Descriptionslider3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTIONSLIDER3");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Titleservice1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLESERVICE1");

                entity.Property(e => e.Titleservice2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLESERVICE2");

                entity.Property(e => e.Titleservice3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLESERVICE3");

                entity.Property(e => e.Titleslider1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLESLIDER1");

                entity.Property(e => e.Titleslider2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLESLIDER2");

                entity.Property(e => e.Titleslider3)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TITLESLIDER3");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Video)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("VIDEO");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268199");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268198");
            });

            modelBuilder.Entity<Homepety>(entity =>
            {
                entity.HasKey(e => e.Homeid)
                    .HasName("SYS_C00310780");

                entity.ToTable("HOMEPETY");

                entity.Property(e => e.Homeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HOMEID");

                entity.Property(e => e.Service1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE1");

                entity.Property(e => e.Service2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE2");

                entity.Property(e => e.Service3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVICE3");

                entity.Property(e => e.Servicetitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SERVICETITLE");

                entity.Property(e => e.Titleimage)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TITLEIMAGE");

                entity.Property(e => e.Titletext)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TITLETEXT");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Homepeties)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00313562");
            });

            modelBuilder.Entity<Leavemessage>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("SYS_C00268242");

                entity.ToTable("LEAVEMESSAGE");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Leavemessages)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268244");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Leavemessages)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268243");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("SYS_C00268156");

                entity.ToTable("LOGIN");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268157");
            });

            modelBuilder.Entity<Loginl>(entity =>
            {
                entity.HasKey(e => e.Loginid)
                    .HasName("SYS_C00278944");

                entity.ToTable("LOGINL");

                entity.Property(e => e.Loginid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGINID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Studentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Loginls)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ROLEID");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Loginls)
                    .HasForeignKey(d => d.Studentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STDID");
            });

            modelBuilder.Entity<Petfarah>(entity =>
            {
                entity.HasKey(e => e.Petid)
                    .HasName("SYS_C00307687");

                entity.ToTable("PETFARAH");

                entity.Property(e => e.Petid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PETID");

                entity.Property(e => e.Clinicid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLINICID");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Petage)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PETAGE");

                entity.Property(e => e.Petname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PETNAME");

                entity.Property(e => e.Pettypeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PETTYPEID");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.Petfarahs)
                    .HasForeignKey(d => d.Clinicid)
                    .HasConstraintName("SYS_C00307690");

                entity.HasOne(d => d.Pettype)
                    .WithMany(p => p.Petfarahs)
                    .HasForeignKey(d => d.Pettypeid)
                    .HasConstraintName("SYS_C00307688");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Petfarahs)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00307689");
            });

            modelBuilder.Entity<Pettypefarah>(entity =>
            {
                entity.HasKey(e => e.Pettypeid)
                    .HasName("SYS_C00307685");

                entity.ToTable("PETTYPEFARAH");

                entity.Property(e => e.Pettypeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PETTYPEID");

                entity.Property(e => e.Pettypename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PETTYPENAME");
            });

            modelBuilder.Entity<ProductCustomerh7>(entity =>
            {
                entity.ToTable("PRODUCT_CUSTOMERH7");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUANTITY");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductCustomerh7s)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("SYS_C00369241");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCustomerh7s)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("SYS_C00369240");
            });

            modelBuilder.Entity<Producth7>(entity =>
            {
                entity.ToTable("PRODUCTH7");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Sale)
                    .HasColumnType("NUMBER(8,2)")
                    .HasColumnName("SALE");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Producth7s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("SYS_C00369229");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.Hallnumber)
                    .HasName("SYS_C00268166");

                entity.ToTable("RESERVATION");

                entity.Property(e => e.Hallnumber)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HALLNUMBER");

                entity.Property(e => e.Category)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Day)
                    .HasColumnType("DATE")
                    .HasColumnName("DAY");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("PLACE");

                entity.Property(e => e.Price)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Timefrom)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMEFROM");

                entity.Property(e => e.Timeto)
                    .HasColumnType("DATE")
                    .HasColumnName("TIMETO");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("SYS_C00271075");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268167");
            });

            modelBuilder.Entity<Reservationfarah>(entity =>
            {
                entity.HasKey(e => e.Reservationid)
                    .HasName("SYS_C00307696");

                entity.ToTable("RESERVATIONFARAH");

                entity.Property(e => e.Reservationid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESERVATIONID");

                entity.Property(e => e.Clinicid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CLINICID");

                entity.Property(e => e.Petid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PETID");

                entity.Property(e => e.Reservationcase)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("RESERVATIONCASE");

                entity.Property(e => e.Reservationdate)
                    .HasColumnType("DATE")
                    .HasColumnName("RESERVATIONDATE");

                entity.Property(e => e.Reservationtypeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("RESERVATIONTYPEID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.Reservationfarahs)
                    .HasForeignKey(d => d.Clinicid)
                    .HasConstraintName("SYS_C00307697");

                entity.HasOne(d => d.Pet)
                    .WithMany(p => p.Reservationfarahs)
                    .HasForeignKey(d => d.Petid)
                    .HasConstraintName("PETID");

                entity.HasOne(d => d.Reservationtype)
                    .WithMany(p => p.Reservationfarahs)
                    .HasForeignKey(d => d.Reservationtypeid)
                    .HasConstraintName("SYS_C00307699");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservationfarahs)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00307698");
            });

            modelBuilder.Entity<Reservationtypefarah>(entity =>
            {
                entity.HasKey(e => e.Reservationtypeid)
                    .HasName("SYS_C00307693");

                entity.ToTable("RESERVATIONTYPEFARAH");

                entity.Property(e => e.Reservationtypeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESERVATIONTYPEID");

                entity.Property(e => e.Reservationtypename)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("RESERVATIONTYPENAME");
            });

            modelBuilder.Entity<Restcategory>(entity =>
            {
                entity.HasKey(e => e.Categoryid)
                    .HasName("SYS_C00308316");

                entity.ToTable("RESTCATEGORY");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");
            });

            modelBuilder.Entity<Restcustomer>(entity =>
            {
                entity.HasKey(e => e.Customerid)
                    .HasName("SYS_C00308314");

                entity.ToTable("RESTCUSTOMER");

                entity.Property(e => e.Customerid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");
            });

            modelBuilder.Entity<Restproduct>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("SYS_C00308318");

                entity.ToTable("RESTPRODUCT");

                entity.Property(e => e.Productid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PRODUCTID");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Productname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCTNAME");

                entity.Property(e => e.Productprice)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRODUCTPRICE");

                entity.Property(e => e.Productsale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCTSALE");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Restproducts)
                    .HasForeignKey(d => d.Categoryid)
                    .HasConstraintName("SYS_C00308319");
            });

            modelBuilder.Entity<Restproductcustomer>(entity =>
            {
                entity.HasKey(e => e.Productcustomerid)
                    .HasName("SYS_C00308325");

                entity.ToTable("RESTPRODUCTCUSTOMER");

                entity.Property(e => e.Productcustomerid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PRODUCTCUSTOMERID");

                entity.Property(e => e.Customerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEFROM");

                entity.Property(e => e.Dateto)
                    .HasColumnType("DATE")
                    .HasColumnName("DATETO");

                entity.Property(e => e.Productid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCTID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Restproductcustomers)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("SYS_C00308326");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Restproductcustomers)
                    .HasForeignKey(d => d.Productid)
                    .HasConstraintName("SYS_C00308327");
            });

            modelBuilder.Entity<Restrole>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("SYS_C00308312");

                entity.ToTable("RESTROLE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Restuserlogin>(entity =>
            {
                entity.HasKey(e => e.Userloginid)
                    .HasName("SYS_C00308321");

                entity.ToTable("RESTUSERLOGIN");

                entity.Property(e => e.Userloginid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERLOGINID");

                entity.Property(e => e.Customerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMERID");

                entity.Property(e => e.Passworde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORDE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Restuserlogins)
                    .HasForeignKey(d => d.Customerid)
                    .HasConstraintName("SYS_C00308323");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Restuserlogins)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00308322");
            });

            modelBuilder.Entity<Ride>(entity =>
            {
                entity.ToTable("RIDE");

                entity.Property(e => e.Rideid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RIDEID");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PLACE");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Rolefarah>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("SYS_C00307671");

                entity.ToTable("ROLEFARAH");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Rolel>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("SYS_C00278942");

                entity.ToTable("ROLEL");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Rolesh7>(entity =>
            {
                entity.ToTable("ROLESH7");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Ror>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ROR");

                entity.Property(e => e.Age)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("AGE");

                entity.Property(e => e.Cpop)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CPOP");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<StdCourse>(entity =>
            {
                entity.ToTable("STD_COURSE");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Courseid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("COURSEID");

                entity.Property(e => e.Dateofregister)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEOFREGISTER");

                entity.Property(e => e.Markofstd)
                    .HasColumnType("NUMBER")
                    .HasColumnName("MARKOFSTD");

                entity.Property(e => e.Stdidid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STDIDID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StdCourses)
                    .HasForeignKey(d => d.Courseid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STDCOURSE");

                entity.HasOne(d => d.Stdid)
                    .WithMany(p => p.StdCourses)
                    .HasForeignKey(d => d.Stdidid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STD");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENT");

                entity.Property(e => e.Studentid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STUDENTID");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEOFBIRTH");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");
            });

            modelBuilder.Entity<Testmonial>(entity =>
            {
                entity.ToTable("TESTMONIAL");

                entity.Property(e => e.Testmonialid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTMONIALID");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Testmonials)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268250");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Testmonials)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268249");
            });

            modelBuilder.Entity<Testmonialpety>(entity =>
            {
                entity.HasKey(e => e.Testid)
                    .HasName("SYS_C00310782");

                entity.ToTable("TESTMONIALPETY");

                entity.Property(e => e.Testid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTID");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Testcontent)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TESTCONTENT");

                entity.Property(e => e.Teststatus)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TESTSTATUS");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Testmonialpeties)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00310784");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testmonialpeties)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00310783");
            });

            modelBuilder.Entity<TrainUser06Category>(entity =>
            {
                entity.ToTable("TRAIN_USER06.CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");
            });

            modelBuilder.Entity<TrainUser06Customer>(entity =>
            {
                entity.ToTable("TRAIN_USER06.CUSTOMER");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LNAME");
            });

            modelBuilder.Entity<TrainUser06Product>(entity =>
            {
                entity.ToTable("TRAIN_USER06.PRODUCT");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CATEGORY_ID");

                entity.Property(e => e.Namee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAMEE");

                entity.Property(e => e.Price)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Sale)
                    .HasColumnType("NUMBER")
                    .HasColumnName("SALE");

                entity.Property(e => e.TrainUser06CategoryId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRAIN_USER06.CATEGORY_ID");

                entity.HasOne(d => d.TrainUser06Category)
                    .WithMany(p => p.TrainUser06Products)
                    .HasForeignKey(d => d.TrainUser06CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CATEGORY_ID");
            });

            modelBuilder.Entity<TrainUser06ProductCustomer>(entity =>
            {
                entity.ToTable("TRAIN_USER06.PRODUCT_CUSTOMER");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_FROM");

                entity.Property(e => e.DateTo)
                    .HasColumnType("DATE")
                    .HasColumnName("DATE_TO");

                entity.Property(e => e.ProductId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.TrainUser06CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRAIN_USER06.CUSTOMER_ID");

                entity.Property(e => e.TrainUser06ProductId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRAIN_USER06.PRODUCT_ID");

                entity.HasOne(d => d.TrainUser06Product)
                    .WithMany(p => p.TrainUser06ProductCustomers)
                    .HasForeignKey(d => d.TrainUser06ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_PRODUCT_ID");
            });

            modelBuilder.Entity<TrainUser06Role>(entity =>
            {
                entity.ToTable("TRAIN_USER06.ROLES");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<TrainUser06UserLogin>(entity =>
            {
                entity.ToTable("TRAIN_USER06.USER_LOGIN");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.TrainUser06CustomerId)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TRAIN_USER06.CUSTOMER_ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<UserLoginh7>(entity =>
            {
                entity.ToTable("USER_LOGINH7");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UserLoginh7s)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("SYS_C00369237");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserLoginh7s)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("SYS_C00369236");
            });

            modelBuilder.Entity<Useraccountfarah>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("SYS_C00307676");

                entity.ToTable("USERACCOUNTFARAH");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Lastnamename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAMENAME");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phonenum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUM");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Useraccountfarahs)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00307677");
            });

            modelBuilder.Entity<Visa>(entity =>
            {
                entity.HasKey(e => e.Cardnumber)
                    .HasName("SYS_C00268268");

                entity.ToTable("VISA");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Exp)
                    .HasColumnType("DATE")
                    .HasColumnName("EXP");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Pocket)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("POCKET");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Thrnum)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("THRNUM");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Visas)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00268270");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Visas)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("SYS_C00268269");
            });

            modelBuilder.HasSequence("DEPT_ID");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
