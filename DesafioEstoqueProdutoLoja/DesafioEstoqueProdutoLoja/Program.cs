Dictionary<string, List<int>> produtosEstoque =  new Dictionary<string, List<int>>();

void ExibirMenuOpcoes()
{
    Console.WriteLine("Digite 1 para registrar um produto no estoque.");
    Console.WriteLine("Digite 2 para visualizar todos os produtos registrados no estoque.");
    Console.WriteLine("Digite 3 para registrar a quantidade de um produto em estoque.");
    Console.WriteLine("Digite 4 para visualizar todos os produtos e suas quantidades em estoque.");
    Console.WriteLine("Digite 5 para sair.");

    Console.Write("Digite a opção escolhida: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: RegistrarProduto();
            break;
        case 2: ExibirProdutosRegistrados();
            break;
        case 3: RegistrarQuantidades();
            break;
        case 4: VisualizarEstoque();
            break;
        case 5: Console.WriteLine("Até mais!");
            break;
        default: Console.WriteLine("Opção Inválida!");
            break;
    }
}

void RegistrarProduto()
{
    TituloOpcao("Registro de Produto");
    Console.Write("Digite o produto a ser registrado: ");
    string produtoRegistrado = Console.ReadLine()!;
    produtosEstoque.Add(produtoRegistrado, new List<int>());
    Console.WriteLine($"{produtoRegistrado} foi registrado com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenuOpcoes();
}

void ExibirProdutosRegistrados()
{
    TituloOpcao("Exibindo Produtos Cadastrados");
    foreach (string produtos in produtosEstoque.Keys)
    {
        Console.WriteLine(produtos);
    }
    Console.WriteLine("Pressione uma tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenuOpcoes();
}

void RegistrarQuantidades()
{
    TituloOpcao("Registro de Quantidades em Estoque");
    Console.Write("Digite qual produto terá sua quantidade alterada: ");
    string produto = Console.ReadLine()!;
    if (produtosEstoque.ContainsKey(produto))
    {
        Console.Write($"Agora insira a quantidade em estoque para {produto}: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        produtosEstoque[produto].Add(quantidade);
        Console.WriteLine("Quantidade alterada com sucesso.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenuOpcoes();
    }
    else
    {
        Console.WriteLine("Produto não registrado no estoque!");
        Console.WriteLine("Pressione uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenuOpcoes();
    }
}

void VisualizarEstoque()
{
    TituloOpcao("Exibindo Estoque");
    for (int i = 0; i < produtosEstoque.Count; i++)
    {
        Console.WriteLine($"Produto: {produtosEstoque.ElementAt(i).Key}. {produtosEstoque.ElementAt(i).Value} unidades em estoque.");
    }
    Console.ReadKey();
}

void TituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string sinalIgual = string.Empty.PadLeft(quantidadeLetras, '=');
    Console.WriteLine(sinalIgual);
    Console.WriteLine(titulo);
    Console.WriteLine(sinalIgual);
}

ExibirMenuOpcoes();