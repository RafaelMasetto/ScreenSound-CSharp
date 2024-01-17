List<int> ListaNumerosInteiros = new List<int>();

void AdicionarNumerosInteiros()
{
    Console.Clear();
    Console.Write("Digite o número que deseja adicionar a lista: ");
    string Num = Console.ReadLine()!;
    int NumNumerico = int.Parse(Num);
    ListaNumerosInteiros.Add(NumNumerico);
    Console.WriteLine($"\nO número {NumNumerico} foi adicionado a lista com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuOpcoes();
}

void ExibirListaCompleta()
{
    Console.WriteLine("Exibindo lista completa de números registrados.\n");
    foreach (int Numero in ListaNumerosInteiros) 
    {
        Console.WriteLine($"{Numero}"); 
    }
    Console.WriteLine("Pressione uma tecla para voltar ao menu de opções.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuOpcoes();
}


void ExibirMenuOpcoes()
{
    Console.WriteLine("\nDigite 1 para adicionar novos números a lista.");
    Console.WriteLine("\nDigite 2 para visualizar a lista completa.");
    Console.WriteLine("\nDigite 3 para realizar a soma de todos os números da lista.");
    Console.WriteLine("\nDigite 4 para sair.\n");
    string escolha = Console.ReadLine()!;
    int escolhaNumerica = int.Parse(escolha);

    switch (escolhaNumerica)
    {
        case 1:
            AdicionarNumerosInteiros();
            break;
        case 2:
            ExibirListaCompleta();
            break;
        case 3:
            int resultadoSoma = ListaNumerosInteiros.Sum();
            Console.WriteLine($"O resultado é {resultadoSoma}.");
            break;
        case 4:
            Console.WriteLine("Até a próxima!");
            break;
        default:
            Console.WriteLine("\nOpção Inválida!");
            ExibirMenuOpcoes();
            Console.Clear();
            break;
    }
}

    ExibirMenuOpcoes();