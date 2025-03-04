using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    class Warrior
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Strength { get; set; }
        public Warrior(string name, int score, int strength)
        {
            Name = name;
            Score = score;
            Strength = strength;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* 1번 문제
            Warrior warrior_INFO = new Warrior("worrior", 100, 80);
            Console.WriteLine($"이름 : {warrior_INFO.Name} \n점수 : {warrior_INFO.Score}\n힘 : {warrior_INFO.Strength} ");*/
            /*   2번문제
             while (true)
            {
                string a = Console.ReadLine();
                try
                {
                    Console.WriteLine(int.Parse(a));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format Error: {ex.Message}");
                }
            }*/
            /* 3번문제
         List<string> fruit = new List<string> { };
         fruit.Add("사과"); //추가
         fruit.Add("바나나");
         fruit.Add("포도");
         foreach (var name in fruit)
         {
             Console.WriteLine(name+ " ");

         }
         Queue queue = new Queue();
         queue.Enqueue("첫번째 작업 ");
         queue.Enqueue("두번째 작업 ");
         queue.Enqueue("세번째 작업 ");

         while (queue.Count > 0)
         {
             Console.WriteLine(queue.Dequeue());
         }


         Stack<int> stack = new Stack<int>();
         stack.Push(10);
         stack.Push(20);
         stack.Push(30);
         while (stack.Count > 0)
         {
             Console.WriteLine(stack.Pop());
         }*/
            /* 4번문제
            string a = Console.ReadLine();
            
            Console.WriteLine(a.ToUpper());
            Console.WriteLine($"Replace 'C#' with 'CSharp' \n {a.Replace("C#", "CSharp")}");
            Console.WriteLine(a.Length);*/
            /* 5번문제
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = numbers.Sum();
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(result);*/
        }
    }
}
