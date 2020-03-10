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
            //IEnumerable<double> averagesList = new List<double>();

            double result = classGrades[0].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
            double result2 = classGrades[1].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
            double result3 = classGrades[2].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();
            double result4 = classGrades[3].Split(',').Select(n => Convert.ToDouble(n)).OrderByDescending(n => n).Take(classGrades.Count).Select(n => n).Average();

            averages.Add(result);
            averages.Add(result2);
            averages.Add(result3);
            averages.Add(result4);

            double final = averages.Average();

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.WriteLine(final);

            //Min(n => n).
            //List<int> final = result.ToList();
            //final.Sort();

            //foreach (int grade in result)
            //{
            //    Console.WriteLine(grade);
            //}

            Console.ReadLine();

            //var classGradesOrdered = intGradeList.Select(g => )

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
