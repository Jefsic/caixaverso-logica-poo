using System;
using System.Collections.Generic;

namespace FolhaPagamento
{

    class Program
    {
        static List<Funcionario> colaborador = new List<Funcionario>();
        static double totalFolha;

        static void Main()
        {

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== SISTEMA FOLHA DE PAGAMENTO ===");

                //foram criadas variáveis para receber a resposta do usuário
                Console.WriteLine("Insira o nome do funcionário");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe a remuneração base da função:");
                double salarioBase = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o número de dias trabalhados no mês:");
                int diasTrabalhados = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a modalidade de remuneração: (1.Assalariado  2.Horista  3.Comissionado)");
                int modalidade = int.Parse(Console.ReadLine());

                //criar a variável funcionário, do tipo Funcionario, para receber a instancia criada a partir da definição
                //pelo usuário do tipo de funcionário que está sendo cadastrado: assalariado, horista ou comissionado
                //o valor null é provisório, para inicializá-la, por boa prática
                Funcionario funcionario;
                int dadoExtra = 0;

                //no list criado para armazenar os funcionários cadastrados, não vai haver nenhum objeto Funcionário instanciado
                //até porque a classe funcionário é abstrada, não é para ser instanciada.
                //eles serão criados com os objetos específicos, conforme a modalidade de remuneração, a partir da informação do usuário
                switch (modalidade)
                {
                    case 1: // Assalariado
                        funcionario = new Assalariado();
                        break;

                    case 2: // Horista
                        Console.WriteLine("Informe a quantidade de horas trabalhadas no mês:");
                        dadoExtra = int.Parse(Console.ReadLine());
                        funcionario = new Horista();
                        break;

                    case 3: // Comissionado
                        Console.WriteLine("Informe o volume total de vendas do funcionário no mês:");
                        dadoExtra = int.Parse(Console.ReadLine());
                        funcionario = new Comissionado();
                        break;

                    default:
                        Console.WriteLine("Modalidade inválida!");
                        Console.ReadLine();
                        continue; // Volta para o início do loop
                }

                // Preenche os dados usando o construtor vazio + propriedades
                funcionario.Nome = nome;
                funcionario.SalarioBase = salarioBase;
                funcionario.DiasTrabalhados = diasTrabalhados;
                funcionario.Modalidade = modalidade;
                funcionario.DadoDaModalidade = dadoExtra;

                // Chama o cálculo polimórfico
                //o nome do método é o mesmo, mas o compilador vai saber qual o método, em qual classe está
                funcionario.CalcularSalario();

                colaborador.Add(funcionario);

                Console.Clear();
                Console.WriteLine("=== FUNCIONÁRIO CADASTRADO COM SUCESSO! ===");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Modalidade: {funcionario.Modalidade}");
                Console.WriteLine($"Salário Base: {funcionario.SalarioBase:C}");
                Console.WriteLine($"Salário Final: {funcionario.SalarioFinal:C}");
                Console.WriteLine();

                // Pergunta se deseja continuar
                Console.WriteLine("Deseja cadastrar outro funcionário? (S/N)");
                string resposta = Console.ReadLine().ToUpper();
                //ToUpper, transforma a entrada em MAIÚSCULA, para o IF comparar corretamente
                if (resposta != "S")
                {
                    continuar = false;
                }
            }

            // Mostra relatório final
            Console.Clear();
            Console.WriteLine("=== RELATÓRIO FINAL ===");
            Console.WriteLine($"Total de funcionários cadastrados: {colaborador.Count}");
            Console.WriteLine();

            foreach (var func in colaborador)
            {
                //a modalidade foi gravada no inicio como int a partir da escolha do usuário: 1, 2 ou 3
                //então agora precisamos fazer o processo contrário mostrar no relatório 
                //a outra opção seria perguntar a modalidade e arricar que o usuário digitasse a modalidade...
                //qualquer erro de grafia iria trazer problemas, melhor dar opção apenas de 1, 2 ou 3
                string tipo;
                switch (func.Modalidade)
                {
                    case 1:
                        tipo = "Assalariado";
                        break;
                    case 2:
                        tipo = "Horista";
                        break;
                    case 3:
                        tipo = "Comissionado";
                        break;
                    default:
                        tipo = "Desconhecido";
                        break;
                }


                Console.WriteLine($"{func.Nome} - {tipo} - Salário: {func.SalarioFinal:C}");

                //Armazena o valor da remuneração de cada funcionário para mostrar o total no final
                totalFolha += func.SalarioFinal;
            }


            Console.WriteLine();
            Console.WriteLine($"O VALOR TOTAL DA FOLHA FOI DE: {totalFolha:C}");


            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadLine();
        }
    }
}