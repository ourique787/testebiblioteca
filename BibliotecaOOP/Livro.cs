public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int quantidadeEmEstoque)
        : base(titulo, codigo)
    {
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            usuario.AdicionarLivroEmprestimo(this);
            Console.WriteLine($"O livro {Titulo} foi emprestado ao usuário {usuario.Nome}");
        }
        else
        {
            Console.WriteLine("O livro não está disponível em nosso estoque");
        }
    }

    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"Livro {Titulo} devolvido ao estoque.");
    }

    
    public void PesquisarPorTitulo(string titulo)
    {
        Console.WriteLine($"Resultados da pesquisa por título '{titulo}':");
        foreach (var livro in Biblioteca.Livros)
        {
            if (livro.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, ISBN: {livro.ISBN}");
            }
        }
    }

    public void PesquisarPorAutor(string autor)
    {
        Console.WriteLine($"Resultados da pesquisa por autor '{autor}':");
        foreach (var livro in Biblioteca.Livros)
        {
            if (livro.Autor.IndexOf(autor, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, ISBN: {livro.ISBN}");
            }
        }
    }

    public void PesquisarPorGenero(string genero)
    {
        Console.WriteLine($"Resultados da pesquisa por gênero '{genero}':");
        foreach (var livro in Biblioteca.Livros)
        {
            if (livro.Genero.IndexOf(genero, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Código: {livro.Codigo}, ISBN: {livro.ISBN}");
            }
        }
    }
}
    