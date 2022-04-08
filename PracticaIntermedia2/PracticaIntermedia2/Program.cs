using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PracticaIntermedia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.- Tuples----------------------------------------------------\n");


            List<Tuple<int, int>> tupleList=new List<Tuple<int, int>>();
            tupleList.Add(new Tuple<int,int>(1,2));
            tupleList.Add(new Tuple<int, int>(3, 4));


            List<(string Name, string Kind, int Replicas, bool Run)> implicitTupleList = new List<(string Name, string Kind, int Replicas, bool Run)>();
            implicitTupleList.Add(("Juan","Humano",2,true));

            foreach(Tuple<int,int> tuple in tupleList)
            {
                Console.WriteLine("List of tuples with this int values: " + tuple.Item1 + ", "+tuple.Item2);
            }


            foreach(var tuple in implicitTupleList)
            {
                Console.WriteLine($"Tuple of (string, string, int, bool) with this values: {tuple.Name}, {tuple.Kind}, {tuple.Replicas}, {tuple.Run}");
            }


            Console.WriteLine("2.- Implicit operator----------------------------------------------------\n");

            ClassA classA = new ClassA(1, 4);
            //Operador implicito
            ClassB classB = classA;

            Console.WriteLine("ClassB Num1= " + classB.Num1 + ", Num2= " + classB.Num2) ;
            classA = classB;
            //Se manda a llamar el metodo que recive una ClassA enviandole una classB
            CheckA(classB);

            CheckB(classA);

            Console.WriteLine("3.- Value and reference ----------------------------------------------------\n");

            Person[] person = new Person[1000001];

            Animal[] animal = new Animal[1000001];
            var timerPerson = new Stopwatch();
            timerPerson.Start();
            for (int i = 0; i<= 1000000; i++)
            {
                person[i] = new Person(i, "Persona", "LastName");
            }
            timerPerson.Stop();

            TimeSpan timeTakenPerson = timerPerson.Elapsed;
            string timePerson = "Time taken to fill the Array of Person class: " + timeTakenPerson.ToString(@"m\:ss\.fff");

            Console.WriteLine(timePerson);


            var timerAnimal = new Stopwatch();
            timerAnimal.Start();
            for (int i = 0; i<= 1000000; i++)
            {
                animal[i] = new Animal(i, "Persona", "LastName");
            }
            timerAnimal.Stop();
            TimeSpan timeTakenAnimal = timerAnimal.Elapsed;
            string timeAnimal = "Time taken to fill the Array of Animal struct: " + timeTakenAnimal.ToString(@"m\:ss\.fff");
            Console.WriteLine(timeAnimal);

            Console.WriteLine("4.Queue, Lists, Dictionaries-----------------------------------------------------\n");
            //Queue----------------------------------------

            int[] a = new int[5];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;

            var timerQueue = new Stopwatch();
            timerQueue.Start();
            a = ReverseWithQueue(a);
            timerQueue.Stop();
            TimeSpan timeTakenQueue = timerQueue.Elapsed;
            string timeQueue = "Time taken to reverse the array with Queue: " + timeTakenQueue.ToString(@"m\:ss\.fff");
            Console.WriteLine(timeQueue);
            Console.WriteLine("Array reversed with Queue:");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            //List----------------------------------------

            var timerList = new Stopwatch();
            timerList.Start();
            a = ReverseWithList(a);
            timerList.Stop();
            TimeSpan timeTakenList = timerList.Elapsed;
            string timeList = "Time taken to reverse the array with Lists: " + timeTakenList.ToString(@"m\:ss\.fff");
            Console.WriteLine(timeList);
            Console.WriteLine("Array reversed with List:");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            //dictionary----------------------------------------
            var timerDictionary = new Stopwatch();
            timerDictionary.Start();
            a = ReverseWithDictionary(a);
            timerDictionary.Stop();
            TimeSpan timeTakenDictionary = timerDictionary.Elapsed;
            string timeDictionary = "Time taken to reverse the array with Dictionary: " + timeTakenDictionary.ToString(@"m\:ss\.fff");
            Console.WriteLine(timeDictionary);
            Console.WriteLine("Array reversed with Dictionary:");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("5.Stacks-----------------------------------------------------\n");

            string stringToCheck="otto";

            Console.WriteLine($"Checking if the word {stringToCheck} is palindrom: " + CheckPalindrom(stringToCheck.ToLower()));

            stringToCheck = "hola";

            Console.WriteLine($"Checking if the word {stringToCheck} is palindrom: " + CheckPalindrom(stringToCheck.ToLower()));
        }


        public static void CheckA(ClassA classA)
        {
            Console.WriteLine("ClassA Num1= " + classA.Num1 + ", Num2= " + classA.Num2);
        }
        public static void CheckB(ClassB classB)
        {
            Console.WriteLine("ClassB Num1= " + classB.Num1 + ", Num2= " + classB.Num2);
        }


        public static int[] ReverseWithQueue(int[] array)
        {
            Queue<int> inverseQueue = new Queue<int>();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                inverseQueue.Enqueue(array[i]);
            }
            //inverseQueue.Reverse();

            return inverseQueue.ToArray();
        }

        public static int[] ReverseWithList(int[] array)
        {
            List<int> InverseList = new List<int>(array);
            InverseList.Reverse();


            return InverseList.ToArray();


        }

        public static int[] ReverseWithDictionary(int[] array)
        {
            Dictionary<int, int> InverseDictionary = new Dictionary<int, int>();
            foreach(int i in array)
            {
                //InverseDictionary.Add(i, i);
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                InverseDictionary.Add(array[i],array[i]);
            }

            //InverseDictionary.

            return InverseDictionary.Values.ToArray();

        }

        public static bool CheckPalindrom(string frase)
        {
            bool isPalindrom=true;
            Stack<char> palindromo = new Stack<char>();

            foreach(char c in frase)
            {
                palindromo.Push(c);
            }
            
            for(int i = 0; i <= palindromo.Count();++i)
            {
                if(frase[i] != palindromo.Pop())
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }



    }

}
