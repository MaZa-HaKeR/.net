using System;

namespace task_2
{
    class Program
    {

        static void Main(string[] args)
        {
            int choose =0;
            Console.WriteLine("Input number of task(1-6):");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                First();
            }
            if (choose == 2)
            {
                Console.WriteLine("Input array dimensions: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input type data:\nint-1\nlong-2\nbyte-3");
                int type=Convert.ToInt32(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        Second(value);
                        break;
                    case 2:
                        Second(Convert.ToInt64(value));
                        break;
                    case 3:
                        Second(Convert.ToByte(value));
                        break;
                }
            }
            if (choose == 3)
            {
                int numb;
                Console.WriteLine("Input numb(1-500):");
                numb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("This numb is in massive {0} times", Thirth(numb)); ;
            }
            if (choose == 4)
            {
                Console.WriteLine("Input Date time as '{0}'",DateTime.Today);
                DateTime first = Convert.ToDateTime(Console.ReadLine());
                DateTime second = Convert.ToDateTime(Console.ReadLine());
                Forth(first,second);
            }
            if (choose == 5)
            {
                Console.WriteLine("Input Date time as '{0}'", DateTime.Today);
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("*Input* Plus or minus n days?(true - plus, false - minus)");
                bool flag=Convert.ToBoolean(Console.ReadLine());
                Fifth(date,flag);
            }
            if (choose == 6)
            {
                Console.WriteLine("Input string: ");
                string str = Console.ReadLine();
                Console.WriteLine("Input searching letter: ");
                char letter = Console.ReadLine().ToCharArray()[0];
                Console.WriteLine(Sixth(str, letter));
            }
            Console.ReadLine();
        }
        static void First()
        {
            Console.WriteLine("Ура сегодня {0}", (days)(int)DateTime.Now.DayOfWeek);
        }
        public enum days
        {
            Понедельник=1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Second(int val)
        {
            Random rand = new Random();
            int[] arr = new int[val];
            for (int i = 0; i < val; i++)
            {
                arr[i] = rand.Next(500);
            }
            int max = arr[0], min = arr[0], av = 0;
            foreach (int elem in arr)
            {
                if (elem > max) max = elem;
                if (elem < min) min = elem;
                av += elem;
            }
            Console.WriteLine("minValue = {0}\n maxValue = {1}\n Average = {2}\n", min, max, av / val);
        }
        static void Second(long val)
        {
            Random rand = new Random();
            long[] arr = new long[val];
            for (int i = 0; i < val; i++)
            {
                arr[i] = rand.Next(500);
            }
            long max = arr[0], min = arr[0], av = 0;
            foreach (int elem in arr)
            {
                if (elem > max) max = elem;
                if (elem < min) min = elem;
                av += elem;
            }
            Console.WriteLine("minValue = {0}\n maxValue = {1}\n Average = {2}\n", min, max, av / val);
        }

        static void Second(byte val)
        {
            Random rand = new Random();
            int[] arr = new int[val];
            for (int i = 0; i < val; i++)
            {
                arr[i] = rand.Next(500);
            }
            int max = arr[0], min = arr[0], av = 0;
            foreach (int elem in arr)
            {
                if (elem > max) max = elem;
                if (elem < min) min = elem;
                av += elem;
            }
            Console.WriteLine("minValue = {0}\n maxValue = {1}\n Average = {2}\n", min, max, av / val);
        }
        static int Thirth(int numb)
        {
            Random rand = new Random();
            int[] arr = new int[1000];
            int search = 0;
            for (int i = 0; i < 1000; i++)
            {
                arr[i] = rand.Next(500);
                if (arr[i].Equals(numb)) search++;
            }

            return search;
        }

        static void Forth(DateTime first, DateTime second)
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
            var timespans = (first - second).TotalSeconds;
            var timespanm = (first - second).TotalMinutes;
            var timespand = (first - second).TotalDays;
            Console.WriteLine("Seconds = {0}, minutes = {1}, days = {2}",timespans,timespanm,timespand);
        }

        static void Fifth(DateTime date, bool flag)
        {
            Random rand = new Random();
            int n = rand.Next(72, 1000);
            if (flag)
            {
                date = date.AddDays(n);
                Console.WriteLine("Date: {0}, {1}", date, date.DayOfWeek);
            }
            else
            {
                date = date.AddDays(-n);
                Console.WriteLine("Date: {0}, {1}", date, date.DayOfWeek);
            }
        }
        static int Sixth(string str,char search)
        {
            int sear = 0;
            char[] strch = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (strch[i].Equals(search)) sear++;
            }   
            return sear;
        }
    }
}
