using EscolaTecnica;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("== SISTEMA DE CADASTRO ESCOLAR ==");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("1 - Exibir pessoas cadastradas");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("== ESCOLHA UMA OPÇÃO ==");

                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Cadastro de Aluno");
                            Console.Write("Digite o nome do Aluno");
                            string nomeAluno = Console.ReadLine();

                            Console.Write("Digite o Curso");
                            string curso = Console.ReadLine();

                            listaPessoas.Add(new Aluno(nomeAluno, curso));
                            Console.Write("\nAluno Cadastrado com sucesso");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Cadastro de Professor");
                            Console.Write("Digite o nome do Aluno");
                            string nomeProfessor = Console.ReadLine();

                            Console.Write("Digite a Disciplina");
                            string disciplina = Console.ReadLine();

                            listaPessoas.Add(new Professor(nomeProfessor, disciplina));
                            Console.Write("\nProfessor Cadastrado com sucesso");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Lista de Cadastros");
                            if (listaPessoas.Count == 0)
                            {
                                Console.WriteLine("\nNenhum cadastro encontrado");
                            }
                            else
                            {
                                foreach (var pessoa in listaPessoas)
                                {
                                    pessoa.ExibirInfos();
                                }
                            }
                            Console.Write("\nPressione qualquer tecla para sair");
                            Console.ReadKey();
                            break;

                    }
                }
            } while (opcao != 0);

        }
        catch (Exception ex)
        {
            Console.Write($"\nErro {ex.Message}");
            Console.ReadKey();
        }
    }
}