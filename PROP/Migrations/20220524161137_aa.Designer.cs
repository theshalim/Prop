// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROP.Data;

namespace PROP.Migrations
{
    [DbContext(typeof(PropContext))]
    [Migration("20220524161137_aa")]
    partial class aa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROP.Areas.HR.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpEmail");

                    b.Property<string>("EmpName");

                    b.Property<string>("EmpPhone");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PROP.Areas.Technical.Models.TechnicalTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact");

                    b.Property<string>("Department");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TechnicalTeam");
                });

            modelBuilder.Entity("PROP.Models.NewStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact");

                    b.Property<string>("Name");

                    b.Property<string>("Subject");

                    b.Property<string>("fName");

                    b.Property<string>("mName");

                    b.HasKey("Id");

                    b.ToTable("NewStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
