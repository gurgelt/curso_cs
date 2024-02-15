using System;
using System.Globalization; // necessário para puxar o CultureInfo e InvariantCulture (Linha 23)

namespace Aula18 {
    internal class Program {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Paulo";

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo:F2} reais");

            // Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); // trocar separador apenas com a concatenação

            //Testes

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(saldo);
            Console.WriteLine(idade);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // serve para delimitar as casas decimais
            Console.WriteLine(saldo.ToString("F4")); // delimita 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // vai imprimir com o ponto de separador decimais ao invés da vírgula
        }
    }
}