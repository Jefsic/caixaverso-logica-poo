namespace FolhaPagamento
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Modalidade { get; set; }
        public double SalarioBase { get; set; }
        public int DiasTrabalhados { get; set; }
        public int DadoDaModalidade { get; set; }
        public double SalarioFinal { get; set; }

        //o método CalcularSalário é um método abstrado, por isso deve ser criado sem parãmetros
        //ele é um método declarado, mas não implementado: obriga todas as classes filhas a implementarem sua própria versão
        //do método
        public abstract void CalcularSalario();


        //Construtor vazio: existe apenas para permitir que se crie o objeto primeiro e depois preencha as propriedades manualmente
        //criei a variável funcionario do tipo Funcionario, no arquivo program.cs
        public Funcionario() { }

        // Construtor completo para todas as propriedades
        public Funcionario(string nome, int modalidade, double salarioBase, int diasTrabalhados, int dadoDaModalidade)
        {
            Nome = nome;
            Modalidade = modalidade;
            SalarioBase = salarioBase;
            DiasTrabalhados = diasTrabalhados;
            DadoDaModalidade = dadoDaModalidade;
        }
    }
}