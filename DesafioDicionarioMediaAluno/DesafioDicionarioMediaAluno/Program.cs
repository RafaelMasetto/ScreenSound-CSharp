Dictionary<string, List<int>> alunosRegistrados = new Dictionary<string, List<int>>();

void ExibirMenuOpcoes()
{
    Console.WriteLine("Digite 1 para registrar um aluno.");
    Console.WriteLine("Digite 2 para visualizar todos os alunos registrados.");
    Console.WriteLine("Digite 3 para registrar uma nota para um aluno.");
    Console.WriteLine("Digite 4 para fazer a média de um aluno.");
    Console.WriteLine("Digite 5 para sair.");

    Console.Write("\nDigite a opção desejada: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarAluno();
            break;
        case 2: MostrarAlunosRegistrados();
            break;
        case 3: RegistrarNota();
            break;
        case 4: FazerMedia();
            break;
        case 5: Console.WriteLine("\nAté mais!");
            break;
        default: Console.WriteLine("\nOpção Inválida!");
            break;
    }
}


void RegistrarAluno()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de Aluno");
    Console.Write("\nDigite o nome do aluno que será registrado: ");
    string nomeAluno = Console.ReadLine()!;
    alunosRegistrados.Add(nomeAluno, new List<int>());
    Console.WriteLine($"\nAluno {nomeAluno} foi registrado com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuOpcoes();
}

void MostrarAlunosRegistrados()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo todos os alunos registrados.\n");
    foreach (string aluno in alunosRegistrados.Keys)
    {
        Console.WriteLine(aluno);
    }
    Console.Write("\nDigite uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuOpcoes();
}

void RegistrarNota()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de nota.");
    Console.Write("\nDigite o nome do aluno para registrar nota: ");
    string aluno = Console.ReadLine()!;
    if (alunosRegistrados.ContainsKey(aluno))
    {
        Console.Write($"\nDigite uma nota para {aluno}: ");
        int nota = int.Parse(Console.ReadLine()!);
        alunosRegistrados[aluno].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para o aluno {aluno}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenuOpcoes();
    }   else
        {
        Console.WriteLine($"\nO(A) Aluno(a) {aluno} não foi encontrado(a).");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuOpcoes();
        }
}

void FazerMedia()
{
    Console.Clear();
    ExibirTituloOpcao("Exibindo Média.");
    Console.Write("\nDigite o aluno desejado: ");
    string nomeAluno = Console.ReadLine()!;
    if (alunosRegistrados.ContainsKey(nomeAluno))
    {
        List<int> notasAluno = alunosRegistrados[nomeAluno];
        double mediaAluno = notasAluno.Average();
        Console.WriteLine($"Media: {mediaAluno}");
    }  else
       {
        Console.WriteLine($"\nO Aluno {nomeAluno} não foi encontrado.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuOpcoes();
       }
}
void ExibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);

}

ExibirMenuOpcoes();