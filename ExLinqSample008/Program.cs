using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExLinqSample008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* GroupBy
            依據條件將資料分成群組
            回傳型別是 IEnumerable<IGrouping< TKey,TSource >>
            */

            var list = CreateList();
            var result = list.GroupBy((x) => x.City);
            foreach (var item in result)
            {
                Console.WriteLine($"住在 : {item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine(p.Name);
                }
                Console.WriteLine("--------");
            }
            Console.ReadLine();

            
            /*執行結果：
            住在: 台北
            Bill
            John
            --------
            住在: 高雄
            Tom
            --------
            住在 : 台南
            David
            Jeff
            --------
            //*/
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
        {
            new MyData() { Name = "Bill" , City = "台北" },
            new MyData() { Name = "John" , City = "台北" },
            new MyData() { Name = "Tom" , City = "高雄" },
            new MyData() { Name = "David", City = "台南" },
            new MyData() { Name = "Jeff" , City = "台南" },
         };
        }
    }


    class MyData
    {
        public string City
        { get; set; }
        public string Name
        { get; set; }
    }

}


