using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Lec2IntroToCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Non-Generic Collections

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2.0);
            arrayList.Add("Three");
            arrayList.Add(2.5f);

            for (int i = 0; i < arrayList.Count; i++) { Console.WriteLine(arrayList[i]+" "); }



        }
    }
}
