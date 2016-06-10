using System;
using System.IO;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTempFiles();
            Triangle triangle = new Triangle("triangle.txt");
            triangle.Solve(0);

            Console.WriteLine(@"sum: "+triangle.Sum);


            Triangle triangle1 = new Triangle("simple_triangle.txt");
            triangle1.Solve(0);

            Console.WriteLine(@"sum: " + triangle1.Sum);



            Console.ReadLine();
        }

        static void GetTempFiles()
        {
            if (!File.Exists("triangle.txt"))
            {
                File.AppendAllText("triangle.txt", TriangleFiles.triangle);
            }
            if (!File.Exists("simple_triangle.txt"))
            {
                File.AppendAllText("simple_triangle.txt", TriangleFiles.simple_triangle);
            }

        }
    }
}
