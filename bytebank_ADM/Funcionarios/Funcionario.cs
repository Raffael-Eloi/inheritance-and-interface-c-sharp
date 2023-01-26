using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        // Method that can be override
        public abstract double GetBonificacao();

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Cpf += salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
    }
}
