
using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChumachenkoZS.Sprint5.Task6.V5.Lib
{
    public class DataService
    {
        public int Calculate(string path)
        {
            string text = File.ReadAllText(path);

            int count = 0;

            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
