using System;

namespace Aula22 {
    class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine(); // comando de entrada de dados ReadLine

            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine();
            string[] vet = s.Split(' '); // vet é vetor, Split separa cada parte e forma um vetor de string (Ex: batata(0) tomate(1) abacaxi(2))
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            string[] v = Console.ReadLine().Split(' '); // Split pode ser feito desse jeito também
            string a1 = v[0];
            string a2 = v[1];
            string a3 = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(s);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
        }
    }
}