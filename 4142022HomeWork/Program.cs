using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _4142022HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Directory,File
            //Directory.CreateDirectory(@"C:/Users/99470/Desktop/Directory1");
            //Directory.CreateDirectory(@"C:/Users/99470/Desktop/Directory2");
            //Directory.Delete(@"C:/Users/99470/Desktop/Directory1");
            //Directory.Move(@"C:/Users/99470/Desktop/Directory2", @"C:\Users\99470\Desktop\Nz\Directory2");
            //if (Directory.Exists(@"C:/Users/99470/Desktop/Directory1"))
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);
            //File.Create(@"C:/Users/99470/Desktop/Directory2/file.txt");
            //using (StreamWriter sw = new StreamWriter(@"C:/Users/99470/Desktop/Directory2/file.txt"))
            //{
            //    sw.Write("Text");
            //}
            //using (StreamReader sr= new StreamReader(@"C:/Users/99470/Desktop/Directory2/file.txt"))
            //{
            //    var result = sr.ReadToEnd();
            //    Console.WriteLine(result);

            //}
            #endregion


            #region Json
            Sales dress1 = new Sales { Id = 1, Count = 1, Colour = "Red", Size = 34, Price = 200 };
            Sales dress2 = new Sales { Id = 2, Count = 2, Colour = "Yellow", Size = 40, Price = 340 };
            Boutique sale1 = new Boutique()
            {
                Id = 1,
                dress = dress1,
                TotalSale = dress2.Price * dress2.Count

            };
            Boutique sale2 = new Boutique()
            {
                Id = 2,
                dress = dress2,
                TotalSale = dress2.Price * dress2.Count

            };
            List<Boutique> sales = new List<Boutique>();
            sales.Add(sale1);
            sales.Add(sale2);

            var jsonstring1 = JsonConvert.SerializeObject(sales);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\99470\source\repos\4142022HomeWork\4142022HomeWork\Files\Json.json"))
            {
                sw.Write(jsonstring1);
            }
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\99470\source\repos\4142022HomeWork\4142022HomeWork\Files\Json.json"))
            {
                result = sr.ReadToEnd();
            }
            var Parsejson = JsonConvert.DeserializeObject(result);
            Console.WriteLine(Parsejson);
            #endregion



        }
    }
}
