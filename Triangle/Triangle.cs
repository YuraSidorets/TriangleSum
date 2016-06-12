using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Triangle
{
    public class Triangle
    {
        public int Sum;
        private string Filename;

        public Triangle(string filename)
        {
            Filename = filename;
            _file = new StreamReader(filename);
        }

        /// <summary>
        /// Find max sum in triangle
        /// </summary>
        /// <param name="tempIndx"></param>
        public void Solve(int tempIndx)
        {
            
            List<int> currentNums = GetData();

            if (currentNums.Count == 0)
            {
               return; 
            }

            //list of values near current in line
            List<int> nextValues = new List<int> { 0, 0, 0 };
            
            if (tempIndx - 1 >= 0)
            {
                nextValues[0] = currentNums[tempIndx - 1];
            }
            if (tempIndx + 1 < currentNums.Count)
            {
                nextValues[2] = currentNums[tempIndx + 1];
            }
                nextValues[1] = currentNums[tempIndx];

          
            int maxVal = nextValues.Max();

            if (nextValues.LastIndexOf(maxVal) == 0)
            {
                tempIndx--;
            }
            if (nextValues.LastIndexOf(maxVal) == 2)
            {
                tempIndx++;
            }

            Sum += maxVal;

            Solve(tempIndx);
        }

        private int _i;
        private  readonly StreamReader _file;

        private List<int> GetData()
        {
            string data;
            _i++;
            List<int> nums = new List<int>();
            if ((data = _file.ReadLine()) != null)
            {
                string[] dataArray = data.Split(' ');
                foreach (string num in dataArray)
                {
                    nums.Add(int.Parse(num));
                }
            }
            else
            {
                Console.WriteLine($"File {Filename} end, lines: "+ --_i);
            }

            return nums;
        }
    }
}
