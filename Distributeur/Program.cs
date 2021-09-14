using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selectionner botre boisson");
            Console.WriteLine("Expresso  => [1]");
            Console.WriteLine("Allongé   => [2]");
            Console.WriteLine("Capuccino => [3]");
            Console.WriteLine("Chocolat  => [4]");
            Console.WriteLine("The       => [5]");
            try
            {
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(new Expresso());
                    break;
                case 2:
                    Console.WriteLine(new Allenge());
                    break;
                case 3:
                    Console.WriteLine(new Capuccino());
                    break;
                case 4:
                    Console.WriteLine(new Chocolat());
                    break;
                case 5:
                    Console.WriteLine(new The());
                    break;
                default:
                    Console.WriteLine("Votre choix n'existe pas..");
                    break;
            }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
               
            }finally
            {
                Console.ReadKey();
            }
        }
    }
}
