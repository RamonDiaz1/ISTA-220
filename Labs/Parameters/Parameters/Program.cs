#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int yudy = 0;
            Console.WriteLine(yudy);
            Pass.Value(yudy);
            Console.WriteLine(yudy);
            yudy = Pass.SetYudy();
            Console.WriteLine(yudy);
            Console.ReadKey();


            Console.WriteLine("-----------");

            int i = 0;
            Console.WriteLine($"i is {i}");
            Pass.Value2(ref i);
            Console.WriteLine(i);
            Console.ReadKey();

            Console.WriteLine("-----------");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);

            Console.WriteLine(wi.Idontknow);
            Console.WriteLine(wi);
            Console.WriteLine(wi.Idontknow);
            Console.ReadKey();


            Console.WriteLine(wi.isTrue);
            Console.WriteLine(wi);
            Console.WriteLine(wi.isTrue);
            Console.ReadKey();

            Duck daffy = new Duck();
            Console.WriteLine($"daffy's name is[{daffy.Name}]");
            daffy.Name = "Daffy";
            Console.WriteLine($"daffy's name is[{daffy.Name}]");

            daffy.SetName("daffidil");
            Console.WriteLine($"Daffy's Name is now {daffy.Name}");

            Console.ReadKey();

            Duck huey = new Duck();
            huey.SetName("Huey");
            Console.WriteLine(huey.Name);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
