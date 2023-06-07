// Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> {"Defontes", "Metallica", "Beatles"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 7, 6 });
bandasRegistradas.Add("Iron Maiden", new List<int> { 10, 3, 4, 6 });

//Declaração da Função
void ExibirLogo()
{
    Console.WriteLine(@"     

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemDeBoasVindas); 
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nSua opção:  ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBandaRegistrada();
            break;
        case 4:
            MediaDasBandas();
            break;
        case 0:
            Console.WriteLine("Tmj lek");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar:  ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();

    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo bandas registradas");
    /*for (int i = 0; i < bandasRegistradas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/
foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristicos + "\n");
}

void AvaliarBandaRegistrada()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda\n");
    Console.Write("Digite o nome da banda que deseja avaliar:  ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota você desejar dar a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2500);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaDasBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média das bandas\n");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda]; 
        Console.WriteLine($"A média da {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!\n");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}



//Chamada da função.
ExibirOpcoesDoMenu();