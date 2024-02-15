using System;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f; // colocar 'f' no final do float
            double n6 = 4.5;
            string nome = "Paulo Gurgel";
            object obj1 = "Vivian Caroline"; // tipo genérico, aceita qualquer coisa
            object obj2 = 4.5f; // está aceitando float
            int n7 = int.MinValue; // mostra o valor mínimo do inteiro
            int n8 = int.MaxValue; // mostra o valor máximo do inteiro
            sbyte n9 = sbyte.MinValue; // mostra o valor mínimo do sbyte
            sbyte n10 = sbyte.MaxValue; // mostra o valor máximo do sbyte
            decimal n11 = decimal.MinValue; // mostra o valor mínimo do decimal
            decimal n12 = decimal.MaxValue; // mostra o valor máximo do decimal

            Console.WriteLine(genero);
            Console.WriteLine(completo);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(n12);
        }
    }
}