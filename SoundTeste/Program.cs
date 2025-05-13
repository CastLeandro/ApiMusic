string mensagemDeBoasVindas = "Boas vindas ao Music Player!";
List<string> bandas = new List<string>();

void ExibirMensagemDeBoasVindas(string mensagem)
{
    Console.WriteLine("*******************--****************");
    Console.WriteLine(mensagem);
    Console.WriteLine("*******************--**************** \n");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 - para registrar uma banda");
    Console.WriteLine("Digite 2 - para listar todas as bandas");
    Console.WriteLine("Digite 3 - para exibir a média de uma banda");
    Console.WriteLine("Digite 0 - para sair \n");

    Console.WriteLine("Digite a sua opção: ");

    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);


    switch (opcaoEscolhida)
    {
        case 1:
            registrarBandas();
            break;
        case 2:
            listarBandas();
            break;
        case 3:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        case 0:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        default:
            Console.WriteLine("Erro: Opção inválida!");
            break;
    }
}

void registrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas!");
    Console.Write("Digite o Nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void listarBandas()
{   
    if(bandas.Count == 0)
    {
        Console.WriteLine("Voce ainda não registrou nenhuma banda na sua lista!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("As bandas registradas até o momento são: \n");
        foreach (string banda in bandas)
        {
            Console.WriteLine(banda);
        }

        Console.WriteLine("\nPressione alguma tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

//ExibirMensagemDeBoasVindas(mensagemDeBoasVindas);
//ExibirOpcoesDoMenu();

void teste()
{
    List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
    int soma = numeros.Sum();

    Console.WriteLine($"A soma dos números é {soma}");
}

teste();