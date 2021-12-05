using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Homework
{
    class Reverse
    {
        public void Tersleme(string word)
        {
            string res = " ";
            string[] arr = word.Split(" ");
            foreach (string item in arr)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                  res = res + item[i];
                }
                res = res + " ";
            }
            Console.WriteLine(res);
        }
    }
}
