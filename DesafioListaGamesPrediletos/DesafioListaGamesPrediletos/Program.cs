//Criar uma lista vazia e adicionar elementos a lista. Utilizar a estrutura 'for' para mostrar todos os elementos da lista.

List<string> listaGamesPreferidos = new List<string>();

void ExibirLogo()
{
    Console.WriteLine("==-==-==-==-==-==-==");
    Console.WriteLine("The Top Game List");
    Console.WriteLine("==-==-==-==-==-==-==");
}

void MenuOpcoes()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para colocar um game na lista.");
    Console.WriteLine("\nDigite 2 para visualizar a lista completa.");
    Console.WriteLine("\nDigite 3 para sair.");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarGame();
            break;
        case 2:
            MostrarLista();
            break;
        case 3:
            Console.WriteLine("Até a próxima!");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarGame()
{
    Console.Clear();
    Console.Write("\nDigite o nome do game que deseja colocar na lista:");
    string nomeDoGame = Console.ReadLine()!;
    listaGamesPreferidos.Add(nomeDoGame);
    Console.WriteLine($"\nO game {nomeDoGame} foi adicionado a lista com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOpcoes();
}

void MostrarLista()
{
    Console.Clear();
    Console.WriteLine("-==-==-==-==-==-==-==-==-==-==-");
    Console.WriteLine("Sua Lista de Games Preferidos");
    Console.WriteLine("-==-==-==-==-==-==-==-==-==-==-\n");
    foreach (string game in listaGamesPreferidos)
    {
        Console.WriteLine($"Game: {game}");
    }
    Console.WriteLine("Pressione uma tecla para retornar ao menu de opções.");
    Console.ReadKey();
    Console.Clear();
    MenuOpcoes();
}


MenuOpcoes();
