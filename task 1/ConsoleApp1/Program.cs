using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            foreach(var item in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}",item);
            }
            Console.WriteLine(".NET Version {0}", Environment.Version);
            Console.WriteLine("OS {0}", Environment.OSVersion);

            Console.WriteLine("Please enter your name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your Firstname: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string age = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            ConsoleColor prevcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello {0} {1}! You are {2} years old.",username,firstname,age);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = prevcolor;
            Console.WriteLine("{0}, {1}", Console.CapsLock, Console.NumberLock);
            Console.ReadLine();
            */
            //1
            string first = Console.ReadLine();
            char[] newstr = first.ToCharArray();
            Array.Reverse(newstr);
            string first1= new string (newstr);
            Console.WriteLine(first1);


            //2
            string second = Console.ReadLine();
            int numb = Convert.ToInt32(Console.ReadLine());
            char[] experim = second.ToCharArray();
            for (int i = numb-1; i <= second.Length-numb+2 ; i += numb)
            {
                experim[i]= char.ToUpper(experim[i]);
            }
            string hol = new string(experim);
            Console.WriteLine(hol);

            //3
            string second1 = Console.ReadLine();
            int numb1 = Convert.ToInt32(Console.ReadLine());
            char[] experim1 = second1.ToCharArray();
            experim1[numb1 - 1]=char.ToUpper(experim1[numb1-1]);
            Console.WriteLine(experim1);

            //4
            string st = Console.ReadLine();
            char[] st1 = st.ToCharArray();
            bool flag = true;
            for (int i = 0; i < st.Length ; i++)
            {
                if (char.IsLetter(st1[i]))
                {
                    flag = false;
                    Console.WriteLine("String contains letter(s)");
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("String consist of Numbers");

            //5
            string st5 = Console.ReadLine();
            char[] st5ch = st5.ToCharArray();
            bool flag1 = true;
            //1
            for (int i = 0, j = st5.Length - 1; i < j; i++, j--)
            { if (!st5ch[i].Equals(st5ch[j]))
                    {
                    flag1 = false; 
                    Console.WriteLine("String is not polindrom");
                    break;
                } }
            Array.Reverse(st5ch);
            string st52 = new string(st5ch);
            if (st52 != st5)
            {
                flag1 = false;
                Console.WriteLine("String is not polindrom");
            }
                if (flag1 == true) Console.WriteLine("String is polindrom");

            //6
            int num1 = Convert.ToInt32(Console.ReadLine()),
                num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 * num2);

            //7
            string har = Console.ReadLine();
            for(int i=0;i<har.Length;i++)
            {
                char[] har1 = har.ToCharArray();
                if (char.IsLetter(har1[i]))
                {
                    har=har.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(har);
            //8
            string har2 = Console.ReadLine();
            for (int i = 0; i < har2.Length; i++)
            {
                char[] har12 = har2.ToCharArray();
                if (char.IsWhiteSpace(har12[i]))
                {
                    har2 = har2.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(har2);
            Console.ReadLine();
        }
    }
}
//msdn methods runs
//console environment