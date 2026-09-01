namespace EscolaTecnica
{
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor (string nome, string disciplina) : base(nome)
        {
            Disciplina = disciplina;
        }

        public override void ExibirInfos()
        {
            Console.WriteLine($"PROFESSOR: {Nome} / DISCIPLINA: {Disciplina}");
        }
    }
}
