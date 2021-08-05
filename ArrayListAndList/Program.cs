using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAndList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList array=new ArrayList();
            array.Add(20);
            array.Add(30);
            array.Add(50);
            array.Add(60);
            array.Add(10);
            array.Add(15);
            array.Add(40);
            array.Add(90);
            array.Add(60);
            array.Add(100);
            array.Add(120);
            array.RemoveAt(9);
            foreach (var value in array)
            {
                Console.WriteLine(value);
            }


            //List
            List<string> names=new List<string>();
            names.Add("Saiful");
            names.Add("Islam");
            names.Add("Pavel");
            names.Add("Mou");
            names.ForEach(Console.WriteLine);
            foreach (var data in names)
            {
                if (data=="Saiful")
                {
                    Console.WriteLine("Found");
                }
            }
            Console.ReadKey();
        }
    }
}
