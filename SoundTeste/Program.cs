using System.Data;

string mensagemDeBoasVindas = "Boas vindas ao Music Player!";
//List<string> bandas = new List<string>();

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Linkin Park", new List<int>() {10, 8 });
bandas.Add("The Beatles", new List<int>());

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
    Console.WriteLine("Digite 3 - para dar nota a uma banda");
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
            avaliarUmaBanda();
            break;
        case 0:
            Console.WriteLine($"voce digitou a opcao: {opcao}");
            break;
        default:
            Console.WriteLine("Erro: Opção invál!");
            break;
    }
}

void registrarBandas()
{
    Console.Clear();
    exibirTituloOpcao("Registro Das bandas!");
    Console.Write("Digite o Nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void listarBandas()
{
    exibirTituloOpcao("Listagem de bandas registradas");
    if (bandas.Keys.Count == 0)
    {
        Console.WriteLine("Voce ainda não registrou nenhuma banda na sua lista!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("As bandas registradas até o momento são: \n");
        foreach (string banda in bandas.Keys)
        {
            Console.WriteLine(banda);
        }

        Console.WriteLine("\nPressione alguma tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
void avaliarUmaBanda()
{
    Console.Clear();
    exibirTituloOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    string pesquisa = bandas
        .Where(b => b.Key.StartsWith(nomeDaBanda))
        .Select(b => b.Key)
        .FirstOrDefault() ?? "Banda não encontrada";

    if (pesquisa != "Banda não encontrada")
    {
        Console.Write($"Qual a nota que a banda {pesquisa} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[pesquisa].Add(nota);
        Console.WriteLine($"A nota para a banda {pesquisa} foi registrada com sucesso!");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não existe! ");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}
void exibirTituloOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = "".PadLeft(quantidadeDeLetras, '*');

    Console.Write($"{asteriscos}\n{titulo}\n{asteriscos}\n");
}

ExibirMensagemDeBoasVindas(mensagemDeBoasVindas);
ExibirOpcoesDoMenu();
