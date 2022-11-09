using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidad.Practica3;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Autor autor1 = new Autor() {Nombre="Luisano", Apellido="Koppo", FechaNacimiento= new DateTime(2002-03-25), Ciudad="Mar del Plata", Domicilio="Gascon 3266", Pais="Argentina"};
            Autor autor2 = new Autor() { Nombre = "Luisa", Apellido = "Koppa", FechaNacimiento = new DateTime(1997 - 07 - 01), Ciudad = "Mar del Plata", Domicilio = "Guemes 2555", Pais = "Argentina" };
            Empleado empleado1 = new Empleado() {Nombre="Mark", Apellido="Rekel", Titulo="Limpieza", FechaIngreso=new DateTime(2019-12-28)};
            Empleado empleado2 = new Empleado() { Nombre = "Maria", Apellido = "Rekeles", Titulo = "Limpieza", FechaIngreso = new DateTime(2019 - 01 - 15) };
            Venta venta1 = new Venta() {Tienda="Pepito Store", NumeroOrden=0566, Cantidad=5, Fecha= new DateTime(2022-06-12), Titulo="Lore de DarkSouls"};
            Venta venta2 = new Venta() { Tienda = "Pepito Store", NumeroOrden = 0567, Cantidad = 55, Fecha = new DateTime(2022 - 06 - 15), Titulo = "Lore de DarkSouls" };
            Publicador publicador1 = new Publicador() {Nombre="Alfonso", Ciudad="Mar del Plata", Domicilio="San Luis 3000", Contacto="alfmdq@gmail.com", Pais="Argentina"};
            Publicador publicador2 = new Publicador() { Nombre = "Hektoplosmo", Ciudad = "Mar del Plata", Domicilio = "Alberti 2669", Contacto = "plomohekto@gmail.com", Pais = "Argentina" };
            Titulo titulo1 = new Titulo() {NombreAuto="Luisano Koppo", titulo="La port o malo", Categoria="Suspenso", Precio=3200, Notas="Carta de un padre en pena"};
            Titulo titulo2 = new Titulo() { NombreAuto = "Luisano Koppo", titulo = "KlK", Categoria = "Comedia", Precio = 1450, Notas = "Aburrimiento provoca libro" };

            MessageBox.Show(autor1.Nombre);
        }
    }
}
