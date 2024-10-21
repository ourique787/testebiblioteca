public class Biblioteca{
    public static List<Livro> Livros { get; set; } = new List<Livro>();

    public List<Usuario> Usuarios { get; set; } = new List<Usuario>();


    public void CadastrarLivro(Livro livro){
        Livros.Add(livro);
        Console.WriteLine("Livro cadastrado com sucesso!");
    }

    public void CadastrarUsuario(Usuario usuario){
        Usuarios.Add(usuario);
        Console.WriteLine("Usuário cadastrado com sucesso!");
    }

    public void EmprestarLivro(string codigoLivro, string numeroUsuario){

    }

    public void DevolverLivro(string codigoLivro){

    }

    public void ListarLivros(){
        foreach(var livro in Livros){
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Genero: {livro.Genero}, Codigo: {livro.Codigo}, ISBN: {livro.ISBN}");
        }

    }

    public void ListarUsuarios(){
        foreach(var usuario in Usuarios)
        {
            Console.WriteLine($"Nome: {usuario.Nome}, Número de Identificação: {usuario.NumeroIdentificacao}, Endereço: {usuario.Endereco} Contato: {usuario.Contato}");
        }
    }


}
