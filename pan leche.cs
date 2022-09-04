using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    internal class pan_leche
    {
    

        //se declara el metodo constructor
        public pan_leche()
        {
          

        }

        public void registro2(string catpan)
        {
            Pan_Común t2 = new Pan_Común();

            t2.registro1(catpan.ToString());
           

            

        }
    }
}
