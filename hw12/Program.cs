using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1 2 8");
            //task1_2_8();
            Console.WriteLine();
            Console.WriteLine("TASK 3 9");
            //task3_9();
            Console.WriteLine();
            Console.WriteLine("TASK 4");
            //task4();
            Console.WriteLine();
            Console.WriteLine("TASK 5");
            task5();
            Console.WriteLine();
            Console.WriteLine("TASK 6");
            //task6();
            Console.WriteLine();
            Console.WriteLine("TASK 7");
            //task7();
        }

        static void task1_2_8()
        {
            Random rand = new Random();
            List<int> l = new List<int>();
            int size = 10;
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                l.Add(rand.Next(0, 100));
                if (i % 2 == 0)
                {
                    sum += l[i];
                }
                Console.Write($"{l[i]} ");
            }
            int secondMax = Int32.MinValue;
            int indexSecondMax = -1;
            Console.WriteLine();
            for(int i = 0; i < l.Count; i++)
            {
                if (secondMax < l[i] && l[i] < l.Max())
                {
                    secondMax = l[i];
                    indexSecondMax = i;
                }
            }
            Console.WriteLine($"max value: {l.Max()}\nsecond max: index {indexSecondMax}, value {secondMax}\nsum of chet index: {sum}");
            for (int i = 0; i <size;)
            {
                if (l[i] % 2 != 0)
                {
                    l.Remove(l[i]);                   
                    size--;
                    continue;
                }
                i++;
            }

            for (int i = 0; i < size; i++)
            {              
                Console.Write($"{l[i]} ");
            }
        }
        static void task3_9()
        {
            Random rand = new Random();
            List<double> l = new List<double>();
            int size = 10;
            double temp = 0;
            for (int i = 0; i < size; i++)
            {
                l.Add(rand.Next(0, 100)+ rand.Next(0, 100)/100.0);              
                Console.Write($"{l[i]} ");
            }
            temp = l.Average();
            Console.WriteLine($"\naverage value:{temp}");
            for (int i = 0; i < size; i++)
            {
               if(l[i]>temp)
                    Console.Write($"{l[i]} ");
            }
            Console.WriteLine();
        }
        static void task4()
        {
            string path = Directory.GetCurrentDirectory()+"\\test.txt";          
            StreamReader sr = new StreamReader(path,System.Text.Encoding.Default);
            string line="";          
            while ((line=sr.ReadLine())!=null)
            {
                Console.WriteLine($"original:\n{line}");
                char[] charArr = line.ToCharArray();
                Array.Reverse(charArr);
                Console.WriteLine("reverce:");
                Console.WriteLine(charArr);
            }
        }
        static void task5()
        {
            //НЕРЕАЛЬНОЕ ЗАДАНИЕ
            string s1 = "строка";
            string s2 = "акортс";
            if (s1.Length != s2.Length)
            {
                Console.WriteLine("строки не являются обратными");
                return;
            }
          
            Random rnd = new Random();
            int position = rnd.Next(0, s1.Length);
            if (s1.Substring(position, 1) == s2.Substring(s2.Length - position-1, 1))
            {
                Console.WriteLine("стоки обратны");
            }
            else
            {
                Console.WriteLine("строки не являются обратными");
            }
        }
        static void task6()
        {
            string vow = "аеёиоуыэюя";
            string text="";
            string path = Directory.GetCurrentDirectory() + "\\test2.txt";
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            text = sr.ReadToEnd();         
            Queue<string> consonantQueue = new Queue<string>();
            Console.WriteLine("Слова начинающиеся на гласную");
            string[] splitString = text.Split(new char[] { ' ', '\n' });
            for (int i = 0; i < splitString.Length; i++)
            {
                if (vow.IndexOf(splitString[i].ToCharArray()[0]) != -1)
                {
                    Console.WriteLine(splitString[i]);
                }
                else
                {
                    consonantQueue.Enqueue(splitString[i]);
                }
            }
            Console.WriteLine("\nСлова начинающиеся на согласную");        
            foreach (var item in consonantQueue)
            {
                Console.WriteLine(item);
            }                                          
        }
        static void task7()
        {
            string text;
            string path = Directory.GetCurrentDirectory() + "\\test3.txt";
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            text = sr.ReadToEnd();
            Queue<string> consonantQueue = new Queue<string>();
            Console.WriteLine("Положительные");
            string[] splitString = text.Split(new char[] { ' ', '\n' });
            for (int i = 0; i < splitString.Length; i++)
            {
                if (Int32.Parse(splitString[i])>0)
                {
                    Console.WriteLine(splitString[i]);
                }
                else
                {
                    consonantQueue.Enqueue(splitString[i]);
                }
            }
            Console.WriteLine("\nОтрицательные");
            foreach (var item in consonantQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
