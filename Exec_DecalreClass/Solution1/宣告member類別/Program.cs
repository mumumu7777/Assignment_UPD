using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 宣告member類別
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var telephone = new Telephone();
            Console.WriteLine(telephone.AreaCode);
            Console.WriteLine(telephone.CountryCode);
            var adress = new adress();
            Console.WriteLine(adress.Zipcode);
            Console.WriteLine(adress.City);
            Console.WriteLine(adress.Street);
        }

        class Telephone
        {
            public int CountryCode;
            public int AreaCode;
            public int Number;
            public int Ext;
        }
        class adress

        {
            public string City;
            public int Zipcode;
            public string Street;
        }


    }

}
