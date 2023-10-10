using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hashtable h = new Hashtable() {
                {"ID" , 1 },
                {"Name" , "Kanika" },
                {"Expected Salary " , 40000 }
            };

            //  foreach (var s in h.Keys)
            // {
            //   Console.WriteLine(h[s]);
            //}

            foreach (var s in h.Values)
            {
                Console.WriteLine(s);
            }
            h.Add("Email", "sabharwalkanika1999@gmail.com");
            h.Remove("ID");
            Console.WriteLine(h["Name"]);
            Console.WriteLine(h.ContainsKey("ID"));
            Console.WriteLine(h.ContainsValue("Kanika"));
            Console.WriteLine("Kanika".GetHashCode());
            Console.WriteLine(h.Count);
            h.Clear();
            Console.ReadLine();
        }
    }
}
