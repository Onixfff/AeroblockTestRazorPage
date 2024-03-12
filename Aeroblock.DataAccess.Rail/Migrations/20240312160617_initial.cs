using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeroblock.DataAccess.Rail.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costumers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    adress = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    tel = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin"),
                    e_mail = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin"),
                    site = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin"),
                    face = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    contact_face = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costumers", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "countrys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countrys", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "delivery_terms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(245)", maxLength: 245, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery_terms", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "manufacturers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    adress = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    tel = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin"),
                    e_mail = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin"),
                    site = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin"),
                    face = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    contact_face = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manufacturers", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "name_materials",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin"),
                    group = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_name_materials", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "ndss",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ndss", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "order_rzds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateOnly>(type: "DATE", nullable: false),
                    costumer = table.Column<string>(type: "varchar(125)", maxLength: 125, nullable: false, collation: "latin1_bin"),
                    material = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false, collation: "latin1_bin"),
                    weight_1 = table.Column<float>(type: "FLOAT", nullable: true),
                    col = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    sum_weight = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    fact = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    change_order = table.Column<bool>(type: "tinyint(1)", maxLength: 1, nullable: false),
                    old = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false, collation: "latin1_bin"),
                    comments = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false, collation: "latin1_bin"),
                    date_order = table.Column<DateOnly>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_rzds", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "payment_terms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    prepayment = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    payment_final = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    delay = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    name = table.Column<string>(type: "varchar(145)", maxLength: 145, nullable: true, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_terms", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "silo_balances",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    manufactur = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "latin1_bin"),
                    silo_num = table.Column<int>(type: "int", maxLength: 11, nullable: true),
                    silo_material_name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "latin1_bin"),
                    silo_name_sendler = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true, collation: "latin1_bin"),
                    weight = table.Column<float>(type: "float(10, 0)", nullable: true),
                    max_weight = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_silo_balances", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "sklads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", maxLength: 11, nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "latin1_bin"),
                    name_material = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false, collation: "latin1_bin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sklads", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateTable(
                name: "vagon_vihod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_order = table.Column<int>(type: "int", nullable: true),
                    number = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    sender = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    costumer = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    date = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    material = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    weight = table.Column<int>(type: "int", nullable: false),
                    data_prihod = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    prihod = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    partia = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    data_start = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    data_finish = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    status_start = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    status_stop = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    number_silos = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, collation: "utf8_general_ci")
                        .Annotation("MySql:CharSet", "utf8"),
                    time = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true, collation: "latin1_swedish_ci"),
                    vag_finish = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vagon_vihod", x => x.id);
                })
                .Annotation("Relational:Collation", "latin1_bin");

            migrationBuilder.CreateIndex(
                name: "IX_costumers_id",
                table: "costumers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_countrys_id",
                table: "countrys",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_delivery_terms_id",
                table: "delivery_terms",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_manufacturers_id",
                table: "manufacturers",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_name_materials_id",
                table: "name_materials",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ndss_id",
                table: "ndss",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_order_rzds_id",
                table: "order_rzds",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_payment_terms_id",
                table: "payment_terms",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_silo_balances_id",
                table: "silo_balances",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sklads_id",
                table: "sklads",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_UNIQUE",
                table: "vagon_vihod",
                column: "id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "costumers");

            migrationBuilder.DropTable(
                name: "countrys");

            migrationBuilder.DropTable(
                name: "delivery_terms");

            migrationBuilder.DropTable(
                name: "manufacturers");

            migrationBuilder.DropTable(
                name: "name_materials");

            migrationBuilder.DropTable(
                name: "ndss");

            migrationBuilder.DropTable(
                name: "order_rzds");

            migrationBuilder.DropTable(
                name: "payment_terms");

            migrationBuilder.DropTable(
                name: "silo_balances");

            migrationBuilder.DropTable(
                name: "sklads");

            migrationBuilder.DropTable(
                name: "vagon_vihod");
        }
    }
}
