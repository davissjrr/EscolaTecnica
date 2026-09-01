namespace EscolaTecnica
{
    class Aluno : Pessoa
    {
        public string Curso { get; set; }
        // Construtor com herança (base no C#, primo do super do Java)
        public Aluno(string nome, string curso) : base(nome)
        {
            Curso = curso;
        }

        // Método pra sobreescrever o método herdado da classe base
        public override void ExibirInfos()
        {
            Console.WriteLine($"ALUNO: {Nome} / CURSO: {Curso}");
        }

        
    }
}
