using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] dataSet = System.IO.File.ReadAllLines(@"C:\Users\pbila\source\repos\DataSetSolve\DataSetSolve\DataSet-A.txt");
            Hashtable hashTable = new Hashtable();
            int length = dataSet.Length - 1;

            for (int i = 0; i < dataSet.Length; i++)
            {
                if (i==0)
                {
                    continue;
                }
                else
                {        
                    string line = dataSet[i];
                    int index = line.IndexOf(",");
                    line = line.Remove(index, 1).Insert(index, " - ");
                    line = line.Replace("\"", "");
                    hashTable.Add(length--, line);
                }
            }
            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine(hashTable[key].ToString());
            }
            
            Console.ReadKey();
        }
    }
}
