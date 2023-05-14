using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContribuyentesApi.Infrastructure.Migrations
{
    public partial class Datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TiposContribuyentes (DESCRIPCION) VALUES ('PERSONA FISICA');");
            migrationBuilder.Sql("INSERT INTO TiposContribuyentes (DESCRIPCION) VALUES ('PERSONA JURIDICA');");

            //datos de la prueba
            migrationBuilder.Sql("INSERT INTO Contribuyentes (RncCedula, Nombre, TipoContribuyenteId, EstaActivo) VALUES ('98754321012', 'JUAN PEREZ', (SELECT Id FROM TiposContribuyentes WHERE DESCRIPCION = 'PERSONA FISICA'), 1 );");
            migrationBuilder.Sql("INSERT INTO Contribuyentes (RncCedula, Nombre, TipoContribuyenteId, EstaActivo) VALUES ('123456789', 'FARMACIA TU SALUD', (SELECT Id FROM TiposContribuyentes WHERE DESCRIPCION = 'PERSONA JURIDICA'), 0 );");

            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '98754321012'), 'E310000000001', 200.00, 36.00 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '98754321012'), 'E310000000002', 1000.00, 180.00 );");

            //datos extra
            migrationBuilder.Sql("INSERT INTO Contribuyentes (RncCedula, Nombre, TipoContribuyenteId, EstaActivo) VALUES ('98754321015', 'CARLOS BAEZ', (SELECT Id FROM TiposContribuyentes WHERE DESCRIPCION = 'PERSONA FISICA'), 1 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '98754321015'), 'E310000000003', 560.00, 100.80 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '98754321015'), 'E310000000004', 490.00, 88.20 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '98754321015'), 'E310000000005', 770.00, 138.60 );");


            migrationBuilder.Sql("INSERT INTO Contribuyentes (RncCedula, Nombre, TipoContribuyenteId, EstaActivo) VALUES ('123456788', 'FERRETERIA SANTO DOMINGO', (SELECT Id FROM TiposContribuyentes WHERE DESCRIPCION = 'PERSONA JURIDICA'), 1 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '123456788'), 'E310000000006', 2500.00, 450.80 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '123456788'), 'E310000000007', 360.00, 64.80 );");

            migrationBuilder.Sql("INSERT INTO Contribuyentes (RncCedula, Nombre, TipoContribuyenteId, EstaActivo) VALUES ('123456777', 'REPUESTOS NACIONAL', (SELECT Id FROM TiposContribuyentes WHERE DESCRIPCION = 'PERSONA JURIDICA'), 1 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '123456777'), 'E310000000008', 150.00, 27.00 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '123456777'), 'E310000000009', 990.00, 178.20 );");

            migrationBuilder.Sql("INSERT INTO Contribuyentes (RncCedula, Nombre, TipoContribuyenteId, EstaActivo) VALUES ('98754321011', 'CARLA BATISTA', (SELECT Id FROM TiposContribuyentes WHERE DESCRIPCION = 'PERSONA FISICA'), 1 );");
            migrationBuilder.Sql("INSERT INTO ComprobantesFiscales (ContribuyenteId, Ncf, Monto, Itbis) VALUES ((SELECT Id FROM Contribuyentes WHERE RncCedula = '98754321011'), 'E310000000010', 1140.00, 205.20 );");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
