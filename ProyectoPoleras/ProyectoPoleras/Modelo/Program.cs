using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProyectoPoleras.Modelo
{
    public class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("----------Usuario-------------");
            Console.WriteLine("");
            Usuario u1 = new Usuario();

            u1.Nomb_Usuario = "Camilo222";
            u1.Contraseña_Usuario = "123";
            u1.TipoUsuario();
            Thread.Sleep(800); //Thread

            Console.WriteLine("Usuario: " + u1.Nomb_Usuario);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Contraseña: " + u1.Contraseña_Usuario);
            Thread.Sleep(800); //Thread


            Console.WriteLine("");
            Console.WriteLine("----------Poleras-------------");
            Console.WriteLine("");

            Poleras polera1 = new Poleras();
            polera1.Id = 1;
            polera1.Nombre = "Iron Maiden";
            polera1.Talla = "XL";
            polera1.Descripcion = "Polera 100% algodon.";

            Console.WriteLine("Id: " + polera1.Id);
            Thread.Sleep(800); //Thread


            Console.WriteLine("Nombre: " + polera1.Nombre);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Talla: " + polera1.Talla);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Descripcion: " + polera1.Descripcion);
            Thread.Sleep(800); //Thread


            Console.WriteLine("");
            Console.WriteLine("----------Administrador-------------");
            Console.WriteLine("");

            Administrador admin = new Administrador();

            admin.Nomb_admin = "Carlos";
            Thread.Sleep(800); //Thread
            admin.Contraseña_admin = "qwerty";
            Thread.Sleep(800); //Thread

            Console.WriteLine("Usuario: " + admin.Nomb_admin);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Contraseña: " + admin.Contraseña_admin);
            Thread.Sleep(800); //Thread

            admin.DarBajaPolera();
            Thread.Sleep(800); //Thread

            admin.ModificarPolera();
            Thread.Sleep(800); //Thread




            Console.WriteLine("");
            Console.WriteLine("----------Visitante-------------");
            Console.WriteLine("");

            Visitante visitante1 = new Visitante();

            visitante1.Nomb_Registro = "Juan111";
            Thread.Sleep(800); //Thread
            visitante1.Contraseña_Registro = "hola";
            Thread.Sleep(800); //Thread
            visitante1.Correo_Registro = "juan@correo.com";
            Thread.Sleep(800); //Thread

            Console.WriteLine("Nombre: " + visitante1.Nomb_Registro);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Contraseña: " + visitante1.Contraseña_Registro);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Correo: " + visitante1.Correo_Registro);
            Thread.Sleep(800); //Thread

            visitante1.RegistrarVisitante();
            Thread.Sleep(800); //Thread

            Console.WriteLine("");
            Console.WriteLine("----------Carrito-------------");
            Console.WriteLine("");


            Carrito carrito1 = new Carrito();


            carrito1.Precio = 9990;
            Thread.Sleep(800); //Thread
            carrito1.Cantidad = 1;
            Thread.Sleep(800); //Thread
            carrito1.Producto = "Polera Hombre Iron Maiden";
            Thread.Sleep(800); //Thread
            carrito1.Subtotal = 9990;
            Thread.Sleep(800); //Thread
            carrito1.Total = 9990;
            Thread.Sleep(800); //Thread

            Console.WriteLine("Precio: " + carrito1.Precio);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Cantidad: " + carrito1.Cantidad);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Producto: " + carrito1.Producto);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Subtotal: " + carrito1.Subtotal);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Total: " + carrito1.Total);
            Thread.Sleep(800); //Thread

            carrito1.AgregarPolera();
            carrito1.EliminarPolera();


            Console.WriteLine("");
            Console.WriteLine("----------Genero-------------");
            Console.WriteLine("");


            Genero hombre = new Genero();

            hombre.Id = 1;
            Thread.Sleep(800); //Thread
            hombre.Nomb_genero = "Hombre";
            Thread.Sleep(800); //Thread

            Genero mujer = new Genero();

            mujer.Id = 2;
            Thread.Sleep(800); //Thread
            mujer.Nomb_genero = "Mujer";
            Thread.Sleep(800); //Thread


            Console.WriteLine("Id: " + hombre.Id);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Nombre: " + hombre.Nomb_genero);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Id: " + mujer.Id);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Nombre: " + mujer.Nomb_genero);
            Thread.Sleep(800); //Thread

            Thread.Sleep(800); //Thread

            Console.WriteLine("");
            Console.WriteLine("----------Comprar-------------");
            Console.WriteLine("");


            Comprar comprar1 = new Comprar();

            comprar1.Id = 1;
            Thread.Sleep(800); //Thread

            Console.WriteLine("Id: " + comprar1.Id);
            Thread.Sleep(800); //Thread
            comprar1.GenerarFactura();
            Thread.Sleep(800); //Thread

            Console.WriteLine("");
            Console.WriteLine("----------Pagar-------------");
            Console.WriteLine("");


            Pagar pagar1 = new Pagar();

            pagar1.Id = 1;
            Thread.Sleep(800); //Thread
            pagar1.MetodoPago = "Tarjeta de Debito";
            Thread.Sleep(800); //Thread

            Pagar pagar2 = new Pagar();

            pagar2.Id = 2;
            Thread.Sleep(800); //Thread
            pagar2.MetodoPago = "Tarjeta de Credito";
            Thread.Sleep(800); //Thread

            Console.WriteLine("Id: " + pagar1.Id);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Metodo de Pago: " + pagar1.MetodoPago);
            Thread.Sleep(800); //Thread
            pagar1.PagarPoleraUsuario();

            Console.WriteLine("Id: " + pagar2.Id);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Metodo de Pago: " + pagar2.MetodoPago);
            Thread.Sleep(800); //Thread
            pagar2.PagarPoleraUsuario();
            Thread.Sleep(800); //Thread

            Console.WriteLine("");
            Console.WriteLine("----------Cliente-------------");
            Console.WriteLine("");


            Cliente cliente1 = new Cliente();

            cliente1.Id = 1;
            Thread.Sleep(800); //Thread
            cliente1.Nombre_Cliente = "Camilo Andres";
            Thread.Sleep(800); //Thread
            cliente1.Apellido_Cliente = "Ogalde Fernandez";
            Thread.Sleep(800); //Thread
            cliente1.Rut_Cliente = "11223344-1";
            Thread.Sleep(800); //Thread
            cliente1.Telefono_Cliente = 123456789;
            Thread.Sleep(800); //Thread
            cliente1.Correo_Cliente = "camilo@correo.com";
            Thread.Sleep(800); //Thread
            cliente1.Region_Cliente = "Arica y Parinacota";
            Thread.Sleep(800); //Thread
            cliente1.Comuna_Cliente = "Arica";
            Thread.Sleep(800); //Thread
            cliente1.Calle_Cliente = "Los Bayonetta";
            Thread.Sleep(800); //Thread
            cliente1.NumCasa_Cliente = "#123";
            Thread.Sleep(800); //Thread
            cliente1.NumDepto_Cliente = "No aplica";
            Thread.Sleep(800); //Thread


            Console.WriteLine("Id:" + cliente1.Id);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Nombre: " + cliente1.Nombre_Cliente);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Apellido: " + cliente1.Apellido_Cliente);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Rut: " + cliente1.Rut_Cliente);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Telefono: " + cliente1.Telefono_Cliente);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Correo: " + cliente1.Correo_Cliente);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Region: " + cliente1.Region_Cliente);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Comuna: " + cliente1.Comuna_Cliente);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Calle: " + cliente1.Calle_Cliente);
            Thread.Sleep(800); //Thread
            Console.WriteLine("Numero de Casa: " + cliente1.NumCasa_Cliente);
            Thread.Sleep(800); //Thread

            Console.WriteLine("Numero Depatarmento: " + cliente1.NumDepto_Cliente);
            Thread.Sleep(800); //Thread



            ServidorSocket servidorSocket = new ServidorSocket();

            servidorSocket.Conectar();

            Console.ReadKey();


            {


            }


        }
    }
}
