namespace Aula20 {
    class Aula20 {
        static void Main(string[] args) {

            // conversao implicita de float para double

            float x = 4.5f;
            double y = x;

            double a;
            float b;

            a = 5.1;
            b = (float)a; // mensagem de erro, nao posso converter double para float, double tem 8 bytes e float 4 bytes (pode perder informacao), mesma coisa com int
            // definindo o casting, definindo a como float, sem problemas de erro

            int c = 5;
            int d = 2;

            double resultado = c / d; // vai dar resultado de 2 pois as variaveis sao valores inteiros, o correto seria colocar double na variavel 'c' e 'd'

            Console.WriteLine(y);
            Console.WriteLine(b);
            Console.WriteLine(resultado);
        }
    }
}