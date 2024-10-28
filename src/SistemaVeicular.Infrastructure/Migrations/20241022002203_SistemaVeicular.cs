using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SistemaVeicular.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SistemaVeicular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencoes_Mecanicos_TecnicoMecanicoId",
                table: "Manutencoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencoes_Veiculos_VeiculoId",
                table: "Manutencoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Clientes_ClienteId",
                table: "Veiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculos",
                table: "Veiculos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mecanicos",
                table: "Mecanicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manutencoes",
                table: "Manutencoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Veiculos",
                newName: "Veiculo");

            migrationBuilder.RenameTable(
                name: "Mecanicos",
                newName: "Mecanico");

            migrationBuilder.RenameTable(
                name: "Manutencoes",
                newName: "Manutencoe");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculos_ClienteId",
                table: "Veiculo",
                newName: "IX_Veiculo_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Manutencoes_VeiculoId",
                table: "Manutencoe",
                newName: "IX_Manutencoe_VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Manutencoes_TecnicoMecanicoId",
                table: "Manutencoe",
                newName: "IX_Manutencoe_TecnicoMecanicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_ClienteId",
                table: "Endereco",
                newName: "IX_Endereco_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Observacoes",
                table: "Cliente",
                newName: "Observacao");

            migrationBuilder.AlterColumn<long>(
                name: "ClienteId",
                table: "Endereco",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "EmpresaColetoraId",
                table: "Endereco",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TecnicoMecanicoId",
                table: "Endereco",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Cliente",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mecanico",
                table: "Mecanico",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manutencoe",
                table: "Manutencoe",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EmpresaColetora",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CNPJ = table.Column<string>(type: "text", nullable: false),
                    Servicos = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaColetora", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notificacao",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Mensagem = table.Column<string>(type: "text", nullable: false),
                    DataNotificacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Enviada = table.Column<bool>(type: "boolean", nullable: false),
                    ServicoManutencaoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notificacao_Manutencoe_ServicoManutencaoId",
                        column: x => x.ServicoManutencaoId,
                        principalTable: "Manutencoe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_EmpresaColetoraId",
                table: "Endereco",
                column: "EmpresaColetoraId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_TecnicoMecanicoId",
                table: "Endereco",
                column: "TecnicoMecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificacao_ServicoManutencaoId",
                table: "Notificacao",
                column: "ServicoManutencaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_EmpresaColetora_EmpresaColetoraId",
                table: "Endereco",
                column: "EmpresaColetoraId",
                principalTable: "EmpresaColetora",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Mecanico_TecnicoMecanicoId",
                table: "Endereco",
                column: "TecnicoMecanicoId",
                principalTable: "Mecanico",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencoe_Mecanico_TecnicoMecanicoId",
                table: "Manutencoe",
                column: "TecnicoMecanicoId",
                principalTable: "Mecanico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencoe_Veiculo_VeiculoId",
                table: "Manutencoe",
                column: "VeiculoId",
                principalTable: "Veiculo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Cliente_ClienteId",
                table: "Veiculo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Cliente_ClienteId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_EmpresaColetora_EmpresaColetoraId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Mecanico_TecnicoMecanicoId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencoe_Mecanico_TecnicoMecanicoId",
                table: "Manutencoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Manutencoe_Veiculo_VeiculoId",
                table: "Manutencoe");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Cliente_ClienteId",
                table: "Veiculo");

            migrationBuilder.DropTable(
                name: "EmpresaColetora");

            migrationBuilder.DropTable(
                name: "Notificacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Veiculo",
                table: "Veiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mecanico",
                table: "Mecanico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manutencoe",
                table: "Manutencoe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_EmpresaColetoraId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_TecnicoMecanicoId",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EmpresaColetoraId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "TecnicoMecanicoId",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Veiculo",
                newName: "Veiculos");

            migrationBuilder.RenameTable(
                name: "Mecanico",
                newName: "Mecanicos");

            migrationBuilder.RenameTable(
                name: "Manutencoe",
                newName: "Manutencoes");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_ClienteId",
                table: "Veiculos",
                newName: "IX_Veiculos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Manutencoe_VeiculoId",
                table: "Manutencoes",
                newName: "IX_Manutencoes_VeiculoId");

            migrationBuilder.RenameIndex(
                name: "IX_Manutencoe_TecnicoMecanicoId",
                table: "Manutencoes",
                newName: "IX_Manutencoes_TecnicoMecanicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_ClienteId",
                table: "Enderecos",
                newName: "IX_Enderecos_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Observacao",
                table: "Clientes",
                newName: "Observacoes");

            migrationBuilder.AlterColumn<long>(
                name: "ClienteId",
                table: "Enderecos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Clientes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veiculos",
                table: "Veiculos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mecanicos",
                table: "Mecanicos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manutencoes",
                table: "Manutencoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Clientes_ClienteId",
                table: "Enderecos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencoes_Mecanicos_TecnicoMecanicoId",
                table: "Manutencoes",
                column: "TecnicoMecanicoId",
                principalTable: "Mecanicos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Manutencoes_Veiculos_VeiculoId",
                table: "Manutencoes",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Clientes_ClienteId",
                table: "Veiculos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
