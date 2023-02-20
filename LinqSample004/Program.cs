using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
            var union = list1.Union(list2);
            Console.WriteLine("聯集的結果為 :");
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            var intersect = list1.Intersect(list2);
            Console.WriteLine("交集的結果為 :");
            foreach (var item in intersect)
            {
                Console.WriteLine(item);
            }
            //*/

            /*
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var list2 = new List<int> { 1, 3, 4, 7, 8, 9 };
            var aEXb = list1.Except(list2);
            Console.WriteLine("A 差集 B 的結果為 :");
            foreach (var item in aEXb)
            {
                Console.WriteLine(item);
            }
            var bEXa = list2.Except(list1);
            Console.WriteLine("B 差集 A 的結果為: ");
            foreach (var item in bEXa)
            {
                Console.WriteLine(item);
            }
            //*/


            /*
            //Distinct 排除重複，如果有兩個以上相同的資料，只會取一個
            var list = new List<string> { "台北", "台北", "洛杉磯", "紐約", "紐約", "台北" };
            var result = list.Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //執行結果：台北, 洛杉磯, 紐約
            //*/


            //使用 Skip=跳過幾筆 與 Take=獲取幾筆，常用在製作分頁
            var list = new List<string> { "A", "B", "C", "D", "E", "F", "F" };
            var resultOfSkip = list.Skip(3);
            Console.WriteLine("Skip(3) 的結果 ");
            Display(resultOfSkip);
            var resultOfTake = list.Take(3);
            Console.WriteLine("Take(3) 的結果 ");
            Display(resultOfTake);
            var resultOfSkipTake = list.Skip(2).Take(2);
            Console.WriteLine("Skip(2).Take(2) 的結果 ");
            Display(resultOfSkipTake);
            Console.ReadLine();


            Console.ReadLine();


        }


        static void Display(IEnumerable<string> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }

    }
}
