using System;
namespace PracticaIntermedia2
{
    public class ClassA
    {
        public int Num1;
        public int Num2;
        public ClassA(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public static implicit operator ClassB(ClassA classA) =>new ClassB(classA.Num1,classA.Num2);
       
    }
}
