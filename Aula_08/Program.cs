// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    Console.WriteLine("Os filmes são: ");
    string filmes = "";
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        filmes = filmes + $"{listaDeFilmes[i]};\n";
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

Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
Console.WriteLine("------------------------\n");
Console.Write(quantidadeTotalDeFilmes());
Console.WriteLine("\n------------------------\n");
Console.WriteLine(buscarNomeDoFilmePeloIndice(2));
Console.WriteLine("\n------------------------\n");
adicionaUmNovoFilmePeloSeuNome("Enrolados");
Console.Write(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
Console.WriteLine("\n------------------------\n");