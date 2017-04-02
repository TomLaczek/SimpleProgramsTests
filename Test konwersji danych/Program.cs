using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_konwersji_danych
{
    class Program
    {
        public static double a = 3;
        public static double b = 3;
        public static double potega;
        public static string sWynik;
        public static int suma=0;

        public static int a2 = 0;
        public static int b2 = 0;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(sWynik + "Number "+a+" to the power of "+b);
                potega = Math.Pow(a, b);
            sWynik = potega.ToString();
            Console.WriteLine(sWynik+"\n Right now we'll count sum of single digits\n");
            Console.ReadLine();
            Console.WriteLine("\n\n1. Method GetNumericValue\nPower of "+a+" changing to String and spliting on saprete Chars\nNext changing them to Ints using GetNumericValue\n");
            a2 = (int)Char.GetNumericValue(sWynik[0]);
            b2 = (int)Char.GetNumericValue(sWynik[1]);
            Console.WriteLine("a= " + a2 + "    b=" + b2);
            suma = a2 + b2;
            Console.WriteLine(suma + " Yes! It worked!");
            Console.ReadLine();


            Console.WriteLine("\n\n2. Method Convert.ToInt32\nConvert Double na String and next String to Int");
            a2 = Convert.ToInt32(sWynik[0]);
            b2 = Convert.ToInt32(sWynik[1]);
            Console.WriteLine("a= " + a2 + "    b=" + b2);
            suma = a2 + b2;
            Console.WriteLine(suma +" ...... and It doesn't work as it should be... Problem in Converting and ASCII");
            Console.ReadLine();

                Console.WriteLine("\n\n3. Method Int.TryParse\nInny Sposób\nKonwertujemy Double na String i następnie String na Int\n");
                int.TryParse(Convert.ToString(sWynik[0]),out a2);
                int.TryParse(Convert.ToString(sWynik[1]), out b2);
                Console.WriteLine("a= " + a2 + "    b=" + b2);
                suma = a2 + b2;
                Console.WriteLine(suma + " Yes! It worked!");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Unknown Error");
                Console.ReadLine();
            }
        }
    }
}
