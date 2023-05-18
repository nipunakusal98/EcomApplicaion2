using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomApplicaion.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AntivirusSoftwares",
                columns: table => new
                {
                    AntivirusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AntivirusDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntivirusSoftwares", x => x.AntivirusID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Memories",
                columns: table => new
                {
                    MemoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoryPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memories", x => x.MemoryID);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    ProcessorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessorDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessorPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.ProcessorID);
                });

            migrationBuilder.CreateTable(
                name: "VGAs",
                columns: table => new
                {
                    VGAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VGADescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VGAPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VGAs", x => x.VGAID);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    SeriesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriesPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.SeriesID);
                    table.ForeignKey(
                        name: "FK_Series_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelPictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultRAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultRAMPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefaultVGA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultVGAPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefaultProcessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultProcessorPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefaultOS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultAntivirus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultAntivirusPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DefaultTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SeriesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelID);
                    table.ForeignKey(
                        name: "FK_Models_Series_SeriesID",
                        column: x => x.SeriesID,
                        principalTable: "Series",
                        principalColumn: "SeriesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerConfigurations",
                columns: table => new
                {
                    CustomerConfigID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ModelID = table.Column<int>(type: "int", nullable: false),
                    ProcessorID = table.Column<int>(type: "int", nullable: false),
                    MemoryID = table.Column<int>(type: "int", nullable: false),
                    VGAID = table.Column<int>(type: "int", nullable: false),
                    AntivirusID = table.Column<int>(type: "int", nullable: false),
                    ConfigurationPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerConfigurations", x => x.CustomerConfigID);
                    table.ForeignKey(
                        name: "FK_CustomerConfigurations_AntivirusSoftwares_AntivirusID",
                        column: x => x.AntivirusID,
                        principalTable: "AntivirusSoftwares",
                        principalColumn: "AntivirusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerConfigurations_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerConfigurations_Memories_MemoryID",
                        column: x => x.MemoryID,
                        principalTable: "Memories",
                        principalColumn: "MemoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerConfigurations_Models_ModelID",
                        column: x => x.ModelID,
                        principalTable: "Models",
                        principalColumn: "ModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerConfigurations_Processors_ProcessorID",
                        column: x => x.ProcessorID,
                        principalTable: "Processors",
                        principalColumn: "ProcessorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerConfigurations_VGAs_VGAID",
                        column: x => x.VGAID,
                        principalTable: "VGAs",
                        principalColumn: "VGAID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingMethod = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerConfigID = table.Column<int>(type: "int", nullable: false),
                    CustomerConfigurationCustomerConfigID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_CustomerConfigurations_CustomerConfigurationCustomerConfigID",
                        column: x => x.CustomerConfigurationCustomerConfigID,
                        principalTable: "CustomerConfigurations",
                        principalColumn: "CustomerConfigID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerConfigID",
                        column: x => x.CustomerConfigID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfigurations_AntivirusID",
                table: "CustomerConfigurations",
                column: "AntivirusID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfigurations_CustomerID",
                table: "CustomerConfigurations",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfigurations_MemoryID",
                table: "CustomerConfigurations",
                column: "MemoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfigurations_ModelID",
                table: "CustomerConfigurations",
                column: "ModelID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfigurations_ProcessorID",
                table: "CustomerConfigurations",
                column: "ProcessorID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerConfigurations_VGAID",
                table: "CustomerConfigurations",
                column: "VGAID");

            migrationBuilder.CreateIndex(
                name: "IX_Models_SeriesID",
                table: "Models",
                column: "SeriesID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerConfigID",
                table: "Orders",
                column: "CustomerConfigID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerConfigurationCustomerConfigID",
                table: "Orders",
                column: "CustomerConfigurationCustomerConfigID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderID",
                table: "Payments",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Series_CategoryID",
                table: "Series",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "CustomerConfigurations");

            migrationBuilder.DropTable(
                name: "AntivirusSoftwares");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Memories");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "VGAs");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
