using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;

namespace Aula02RH.Models
{
    public class Funcionario //Aqui se define todas os atributos da classe.
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = "";
        public DateTime DataAdmissao { get; set; }
        public Decimal Salario { get; set; }
        public TipoFuncionarioEnum TipoFuncionario { get; set; }


        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10 / 100);
        }

        public string ExibirPeriodoExperiencia()
        {
            string periodoExperiencia = string.Format("Períodos de Experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
            return periodoExperiencia;
        }

        public decimal CalcularDescontoVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual / 100;
            return desconto;
        }

        private int ContarCaracteres(string dado)
        {
            return dado.Length;
        }

        public bool ValidarCpf()
        {
            if (ContarCaracteres(Cpf) == 11)
                return true;
            else
                return false;
        }



    }
}