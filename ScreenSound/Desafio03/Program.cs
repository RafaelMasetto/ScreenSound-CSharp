// Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas
// quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

List<string> listaDasOperacoes = new List<string> {"Adição", "Subtração", "Multiplicação", "Divisão" };


void MostrarListaDasOperacoes()
{
    Console.WriteLine("\n****************************");
    Console.WriteLine("Exibindo lista de operações");
    Console.WriteLine("****************************\n");

    for (int i = 0; i < listaDasOperacoes.Count; i++)
    {
        Console.WriteLine($"{i} - {listaDasOperacoes[i]}\n");
    }
}

Console.WriteLine("Vamos fazer algumas operações matemática?\n");

Console.Write("Insira o primeiro valor: ");
string valor1 = Console.ReadLine()!;
float valor1Numerico = float.Parse(valor1);
Console.Write("\nInsira o segundo valor: ");
string valor2 = Console.ReadLine()!;
float valor2Numerico = float.Parse(valor2);

MostrarListaDasOperacoes();

 int SelecionarOperacao()
{
Console.Write("Por favor selecione a operação desejada digitando seu respectivo número:");
string opcaoEscolhida = Console.ReadLine()!;
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
return opcaoEscolhidaNumerica;
}

SelecionarOperacao();

int escolhaUser = SelecionarOperacao();

float Adicao()
{
   float resultadoAdicao = valor1Numerico + valor2Numerico;
   return resultadoAdicao;
}

float Subtracao()
{
    float resultadoSubtracao = valor1Numerico - valor2Numerico;
    return resultadoSubtracao;
}

float Multiplicacao()
{
    float resultadoMultiplicacao = valor1Numerico * valor2Numerico;
    return resultadoMultiplicacao;
}

float Divisao()
{
    float resultadoDivisao = valor1Numerico /   valor2Numerico;
    return resultadoDivisao;
}


if (escolhaUser == 0)
{
    Console.WriteLine($"O Resultado dessa operação é: {Adicao()}");
}
else if (escolhaUser == 1)
{
    Console.WriteLine($"O Resultado dessa operação é: {Subtracao()}");
}
else if (escolhaUser == 2)
{
    Console.WriteLine($"O Resultado dessa operação é: {Multiplicacao}");
}
else if (escolhaUser == 3)
{
    Console.WriteLine($"O Resultado dessa operação é: {Divisao}");
}
else
{
    Console.WriteLine("Opção inválida. Por favor seleciona uma opção válida.");

}

