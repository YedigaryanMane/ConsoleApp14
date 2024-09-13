using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp14
{
    internal class Program
    {
        //1
        public static void PrintValues(int a, float f, double d, char c, string str)
        {
            Console.WriteLine(a);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(d);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(str);
        }

        //2
        public static void ConvertNums(int a, double d, string str)
        {
            Console.WriteLine(a);
            Console.WriteLine(str);
            Console.WriteLine(d);
        }

        //3
        public static void SwapNums(int a, int b)
        {
            int k = a;
            a = b;
            b = k;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void ReturnNumType(int n, int k)
        {
            if (k < n && n < k + 1)
            {
                Console.WriteLine("Number is Float");
            }
            else
            {
                Console.WriteLine("Num is integar");
            }
        }

        //5
        public static void ChekNum(int a)
        {
            if (a > 0)
            {
                Console.WriteLine("Num is positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("Num is negative");
            }
            else
            {
                Console.WriteLine("Num is zero");
            }
        }

        public static void ToVote(int age)
        {
            if (age > 0 && age < 18)
            {
                Console.WriteLine("You can not");
            }
            else
            {
                Console.WriteLine("You can");
            }
        }

        public static void FindLargest(int a, int b, int c)
        {
            if (a > c && a > b)
            {
                Console.WriteLine(a);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);
            }
        }

        public static void IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("Year is Leap");
            }
            else
            {
                Console.WriteLine("Year isn't leap");
            }
        }

        public static void IsVaild(int a, int b, int c)
        {
            if (a + b + c == 180)
            {
                Console.WriteLine("Triangle is Vaild");
            }
            else
            {
                Console.WriteLine("Triangle isn't vaild");
            }
        }

        public static void PrintEven()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintMultTable(int n)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {n} = {i * n}");
            }
        }

        public static void PrintNumFactorial(int n)
        {
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k *= i;
            }
            Console.WriteLine(k);
        }

        public static void SumNaturalNums(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n;
                n--;
            }
            Console.WriteLine(sum);
        }

        public static void PrintFibNums(int n)
        {
            Console.WriteLine(0);
            Console.WriteLine(1);
            int sum = 0;
            int n1 = 0;
            int n2 = 1;

            do
            {
                sum = n1 + n2;
                Console.WriteLine(sum);
                n1 = n2;
                n2 = sum;

            }
            while (n > n1 + n2);
        }

        public static void SumNumDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int y = n % 10;
                sum += y;
                n /= 10;
            }
            Console.WriteLine(sum);
        }

        public static void ReverseNum(int n)
        {
            int reverse = 0;

            while (n > 0)
            {
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine(reverse);
        }

        public static void CalculateDigCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                int y = n % 10;
                count++;
                n /= 10;
            }
            Console.WriteLine(count);
        }

        public static bool IsPrime(int n)
        {
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(int n)
        {
            int k = n;
            int reverse = 0;
            for (int i = 1; i <= n; i++)
            {
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            if (reverse == k)
            {
                return true;
            }
            return false;
        }

        public static int Sum2Num(int x, int y)
        {
            return x + y;
        }

        public static string ReverseString(string str)
        {
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }
            return s;
        }

        public static bool IsPrime2(int n)
        {
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static double PrintPower(int n1, int n2)
        {
            return Math.Pow(n1, n2);
        }

        public static double PrintArea(double a, double b, double r)
        {
            double M_PI = 3.14;
            double area1 = a * b;
            double area2 = r * r * M_PI;

            return area1;
            return area2;
        }

        public static void PrintNumFactorial2(int n)
        {
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k *= i;
            }
            Console.WriteLine(k);
        }

        public static void UsingBubleMethode(int[] arr)
        {
            int tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {

                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void WriteLargestElement(int[] arr)
        {
            int tmp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {

                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.WriteLine(arr[0]);
        }

        public static bool IsPalindromeString(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static void PrintTextInFile(string str)
        {
            string path = @"C:\Users\user\Desktop\New folder (6)\newfile.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(str);
            }
        }

        public static void CalculateWordCount(string str1)
        {
            char c = ' ';
            int wordCount = 1;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == c)
                {
                    wordCount++;
                }
            }
            Console.WriteLine(str1);
            Console.WriteLine(wordCount);
        }

        public static void CalculateLinesCount(string str)
        {
            int linesCount = 1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\n')
                {
                    linesCount++;
                }
            }
            Console.WriteLine(str);
            Console.WriteLine(linesCount);
        }

        public static void Reanmes()
        {
            string path = @"C:\Users\user\Desktop\New folder (6)\name1.txt";
            string path2 = @"C:\Users\user\Desktop\New folder (6)\newname1.txt";


            if (!File.Exists(path))
            {
                File.Create(path);
            }


            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("hi.How are you?");
            }

            try
            {
                File.Move(path, path2);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {    //1
             //int a = 7;
             //float f = 7.7f;
             //double d = 7.77;
             //char c = 'a';
             //string str = "C#";
             //PrintValues(a,f,d,c,str);

            //2
            //int a = Convert.ToInt32(Console.ReadLine());
            //double d = Convert.ToDouble(Console.ReadLine());
            //string str = Console.ReadLine();

            //3
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //SwapNums(a,b);

            //4
            //int  n = Convert.ToInt32(Console.ReadLine());
            //int k = Convert.ToInt32(Console.ReadLine());
            //ReturnNumType(n, k);

            //5
            //int a = Convert.ToInt32(Console.ReadLine());
            //ChekNum(a);

            //6
            //int age = Convert.ToInt32(Console.ReadLine());
            //ToVote(age);

            //7
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //FindLargest(a,b,c);

            //8
            //int year = Convert.ToInt32(Console.ReadLine());
            //IsLeapYear(year);

            //9
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //IsVaild(a, b, c);

            //16
            //PrintEven();

            //17
            //int n = int.Parse(Console.ReadLine());
            //PrintMultTable(n);

            //18
            //int n = int.Parse(Console.ReadLine());
            //PrintNumFactorial(n);

            //19
            //int n = int.Parse(Console.ReadLine());
            //SumNaturalNums(n);

            //20
            //int n = int.Parse(Console.ReadLine());
            //PrintFibNums(n);

            //21
            //int n = int.Parse(Console.ReadLine());
            //SumNumDigits(n);

            //22
            //int n = int.Parse(Console.ReadLine());
            //ReverseNum(n);

            //23
            //int n = int.Parse(Console.ReadLine());
            //CalculateDigCount(n);

            //24
            //int n = int.Parse(Console.ReadLine());
            //bool x = IsPrime(n);
            //Console.WriteLine(x);

            //25
            //int n = int.Parse(Console.ReadLine());
            //bool x = IsPalindrome(n);
            //Console.WriteLine(x);

            //26
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int sum = Sum2Num(x, y);
            //Console.WriteLine(sum);

            //27
            //string str = Console.ReadLine();
            //string q = ReverseString(str);
            //Console.WriteLine(q);

            //28
            //int n = int.Parse(Console.ReadLine());
            //bool x = IsPrime2(n);
            //Console.WriteLine(x);


            //30
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //double x = PrintPower(n1, n2);
            //Console.WriteLine(x);

            //31
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double r = Convert.ToDouble(Console.ReadLine());
            //double x = PrintArea(a,b,r);
            //Console.WriteLine(x);

            //32
            //int n = int.Parse(Console.ReadLine());
            //PrintNumFactorial2(n);

            //33
            //int[] arr = { 1, 2, 9, 3, 1, 0 };
            //UsingBubleMethode (arr);

            //34
            //int[] arr = { 1, 2, 9, 3, 1, 0 };
            //WriteLargestElement (arr);


            //35
            //string str = Console.ReadLine();
            //bool x = IsPalindromeString (str);
            //Console.WriteLine(x);

            //36
            //string str = Console.ReadLine();
            //PrintTextInFile(str);

            //41
            //string str = "Hi.I am C#.\nI am here that you learn much more things about me.\nI hope you like me.";
            //CalculateLinesCount(str);

            //44
            //Reanmes();

            //40
            //string str = "abb baa edd hgg ggq jja";
            //CalculateWordCount(str);

            Console.ReadLine();
        }
    }
}
