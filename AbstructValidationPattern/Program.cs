using Infrastructure.Validate;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructValidationPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product();
            p.ProductName = "Product One";
            ValidateResult result = p.IsValid();

            foreach (var item in result.Messages)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("*************");


            p.ProductName = "Product Two";
            result = p.IsValid();

            foreach (var item in result.Messages)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

    }
}
