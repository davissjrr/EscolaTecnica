namespace EscolaTecnica
{
    // classe abstrata, serve como molde base pra não ser possível de se instanciada
    class Pessoa
    {
        private string nome;
        
        public string Nome { get { return nome; } set { nome = value; } }

        // Construtor da classe pra inicializar o atributo nome
        public Pessoa (string nome)
        {
            Nome = nome;
        }

        // Método Virtual (Polimorfismo) - definição de um comportamento passível de ser sobreescrito
        public virtual void ExibirInfos()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }

    
}
