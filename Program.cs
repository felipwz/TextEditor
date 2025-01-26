using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que você deja fazer?");
        Console.WriteLine("1 - Abrir um arquivo");
        Console.WriteLine("2 - Criar um novo arquivo");
        Console.WriteLine("3 - Sair");
        short option;
        while (!short.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
        {
            Console.WriteLine("Digite um valor válido");
        }


        switch (option)
        {
            case 1: OpenFile(); break;
            case 2: EditFile(); break;
            case 3: Console.Clear(); Environment.Exit(0); break;
            default: Console.Clear(); Environment.Exit(0); break;
        }



    }

    static void OpenFile()
    {

    }

    static void EditFile()
    {
        Console.Clear();
        Console.WriteLine("Digite o seu texto abaixo (para sair basta pressionar ESC)");
        Console.WriteLine("--------------------");
        string text = "";


        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Save(text);



    }

    static void Save(string text)
    {
        Console.Clear();

        Console.WriteLine("Em qual caminho deseja salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.Clear();
        Console.WriteLine($"Seu arquivo {path} foi salvo com sucesso");
        Console.ReadLine();
        Menu();

    }

}
