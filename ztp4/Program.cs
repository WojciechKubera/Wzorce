using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztp4
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractPlayer objPlayer1 = new Character();
            objPlayer1.Role = "Mage";
            objPlayer1 = new SwordDecorator(objPlayer1);
            //Console.WriteLine(objPlayer1.GetDescription());
            //objPlayer1 = new BowDecorator(objPlayer1);
            objPlayer1 = new BowDecorator(objPlayer1);

           // var clone = objPlayer1.Clone();
//clone.Role = "Warrior";
          //  clone = new BowDecorator(clone);
            //Console.WriteLine(clone.GetDescription());
            Console.WriteLine(objPlayer1.GetDescription());
            Console.ReadKey();
          

        }

     

    }
}
