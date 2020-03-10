using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Console.WriteLine("Problem 1");
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> hasTh = words.FindAll(m => m.Contains("th"));

            foreach (string word in hasTh)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();

            //Problem 2
            Console.WriteLine("Problem 2");

            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            IEnumerable<string> distinctNames = names.Distinct();
            foreach(string name in distinctNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();







            //Problem 3
            Console.WriteLine("Problem 3");
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            //IEnumerable<double> result = new List<double>();
            //for (int i = 0; i < classGrades.Count; i++)
            //{
            //    result = classGrades[i].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Average(n => n);

            //}
            List<double> averages = new List<double>();

            for (int i = 0; i < classGrades.Count; i++)
            {
                double result = classGrades[i].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
                averages.Add(result);

            }

            Console.WriteLine(averages.Average());




            //This works below but needs to be cleaned up
            //List<double> averages = new List<double>();

            //double result = classGrades[0].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
            //double result2 = classGrades[1].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
            //double result3 = classGrades[2].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
            //double result4 = classGrades[3].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();

            //averages.Add(result);
            //averages.Add(result2);
            //averages.Add(result3);
            //averages.Add(result4);

            //double final = averages.Average();

            //Console.WriteLine(result);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);

            //Console.WriteLine(final);

            Console.ReadLine();





        }
    }
}
