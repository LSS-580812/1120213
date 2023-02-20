using LinqSample001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample003
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var list = CreateList();

            //增加或刪除
            list.Add(new MyData { Name = "AABBCC", Age = 88 });

            //list.Add("AA", 40);


            /* FirstOrDefault
            // 開始用 var 了
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.FirstOrDefault((x) => x.Age < 30);
            try
            {
                Console.WriteLine($"小於 37 歲的人第一個被找到的是 : {person1.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"小於 37 歲的人第一個被找到的是 : 無 " + ex.Message);
            }
            

            // 因為找不到, 就會跳出例外
            try
            {
                var person2 = list.First((x) => x.Age < 30);
                Console.WriteLine($"小於 30 歲的人第一個被找到的是 : {person2.Name}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"小於 30 歲的人第一個被找到的是 : 無 " + ex.Message);
            }
            // */

            /*
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.LastOrDefault((x) => x.Age > 60);
            Console.WriteLine($"大於 35 歲的人最後一個被找到的是 : {person1.Name}");

            // 因為找不到, 就會跳出例外
            var person2 = list.Last((x) => x.Age > 60);
            Console.WriteLine($"大於 50 歲的人最後一個被找到的是 : {person2.Name}");
            */


            /*
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的 : {person1.Name} - {person1.Age}");

            // 因為找不到唯一 (裡面有兩個 Bill) 就會跳出例外
            try
            {
                var person2 = list.Single((x) => x.Name == "Bill");
                Console.WriteLine($"找到唯一的 : {person2.Name} - {person2.Age}");
            }
            catch (Exception)
            {
                Console.WriteLine($"多筆資料 :");
                var person2 = list.Where((x) => x.Name == "Bill");
                foreach (MyData person in person2)
                {
                    Console.WriteLine($"{person.Name} 是 {person.Age} 歲");
                }
                
            }
            //*/

            /* FirstOrDefault
            var person = list.FirstOrDefault((x) => x.Name == "李小龍");
            // 判斷回傳結果是否為 null
            if (person == null)
            {
                //如果是 null 則另行處理
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到 : {person.Name} - {person.Age}");
            }
            */


            /* ElementAtOrDefault
            int index = 1;
            // 這裡的 person 是單個物件, 也就是 MyData person
            var person = list.ElementAtOrDefault(index);
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為 : {index} 的人是 {person.Name} - { person.Age}");
            }
            */

            /*
            string name = "David";
            bool result = list.Any((x) => x.Name == name);
            if (result)
            {
                Console.WriteLine($"找到了 : {name}");
            }
            else
            {
                Console.WriteLine($"找不到 : {name}");
            }
            */


            /* All
            string name = "Bill";
            bool isAllBill = list.All((x) => x.Name == name);
            if (isAllBill)
            {
                Console.WriteLine($"全都是 {name}");
            }
            else
            {
                Console.WriteLine($"有些人不叫 {name}");
            }
            bool isAllOverForty = list.All((x) => x.Age >= 40);
            if (isAllOverForty)
            {
                Console.WriteLine("大家都超過 40 歲");
            }
            else
            {
                Console.WriteLine("有人不到 40 歲");
            }
            */

            /*
            // 計算 list 中，所有 Age 的總和
            int total = list.Sum((x) => x.Age);
            Console.WriteLine($"年齡的總和為: {total}");
            // 取得 list 中, Age 最小的值
            var minAge = list.Min((x) => x.Age);
            Console.WriteLine($"最小的年齡為 : {minAge}");
            // 取得 list 中, Age 最大的值
            var maxAge = list.Max((x) => x.Age);
            Console.WriteLine($"最大的年齡為 : {maxAge}");
            // 取得 list 中的數量
            //請注意 Count 和 Count() 是不一樣的
            int count = list.Count();
            Console.WriteLine($"list 總個數為 : {count}");
            int countOfBill = list.Count((x) => x.Name == "Bill");
            Console.WriteLine($"list 中的 Bill 總數量為 : {countOfBill}");
            // 取得所有年齡的平均值
            var average = list.Average((x) => x.Age);
            Console.WriteLine($"年齡的平均值為 : {average}");
            //*/

            // 找出名稱為 Bill 中的最小 Age
            var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有 Bill 中最小的年齡是 : {min}");
            // 計算名稱為 Bill 的年齡總和
            var total = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡總和是 : {total}");
            var average = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡平均是 : {average}");

            Console.ReadLine();
        }

        static List<MyData> CreateList()
        {
            /*
            return new List<MyData>()
            {
                new MyData { Name = "Bill", Age = 47 },
                new MyData { Name = "John", Age = 37 },
                new MyData { Name = "Tom", Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill", Age = 66 },
                new MyData{Name="LSS", Age= 55},
            };
            */

            var data = new List<MyData>()
            {
                new MyData { Name = "Bill", Age = 47 },
                new MyData { Name = "John", Age = 37 },
                new MyData { Name = "Tom", Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill", Age = 66 },
                new MyData{Name="LSS", Age= 55},
            };

            
            return data;
        }

        //*
        static void Bill_Age<T>(List<T> data)
        {
            var min = data.Where((x) => x.Name == "Bill").Min((x) => x.Age);




            /*
            foreach ( T s in data)
            {
                s.
            }*/
        }
        //*/

    }
}
