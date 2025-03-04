using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //IEnumerator
    class Cup<T>
    {
        public T Content { get; set; }
    }
    //커스터마이징
    class SimpleCollection: IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach(var item in data)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*//배열과 컬렉션
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            //배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave"); //추가
            names.Remove("Bob"); //삭제
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list[1]);//원하는 위치 값 출력
            list.Insert(1, 100);//원하는 위치에 값 변경 다음값이 뒤로 밀림 {1, 2, 3} => {1, 100, 2, 3}
            list[0] = 4;
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list[1]);
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Count);*/
            /*//Stack
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }*/
            /*//Queue
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Queue queue = new Queue();
            queue.Enqueue("q");
            queue.Enqueue("w");
            queue.Enqueue("e");
            queue.Enqueue("r");
            queue.Enqueue("점멸");
            queue.Enqueue("평타");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }*/
            /*//ArrayList 생성
            //크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            ArrayList arrayList = new ArrayList();
            //요소 추가
            arrayList.Add(1);       //정수
            arrayList.Add("Hello"); //문자열
            arrayList.Add(3.14);    //실수
            //요소 접근
            Console.WriteLine("ArrayList 요소 : ");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //요소 제거
            arrayList.Remove(1);

            Console.WriteLine("\nArrayList요소 제거 후 : ");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }*/
            /*//Hashtable 클래스
            //키-값 쌍을 저장하는 컬렉션이다.
            //키를 이용해 값을 빠르게 검색
            Hashtable hashtable = new Hashtable();
            //키-값 쌍 추가
            hashtable["Alice"] = 25;
            hashtable["Bob"] = 30;
            hashtable["포션"] = 20;
            Console.WriteLine("Hashtable 요소 : ");
            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }
            //특정 키의 값 가져오기
            Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");
            hashtable.Remove("Bob");
            Console.WriteLine("Hashtable 요소 : ");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }*/
            /*// 제네릭 사용하기(Generics)
            //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들수있습니다.
            Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            Cup<int> cupOfInt = new Cup<int> {Content = 42 };
            Console.WriteLine($"CupOfString : {cupOfString.Content}");
            Console.WriteLine($"CupOfInt : {cupOfInt.Content}");*/
            /*Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Dave");


            foreach (var name in names)
            {
                Console.WriteLine(name);
            }*/
            /*//IEnumerator
            //c#컬렉션 순회 반복할수있는 인터페이스
            //IEnumerator를 사용하는 이유
            //✔ 컬렉션을 직접 제어하며 순회할 수 있음
            //✔ foreach 없이도 컬렉션 순회 가능
            //✔ LINQ나 커스텀 컬렉션을 만들 때 유용함
            ArrayList list = new ArrayList { "Apple", "Banana", "Cherry" };
            IEnumerator enumerator = list.GetEnumerator();//열거자 가져오기
            while (enumerator.MoveNext())//다음 요소가 있는지 확인
            {
                Console.WriteLine(enumerator.Current);//현재 요소 출력
            }*/
            /*//커스터마이징
            var collection = new SimpleCollection();
            foreach(var i in collection)
            {
                Console.WriteLine(i);
            }*/
            /*//Dictionary
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["금도끼"] = 10;
            ages["은도끼"] = 5;
            ages["돌도끼"] = 1;

            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/
            /*//null값
            //참조형식 null을 가질수 있으며, 값 형식은 기본적으로 null을 가질수 없습니다.
            string str = null;
            if(str == null)
            {
                Console.WriteLine("str is null");
            }
            int? nullableInt = null;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");
            nullableInt = 10;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");*/
            /*//null 값을 다루는 연산자 소개하기 ?? , ?.연산자
            //?? 연산자를 사용해 null인 경우 대체값을 제공하고, ?.dms null안전 접근을 합니다.

            string str = null;
            Console.WriteLine(str ?? "DefaultValue");//str이 null이면 DefaultValue 출력

            str = "Hello";
            Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력*/
            /*//Linq 확장메서드 형태로 제공
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리할수있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }*/
        }
    }
}
