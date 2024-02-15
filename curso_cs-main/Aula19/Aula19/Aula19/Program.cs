namespace Aula19 {
    internal class Aula19 {
        static void Main(string[] args) {

            int a = 10; // a recebe 10
            Console.WriteLine(a);

            a += 2; // a tem um incremento de 2
            Console.WriteLine(a);

            a -= 2; // a tem um decremento de 2
            Console.WriteLine(a);

            a *= 3; // a tem uma multiplicacao por 3
            Console.WriteLine(a);

            a /= 2; // a tem uma divisao por 2
            Console.WriteLine(a);

            a %= 2; // a tem o resto dividido por 2
            Console.WriteLine(a);

            string s = "ABC"; // conseguimos fazer o mesmo com strings
            Console.WriteLine(s);

            s += "DEF"; // incremento de "DEF" no s = "ABC" tendo como resultado "ABCDEF"
            Console.WriteLine(s);

            // Operadores Aritmeticos

            int b = 10;
            b++; // incremento de 1, no caso fica 10 + 1 = 11
            Console.WriteLine(b);

            int c = 10;
            c--; // decremento de 1, no caso fica 10 - 1 = 9
            Console.WriteLine(c);

            int d = 10;
            int e = d++; // dependendo do lado faz diferenca no incremento d++ ou ++d
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}