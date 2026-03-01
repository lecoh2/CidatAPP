using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CidatAPP.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NIVEL",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMENIVEL = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIVEL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SETORES",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOMESETOR = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SETORES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    LOGIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SENHA = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    DATACADASTRO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATAATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FAILEDLOGINATTEMPTS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LOGIN = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    IPACESSO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    USERAGENT = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATAHORA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MENSAGEM = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAILEDLOGINATTEMPTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FAILEDLOGINATTEMPTS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FOTOS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FOTONOME = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FILEURL = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATACADASTRO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DATAATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOTOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FOTOS_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "GRUPONIVEL",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRUPONIVEL", x => new { x.IDUSUARIO, x.ID });
                    table.ForeignKey(
                        name: "FK_GRUPONIVEL_NIVEL_ID",
                        column: x => x.ID,
                        principalTable: "NIVEL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GRUPONIVEL_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GRUPOSETORES",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDSETOR = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRUPOSETORES", x => new { x.IDUSUARIO, x.ID });
                    table.ForeignKey(
                        name: "FK_GRUPOSETORES_SETORES_IDSETOR",
                        column: x => x.IDSETOR,
                        principalTable: "SETORES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GRUPOSETORES_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LOGINHISTORY",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IDUSUARIO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IPACESSO = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    USERAGENT = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DATAHORAACESSO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SUCESSO = table.Column<bool>(type: "bit", nullable: false),
                    MENSAGEM = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGINHISTORY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOGINHISTORY_USUARIO_IDUSUARIO",
                        column: x => x.IDUSUARIO,
                        principalTable: "USUARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAILEDLOGINATTEMPTS_IDUSUARIO",
                table: "FAILEDLOGINATTEMPTS",
                column: "IDUSUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_FOTOS_IDUSUARIO",
                table: "FOTOS",
                column: "IDUSUARIO",
                unique: true,
                filter: "[IDUSUARIO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GRUPONIVEL_ID",
                table: "GRUPONIVEL",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_GRUPOSETORES_IDSETOR",
                table: "GRUPOSETORES",
                column: "IDSETOR");

            migrationBuilder.CreateIndex(
                name: "IX_LOGINHISTORY_IDUSUARIO",
                table: "LOGINHISTORY",
                column: "IDUSUARIO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAILEDLOGINATTEMPTS");

            migrationBuilder.DropTable(
                name: "FOTOS");

            migrationBuilder.DropTable(
                name: "GRUPONIVEL");

            migrationBuilder.DropTable(
                name: "GRUPOSETORES");

            migrationBuilder.DropTable(
                name: "LOGINHISTORY");

            migrationBuilder.DropTable(
                name: "NIVEL");

            migrationBuilder.DropTable(
                name: "SETORES");

            migrationBuilder.DropTable(
                name: "USUARIO");
        }
    }
}
