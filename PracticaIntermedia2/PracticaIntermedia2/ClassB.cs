using System;
namespace PracticaIntermedia2
{
    public class ClassB
    {
        public int Num1;
        public int Num2;
        public ClassB(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public static implicit operator ClassA(ClassB classB) => new ClassA(classB.Num1, classB.Num2);
    }
}
