using System;

namespace OverLoadAdd
{
    class Program
    {
        public static int add(int a, int b)
        {
            return  a + b;
           
        }

        public static decimal add(decimal a, decimal b)
        {
            return a + b;

        }


        public  static string add(int a, int b, bool valid)
        {
            string str1 = "";
            int sum = 0;
            
            if (valid)
            {
                sum = a + b;
                if (sum == 0)
                    str1 = "The sum is " + sum.ToString() + " dollar";
                else
                    str1 = "The sum is " + sum.ToString() + " dollars";
                return str1;
                
            }
            return str1;
        }

 

        static void Main(string[] args)
        {
            var i = 49;
            var j = 19;
            string res = new string("");
            string currency = "";

            var addInteger = add(i, j);

            Console.Write($"Sum is {addInteger}  ");
            Console.WriteLine(addInteger == 1? "dollar": "dollars");

            var addDecimal = add(198.90m, 99.25m);
            Console.WriteLine($"Sum is {addDecimal} {currency = (addDecimal == 1? "dollar": "dollars")} ");

            bool valid = true;
            res = add(i, j, valid);
            Console.WriteLine(res);
            

        }
    }
}
