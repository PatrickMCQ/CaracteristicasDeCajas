using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteristicasCajas
{
    class Program
    {
        static void Main(string[] args)
        {
            presentacion();            
            Console.ReadKey();
        }

        private static void presentacion()
        {
            byte dato = 0;

            Console.WriteLine("\n\t\t\t\t\t\t\t---------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\tUniversidad de Occidente");
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\tPatrick Manrique Cubías Quintana");
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\t\tLos Cuates");
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\tCajas y sus características");
            Console.WriteLine("\n\t\t\t\t\t\t\t\t\t\tSONRÍE YAHSHUA TE AMA");
            Console.WriteLine("\n\t\t\t\t\t\t\t---------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Seleccione la caja que desee para ver sus características");
            Console.WriteLine();
            Console.WriteLine("1. Primera Caja");
            Console.WriteLine("2. Segunda Caja");
            Console.WriteLine("3. Tercera Caja");
            Console.WriteLine("4. Cuarta Caja");
            dato = Convert.ToByte(Console.ReadLine());

            switch(dato)
            {
                case 1:
                    {
                        Console.WriteLine();
                        Console.WriteLine("--- Caja 1 ---");
                        Caja caja1 = new Caja(12.67f, 23.54f, 34.7f);
                        caja1.mostrarDatos();
                        Console.WriteLine();
                        condicionDoWhile();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("--- Caja 2 ---");
                        Caja caja2 = new Caja(7.8f, 24.78f, 12.7f, "verde");
                        caja2.mostrarDatos2();
                        Console.WriteLine();
                        condicionDoWhile();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine();
                        Console.WriteLine("--- Caja 3 ---");
                        Caja caja2 = new Caja(4.65f, 10.54f, 23.09f, "rojo");
                        caja2.mostrarDatos3();
                        Console.WriteLine();
                        condicionDoWhile();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine();
                        Console.WriteLine("--- Caja 4 ---");
                        Caja caja2 = new Caja(3.4f, 1.89f, 5.7f, "cafes");
                        caja2.mostrarDatos4();
                        Console.WriteLine();
                        condicionDoWhile();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Número ingresado incorrecto");
                        break;
                    }
            }
        }

        private static void condicionDoWhile()
        {
            byte dato = 0;
            Console.WriteLine("5. Regresar al menú");
            Console.WriteLine("0. Salir del programa");
            dato = Convert.ToByte(Console.ReadLine());

            if(dato == 5)
            {
                presentacion();
            }else if(dato == 0)
            {
                Environment.Exit(-1);
            }else
            {
                Console.WriteLine("Ingresó un número incorrecto");
            }
           
        }

        public class Caja
        {
            private string NombreEmpresa = "Los Cuates";
            private string TipoMaterial;
            private string LadoParaAbrir;

            public string color { get; set; }
            public float altura { get; set; }
            public float ancho { get; set; }
            public float profundidad { get; set; }
            public string tipoMaterial { get { return TipoMaterial; } }
            public string nombreEmpresa { get { return NombreEmpresa; } }
            public string ladoParaAbrir { get { return LadoParaAbrir; } }

            public Caja(float altura, float ancho, float profundidad)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
            }

            public Caja(float altura, float ancho, float profundidad, string color)
            {
                this.altura = altura;
                this.ancho = ancho;
                this.profundidad = profundidad;
                this.color = color;
               

                if (color == "rojo")
                {
                    TipoMaterial = "Metal";
                } else if(color == "cafes")
                {
                    TipoMaterial = "Cartón";
                }

                if(TipoMaterial == "Cartón")
                {
                    LadoParaAbrir = "Solo se puede abrir por arriba";
                } else
                {
                    LadoParaAbrir = "No definido";
                }
            }

            public void mostrarDatos()
            {
                Console.WriteLine();
                Console.WriteLine("Empresa: " + nombreEmpresa);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Ancho: " + ancho);
                Console.WriteLine("Profundidad: " + profundidad);
                Console.WriteLine();
            }

            public void mostrarDatos2()
            {
                Console.WriteLine();
                Console.WriteLine("Empresa: " + nombreEmpresa);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Ancho: " + ancho);
                Console.WriteLine("Profundidad: " + profundidad);
                Console.WriteLine("Color: " + color);
                Console.WriteLine();
            }

            public void mostrarDatos3()
            {
                Console.WriteLine();
                Console.WriteLine("Empresa: " + nombreEmpresa);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Ancho: " + ancho);
                Console.WriteLine("Profundidad: " + profundidad);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Tipo de Material: " + tipoMaterial);
                Console.WriteLine();
            }

            public void mostrarDatos4()
            {
                Console.WriteLine();
                Console.WriteLine("Empresa: " + nombreEmpresa);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Ancho: " + ancho);
                Console.WriteLine("Profundidad: " + profundidad);
                Console.WriteLine("Color: " + color);
                Console.WriteLine("Tipo de Material: " + tipoMaterial);
                Console.WriteLine("Lado para abrir: " + ladoParaAbrir);
                Console.WriteLine();
            }

        }

    }

}
