using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    internal class Pan_Común
    {


        

        //declara variables con get y set
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string unidadmed { get; set; }
        public double precio { get; set; }
        public double cantidad { get; set; }

        //se declara el metodo constructor
        public Pan_Común()
        {
            precio = 0;
            cantidad = 0;
        
        }

        public void registro1(string catpan)
        {
            int opcion = 0;
            string codpan = "";
            string [,] pancomun = new string[5,5];

            do {

                
                Console.WriteLine("\n" + "1. Registrar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("******");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1://guardar
                        Console.Clear();
                        for (int i = 0; i <= 1; i++)
                        {
                            Console.WriteLine("Digite el código del pan:");
                            pancomun[i,0] = Console.ReadLine();
                            Console.WriteLine("Digite el nombre del pan:");
                            pancomun[i,1] = Console.ReadLine();
                            Console.WriteLine("Digite la unidad de medida del pan:");
                            pancomun[i,2] = Console.ReadLine();
                            Console.WriteLine("Digite el precio del pan:");
                            pancomun[i,3] = Console.ReadLine();
                            Console.WriteLine("Digite la cantidad de pan:");
                            pancomun[i,4] = Console.ReadLine();
                            
                            
                        }
                        break;

                    case 2://consultar

                        Console.Clear();

                        Console.WriteLine("Escriba el codigo del pan: ");
                        codpan = Console.ReadLine();

                        foreach (string item in pancomun)
                        {
                            if(item == codpan)
                            {
                                Console.WriteLine("Se ha encontrado el codigo: " + item);
                                for(int i = 0; i <= 1; i++)
                                {
                                    Console.WriteLine("codigo: " + pancomun[0,0].ToString());
                                    Console.WriteLine("nombre: " + pancomun[0,1].ToString());
                                    Console.WriteLine("u.medida: " + pancomun[0, 2].ToString());
                                    Console.WriteLine("precio: " + pancomun[0, 3].ToString());
                                    Console.WriteLine("cantidad: " + pancomun[0, 4].ToString());


                                }
                                
                            }

                            else
                            {
                                Console.WriteLine("No se encontro el codigo");
                            }
                            break;

                        }
                        break;

                    default:
                        Console.WriteLine("La opción digitada no es valida.");
                        break;


                 
                }



            } while (opcion != 0);

        }
        


    }
}
