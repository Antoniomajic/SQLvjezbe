using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassageParlor
{
    internal class Supplementary
    {

        public static bool DEV;


        public static int LoadNumberRange(string message, string error, int start, int end)
        {
            while (true)
            {
                int n;
                Console.WriteLine(message);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if(n>=start && n <= end)
                    {
                        return n;
                    }
                    Console.WriteLine(error);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(error);
                }
            }
        }

        internal static int LoadWholeNumber(string message, string error)
        {
            int n;
            while(true)
            {
                Console.WriteLine(message);
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > 0)
                    {
                        return n;   
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(error);
                }
            }
        }

        internal static string LoadString(string message, string error)
        {
            string s = "";
            while(true)
            {
                Console.WriteLine(message);
                s = Console.ReadLine();
                if (s != null && s.Trim().Length > 0)
                {
                    return s;
                }
                Console.WriteLine(error);
            }
           
        }

        internal static DateTime LoadDate(string v1, string v2)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(v1);
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(v2);
                }
            }
        }


        internal static decimal LoadDecimalNumber(string message, string error)
        {
            decimal b;
            while (true)
            {
                Console.Write(message);
                try
                {
                    b = decimal.Parse(Console.ReadLine());
                    if (b > 0)
                    {
                        return b;
                    }
                    Console.WriteLine(error);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(error);
                }
            }
        }






    }



}
