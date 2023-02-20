using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            /*
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }*/

            /*
            var enumerator= list.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { 
                enumerator.Dispose(); 
            }
            */

            /*
            foreach (var item in GetStrings())
            {
                Console.WriteLine(item);
            }
            */

            var enumerator = GetStrings().GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
            finally { enumerator.Dispose(); }
            
            Console.ReadLine();

        }

        static IEnumerable<string> GetStrings()
        {
            /*
            yield return "A";
            yield return "B";
            yield return "C";
            */
            return new EnumerableString();
            //var list = new List<string>();
        }


    }

    internal class EnumerableString : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Enumerator : IEnumerator<string>
        {
            //public string Current => throw new NotImplementedException();
            public string Current { get; private set; }

            object IEnumerator.Current => throw new NotImplementedException();

            Object IEnumerator.Current { }
            //object string Current { get; private set; }
            //object IEnumerator.Current { get; rr } 

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            { //設計錯誤
                throw new NotSupportedException();
            }
        }
    }
}
