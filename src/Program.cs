using System;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do Exercício proposto 2 da Seção 4" + Environment.NewLine);
            Console.WriteLine("Entre com os dados do funcionário");

            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Environment.NewLine + $"Funcionario: {funcionario.ToString()}");

            Console.Write(Environment.NewLine + $"Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(Environment.NewLine + $"Dados atualizados: {funcionario.ToString()}");

        }
    }
}
