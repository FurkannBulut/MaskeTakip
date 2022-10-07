using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Workaround
{
    
   public class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.NationalIdentity = 10000000000;
            person1.FirstName = "AD";
            person1.LastName = "SOYAD";
            person1.DateOfBirthYear = 1997;

            SelamVer(person1.FirstName);
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }
        static void SelamVer(string isim)
        {
            Console.WriteLine("Merhaba  " + isim);
        }
    }

}
