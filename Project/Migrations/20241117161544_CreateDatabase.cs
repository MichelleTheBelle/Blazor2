using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cd_recipient_organization",
                columns: table => new
                {
                    recipient_organization_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_organization_shortname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_organization_fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_organization_legaladdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_organization_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_organization_directorfullname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_recipient_organization_organization_id", x => x.recipient_organization_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_sender",
                columns: table => new
                {
                    sender_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_sender_lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_sender_firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_sender_middlename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_sender_position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_sender_hiredate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_sender_sender_id", x => x.sender_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_document",
                columns: table => new
                {
                    document_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_document_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_document_registrationdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    c_document_summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_document_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    c_document_recipient_organization_id = table.Column<int>(type: "int", nullable: false),
                    c_document_sender_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cd_document_document_id", x => x.document_id);
                    table.ForeignKey(
                        name: "fk_f_recipient_organization_id",
                        column: x => x.c_document_recipient_organization_id,
                        principalTable: "cd_recipient_organization",
                        principalColumn: "recipient_organization_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_f_sender_id",
                        column: x => x.c_document_sender_id,
                        principalTable: "cd_sender",
                        principalColumn: "sender_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cd_document_c_document_recipient_organization_id",
                table: "cd_document",
                column: "c_document_recipient_organization_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_document_c_document_sender_id",
                table: "cd_document",
                column: "c_document_sender_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cd_document");

            migrationBuilder.DropTable(
                name: "cd_recipient_organization");

            migrationBuilder.DropTable(
                name: "cd_sender");
        }
    }
}
