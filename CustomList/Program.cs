using System;
using AList;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            AList.CustomList<string> n = new AList.CustomList<string>();
            n.Add("A");
            n.Add("B");
            n.Add("C");
            n.Add("D");
            n.Add("E");
            n.Add("F");
            n.Add("K");
            n.Add("Y");
            n.Add("L");
            n.Remove("A");
            for (int i = 0; i < n.GetLength(); i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
