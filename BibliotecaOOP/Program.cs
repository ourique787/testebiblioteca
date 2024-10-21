Biblioteca biblioteca = new Biblioteca();

Usuario usuario1 = new Usuario("Lucas", "001", "Rua José Bonifacio", "123456789");
Usuario usuario2 = new Usuario("Fogaça", "002", "Rua Barão do Rio Branco", "987654321");

biblioteca.CadastrarUsuario(usuario1);
biblioteca.CadastrarUsuario(usuario2);

Livro livro1 = new Livro("Harry Potter e a Pedra Filosofal", "001", "J.K Rowling", "123456789", "Fantasia", 5);
Livro livro2 = new Livro("Harry Potter e o Enigma do Principe", "002", "J.K Rowling", "987654321", "Fantasia", 2);


biblioteca.CadastrarLivro(livro1);
biblioteca.CadastrarLivro(livro2);


livro1.Emprestar(usuario1);
livro1.Emprestar(usuario2);


livro1.Devolver();


livro1.PesquisarPorTitulo("Harry Potter");
livro1.PesquisarPorAutor("J.K Rowling");
livro1.PesquisarPorGenero("Fantasia");


usuario1.ExibirHistorico();







