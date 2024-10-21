public abstract class ItemBiblioteca{

    //propriedades comuns
    public string Titulo { get; set; }

    public string Codigo { get; set; }

    //metodos abstratos;

    public ItemBiblioteca(string titulo, string codigo)
    {
        Titulo = titulo;
        Codigo = codigo;
    }

    public abstract void Emprestar(Usuario usuario);

    public abstract void Devolver();
}