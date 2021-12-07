using System;
using System.Collections;


namespace ArrayListC
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList();

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.32);
            myArrayList.Add(55);
            myArrayList.Add('a');
            myArrayList.Add(25.3);

            myArrayList.Remove(55);
            myArrayList.RemoveAt(0);
            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(Object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
