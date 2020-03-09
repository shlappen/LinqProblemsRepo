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

            //var classGradesIndex1 = classGrades[0].Split().OrderByDescending(m => m.Take(classGrades.Count - 1)).ToList();

            //var newClassGrades = classGrades[0].
            IEnumerable<int> newClassGrades = classGrades[0].Split(',').Select(n => Convert.ToInt32(n));
            //IEnumerable<int> newClassGrades = classGrades[0].Split(',');
            
            foreach (int grade in newClassGrades)
            {
                Console.WriteLine(grade);
            }



            //classGradesIndex1 = classGrades[0].Average(m => m)

            //classGradesOrdered = classGrades[0].OrderByDescending(m => m.Take(classGrades.Length - 1));


            //var classGradesOrdered = classGradesIndex1.OrderByDescending(m => m.Take(classGradesIndex1.Length - 1));
            //var classGradesOrdered = classGradesIndex1(m => m.Average.Split());
            //var classGradesWithoutLastValue = classGradesIndex1.Take(classGradesIndex1.Length-1);

            //List<string> revisedClassGrades = classGrades;

            //for (int i = 0; i < classGrades.Count; i++)
            //{
            //    revisedClassGrades[i].Split().
            //}

            //foreach(string grade in classGradesOrdered)
            //{
            //    Console.WriteLine(grade);
            //}

            //IEnumerable<string> classGradesWithoutLowest = classGrades.OrderByDescending(m => m).Take(classGrades.Count - 1);
            //foreach(string grade in classGradesWithoutLowest)
            //{
            //    Console.WriteLine(grade);
            //}

            Console.ReadLine();





        }
    }
}
