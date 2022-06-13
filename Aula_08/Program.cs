// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string filmes = "";
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        if (i != listaDeFilmes.Length - 1)
        {
            filmes = filmes + $"{listaDeFilmes[i]}; ";
        }
        else
        {
            filmes = filmes + $"{listaDeFilmes[i]}";
        }
    }
    return filmes;
}


// 1.1. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    Console.WriteLine("A quantidade de filmes é: ");
    int total = 0;
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        total += 1;
    }

    return total;

}

// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    string filme = "";

    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        // Verifica se a letra no índice 'i' é igual à letra c.
        if (i == indiceDoFilme)
        {
            filme = listaDeFilmes[i];
        }
    }

    return filme;
}

// 1.4. Adiciona um novo filme a lista pelo seu nome.
string[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    listaDeFilmes = listaDeFilmes.Append(nomeDoFilme).ToArray();
    return listaDeFilmes;
}

// 1.5. Atualiza um filme a partir do seu índice na lista.
String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string novoFilme)
{
    listaDeFilmes[indiceDoFilme] = novoFilme;
    return listaDeFilmes;

}


// 1.6. Listar todos os filmes com seu índice/posição na lista.
string listarTodosOsFilmesComSeuIndiceNaLista()
{
    string listaFilmes = string.Empty;

    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        listaFilmes += i + " - " + listaDeFilmes[i] + "\n";
    }

    Console.WriteLine(listaFilmes);
    return listaFilmes;
}



// Retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander
Console.WriteLine($"1. Lista de todos os filmes separados por ponto e vírgula:\n {apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");
Console.WriteLine("\n------------------------\n");

// Retorna o número 6.
Console.WriteLine($"2. Retorna a quantidade de filmes da lista:\n {quantidadeTotalDeFilmes()}");
Console.WriteLine("\n------------------------\n");

// Se o índice for 0, retorna Clube dos Cinco;
Console.WriteLine($"3. Buscar um filme pelo indice: \n {buscarNomeDoFilmePeloIndice(0)}");
Console.WriteLine("\n------------------------\n");

// Se o filme for Sexta-feira 13th, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky IV; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.Write("4. Adiciona um filme pelo nome", adicionaUmNovoFilmePeloSeuNome("Sexta-feira 13th"));
Console.WriteLine($"\n {apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");
Console.WriteLine("\n------------------------\n");

// Se o índice for 3 e o nome for atualizado para Rocky III, retorna Clube dos Cinco; A Hora do Pesadelo; Karatê Kid; Rocky III; Conan, o Bárbaro; Highlander, Sexta-feira 13th
Console.WriteLine($"5. Atualizar um filme pelo seu índice: \n {string.Join(("; "), atualizarUmFilmePeloSeuIndice(3, "Rock III"))}");
Console.WriteLine("\n------------------------\n");

// Retorna 
// 0 - Clube dos Cinco 
// 1 - A Hora do Pesadelo 
// 2 - Karatê Kid
// 3 - Rocky III
// 4 - Conan, o Bárbaro
// 5 - Highlander
// 6 - Sexta-feira 13th

Console.WriteLine("6. Listar todos os filmes com seu indice/posicao na lista.");
listarTodosOsFilmesComSeuIndiceNaLista();
