using System;
using System.Globalization;


int numeroFuncionario, horasTrabalhadas;
double valorPorHora;

Console.WriteLine("Digite o número funcionário (**):");
numeroFuncionario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de horas trabalhadas:");
horasTrabalhadas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor que recebe por hora:");
valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double salario = horasTrabalhadas *  valorPorHora;

Console.WriteLine("Número Funcionário:" + numeroFuncionario);
Console.WriteLine("Salário: R$ " + salario.ToString("F2")); 