using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(sizeof(int));
            //Console.ReadLine();

            //string fname = "niloy ";
            //string lname = "niloy ";
            //string full = fname + lname;
            //Console.WriteLine(full);

            //string c=Console.ReadLine();
            // this readline return a string that i have printed with writeline 
            //Console.WriteLine(c);

            // bool isNew = true;
            // Console.WriteLine(isNew);
            // Console.WriteLine(sizeof(bool));
            // Console.ReadLine();

            //long myRoll = 2000L;
            //Console.WriteLine(myRoll);
            //Console.ReadLine();

            // float myMoney = 2e4F;   //e indicates power over 10 on float & double.
            // Console.WriteLine(myMoney);
            // Console.ReadLine();

            //double  myName = 20.12D;
            //int myValue = (int)myName;
            //Console.WriteLine(myValue);
            //Console.ReadLine();

            //Console.Write("Enter Username : ");
            //string userName = Console.ReadLine();
            //Console.WriteLine(userName);
            //Console.ReadLine(); // it returns a string so any other var can't take input 

            //Console.Write("Enter Your Age : ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);
            //Console.ReadLine();

            // Console.Write("Enter Your Age : ");
            // double age_1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(age_1);
            // Console.ReadLine();

           // Console.Write("Enter Your Age : ");
           // float age = Convert.ToSingle(Console.ReadLine());
           // Console.WriteLine(age);
           // Console.ReadLine();
           
            Console.Write("Enter Your Character : ");
            Char myChar = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine(myChar);
            Console.ReadLine();
        }
    }
}
