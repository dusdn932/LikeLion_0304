using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*//클래스 시그니처 기본구성
    //C#에서 클래스 시그니처는클래스의 선언부를 의미한다.

    //[접근지정자] [수정자] class 클래스 이름 : 부모클래스, 인터페이스
    //public        abstract                    BaseClas    ,IComparable
    //private       sealed
    //protected     static
    //              partial
    
    //기본클래스
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    //상속하는 클래스
    public class Warrior : Player
    {
        public int Starength { get; set; }
    }
    //인터페이스를 구현하는 클래스
    public class Enemy: IAttackable, IMovable
    {
        public void Attack() { }
        public void Move() { }
    }
    //추상 클래스(abstract)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            /*//enviroment
            Console.WriteLine("프로그램 종료");
            string path = Environment.GetEnvironmentVariable("PATH");
            Console.WriteLine($"PATH : {path}");
            Environment.Exit(0);*/
            /*//Random
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine("랜덤 숫자 : " + randomNumber);*/
            /*//프로그램 실행 시간 구하기
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            for(int i =0; i< 100; i++)
            {
                Thread.Sleep(10);
            }
            stopwatch.Stop();
            Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");*/
            /*//정규식 regex
            string input = "Hello, my phone number is 010-1234-5678";
            string pattern = @"\d{3}-\d{4}-\d{4}";//전화번호 패턴

            bool isMatch = Regex.IsMatch(input, pattern);
            Console.WriteLine($"전화번호가 존재하는가? {isMatch}");*/
            /*//값 형식과 참조 형식
            //값 형식은 스택에 저장되고, 참조형식은 힙에 저장됩니다.

            int valueType = 10;
            object referenceType = valueType;

            valueType = 20;
            Console.WriteLine($"ValueType : {valueType}");//20
            Console.WriteLine($"ReferenceType : {referenceType}");*/
            /*//박싱 언박싱
            //값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)
            int value = 42;
            object boxed = value;//박싱
            int unboxed = (int)boxed;//언박싱

            Console.WriteLine($"Boxed : {boxed}, Unboed : {unboxed}");*/
            /*//is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할수 있다.
            object obj = "Hello";
            Console.WriteLine(obj is string); //true
            Console.WriteLine(obj is int); //false

            var obj = 42;
            if(obj is int number)
            {
                Console.WriteLine($"Number : {number}");
            }
            else
            {
                Console.WriteLine("Not a number");
            }*/
            /*//as 연산자로 형식 변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행한다.
            object obj = "Hello";
            string str = obj as string;
            Console.WriteLine(str is string);*/
            /*//문자열 다루기
            string greeting = "Hello";
            string name = "Alice";
            string message = greeting + "," + name + "!";
            Console.WriteLine(message);
            Console.WriteLine($"Length of name : {name.Length}");//문자열 길이
            Console.WriteLine($"To.Upper:{name.ToUpper()}");//대문자 변환

            Console.WriteLine($"To.Upper:{name.ToLower()}");//소문자 변환
            Console.WriteLine($"Substring : {name.Substring(1)}");//부분문자열*/
            /*//string 다양한 메서드
            string text = "C# is awesome!";
            Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");//매칭되는게 있냐
            Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");//시작되는거
            Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");//인덱스 변환
            Console.WriteLine($"Replace 'awesome' with 'great' {text.Replace("awesome", "great")}");
            //단어 변환*/
            /*//stringBuilder
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(",");//추가해주기
            sb.Append("World!");
            Console.WriteLine(sb.ToString());*/
            /*//string 과 StringBuilder 클래스 성능 차이 비교
            //반복적으로 문자열을 수정할떄 StringBuilder 가 효율적이다.
            int iterations = 10000;
            Stopwatch sw = Stopwatch.StartNew();
            string text = "";
            for(int i = 0; i < iterations; i++)
            {
                text += "a";
            }
            sw.Stop();
            Console.WriteLine($"string : {sw.ElapsedMilliseconds}ms");
            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<iterations; i++)
            {
                sb.Append("a");
            }
            sw.Stop();
            Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");*/
            /*//예외 처리하기
            //예외는 프로그램실행 중 발생하는 오류
            //try catch 
            while (true)
            {
                try
                {
                    int[] numbers = { 1, 2, 3 };
                    Console.WriteLine(numbers[5]);//오류 발생
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
            }
            //finally 블록은 예외 발생 여부와 상관없이 항상 실행됩니다.
            while (true)
            {
                try
                {
                    int number = int.Parse("NotANumber"); //오류발생
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Format Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("항상실행됩니다.");
                }
            }*/
            /*//Exception 클래스
            //모든 예외의 기본 클래스
            try
            {
                int number = int.Parse("abc");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"General Error : {ex.Message}");
            }*/
            /*//throw 구문으로 직접 예외 발생시키기
            try
            {
                int age = -5;
                if(age < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }*/

        }
    }
}
