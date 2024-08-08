using System;
using Aula02RH.Models;

namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Funcionario func = new Funcionario(); Esse é o comando que faz a criação de um Objeto no sistema.
             Além disso, aqui é onde se define os valores dos atributos.

             func.Id = 10;
             func.Nome = "GoghMarley";
             func.Cpf = "12345678910";
             func.DataAdmissao = DateTime.Parse("01/01/2000");
             func.Salario = 10000.00m; //O "M/m" serve pra definir ao compilador que a variável é Decimal. Sem isso, entende-se que a variável é Double.

             func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.Clt;  Models.Enuns serve para mostrar ao sistema onde se encontra o TipoFuncionarioEnum. Do contrário,
             seria necessário adicionar a pasta onde está o TipoFuncionário lá em cima, no using. 

             string mensagem = func.ExibirPeriodoExperiencia();
             Console.WriteLine("=============================");
             Console.WriteLine(mensagem);
             Console.WriteLine("============================="); */

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digiter a data de Admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de funcionário (1- CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1) ? Models.Enuns.TipoFuncionarioEnum.Clt : Models.Enuns.TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            Console.WriteLine("=======================================");
            Console.WriteLine($"O salário reajustado é {func.Salario}. \n");
            Console.WriteLine($"O desconto do VT é {valorDescontoVT}; \n");
            Console.WriteLine("=======================================");
        }
    }
}