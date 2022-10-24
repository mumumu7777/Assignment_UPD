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
            telephone.AreaCode = 1111;
            telephone.CountryCode = 1111;
            telephone.Number = 11111;
            telephone.Ext = 11111;
            var adress = new adress();


            var adresss = new adress();
            adresss.Street = "桃園";
            adress.Zipcode = 026;
            adress.Street = "大有街";
                
           member mem = new member();
            mem.Authenticate("keee3571632","hhh123456");
                mem.Forgetpassword("keee3571632555", "hhh123456");
                mem.registormethod();
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


        class member
        {
            public void registormethod(string name, string account, string password, string cofirmpassword, string email)
            {

            }

            public void Forgetpassword(string name, string email) { }

            public void Authenticate(string account, string password) { }

        }



	}

}
