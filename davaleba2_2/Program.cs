using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sheyvane asaki; ");

            int asaki = int.Parse(Console.ReadLine());

            if(asaki >=18) 
            {
                Console.WriteLine("gilocav! xmis micemis ufleba gaqvs");
            }else if(asaki <18) 
            {
                Console.WriteLine("samwuxarod xmis micemis ufleba jer ar gaqvs");
            }
            else 
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
