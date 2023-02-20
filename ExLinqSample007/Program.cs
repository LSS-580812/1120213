using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var result1 = list.Where((x) => x.Age > 40).ToList();
            var result2 = list.Where((x) => x.Age > 40).ToArray();
            // 使用 Name 當群組分類的索引鍵，而值資料仍然是 MyData
            var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);
            Console.WriteLine("使用 Name 當群組分類的索引鍵，而值資料仍然是 MyData ToDictionary");
            foreach (var item in result3)
            {
                Console.WriteLine($"Key={item.Key}, {item.Value.Name} -- {item.Value.Age}");
                //Console.WriteLine(item.Key);
                //Console.WriteLine($"{item.Value.Name} -- {item.Value.Age}");
            }
            
            
            Console.WriteLine("--------------");
            // 使用 Name 當群組分類的索引鍵，而且用 Age 當值資料
            var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);
            Console.WriteLine("使用 Name 當群組分類的索引鍵，而且用 Age 當值資料 ToDictionary");
            foreach (var item in result4)
            {
                Console.WriteLine($"Key={item.Key}, Value={item.Value}");
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }
            Console.ReadLine();

            /*
            //執行結果：
            使用 Name 當群組分類的索引鍵，而值資料仍然是 MyData ToDictionary
            Key = Bill, Bill --47
            Key = Tom, Tom-- 48
            --------------
            使用 Name 當群組分類的索引鍵，而且用 Age 當值資料 ToDictionary
            Key = Bill, Value = 47
            Key = John, Value = 37
            Key = Tom, Value = 48
            Key = David, Value = 36
            */
        }



        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill" , Age = 47 },
                new MyData() { Name = "John" , Age = 37 },
                new MyData() { Name = "Tom" , Age = 48 },
                new MyData() { Name = "David", Age = 36},
            };
        }

    }

    class MyData
    {
        public string Name
        { get; set; }
        public int Age
        { get; set; }
    }


}
