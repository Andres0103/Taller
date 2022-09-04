using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**PANES PANCHOCHA**");

            Pan_Común t1 = new Pan_Común();
            pan_leche t2 = new pan_leche();
            pan_integral t3 = new pan_integral();



            string catpan;
           
            Console.WriteLine("Elija la categoria de panes que desea revisar: ");
            Console.WriteLine("1. Pan común.");
            Console.WriteLine("2. Pan de leche.");
            Console.WriteLine("3. Pan integral.");
           
            catpan = (Console.ReadLine());

           

            switch (catpan)
            {

                case "1":
                    Console.WriteLine("Ingredientes del pan común: 125g leche, 50g azúcar, 25g aceite, 1 huevo,");
                    Console.WriteLine("1 cda de vainilla,15g levadura, 300g harina, 1 pizca de sal."); 
                    t1.registro1(catpan.ToString());

                    break;

                case "2":
                    Console.WriteLine("Ingredientes del pan leche: 325g agua, 10g azúcar, 45g aceite,15g levadura, ");
                    Console.WriteLine("500g harina, 1 pizca de sal.");
                    t2.registro2(catpan.ToString());
                    break ;

                case "3":
                    Console.WriteLine("Ingredientes del pan integral: 2 tazas de harina de centeno integral, 1/2 taza de harina cómun, 8g de levadura,");
                    Console.WriteLine("2cda de azucar, 1 cda de sal, 1 taza de leche, 2 cda de aceite, 1 huevo, semillas.");
                    t3.registro3(catpan.ToString());
                    break;
            }


        }
    }
}
