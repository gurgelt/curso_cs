namespace Aula21 {
    class Aula21 {
        static void Main(string[] args) {

            // Operadores Aritmeticos

            int n1 = 3 + 4 * 2; // resultado vai ser 11
            int n2 = (3 + 4) * 2; // resultado vai ser 14
            int n3 = 17 % 3; // resultado vai ser 2, pois e o resto da divisao
            int n4 = 10 / 8; // errado pois tem que estar como double e acrescentar o casting
            double n5 = (double)10 / 8; // colocando como casting o resultado vai dar 1.25
            double n6 = 10.0 / 8.0; // colocando numero com .0 significa que esta como double tambem

            double a = 1.0, b = -3.0, c = -4.0; // criando variaveis na mesma linha
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // b ao quadrado pode ser assim tambem -> Math.Pow(b, 2.0) ou colocar b * b
            
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Math.Sqrt é a funcao de raiz quadrada

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(delta);
            Console.WriteLine(x1);

        }
    }
}