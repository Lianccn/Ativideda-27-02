using Ativideda_27_02;


while (true)
{
    
    Console.WriteLine("\n==========================================================================================\n");
    Console.WriteLine
        (
        "Opção 1:\tJogo de Boca\n" +
        "Opção 2:\tGasto de Combustível\n" +
        "Opção 3:\tIntervalo\n" +
        "Opção 4:\tMédia 2"
        );
    Console.WriteLine("Escolha a opção:\t");
    var opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("\n==========================================================================================\n");
        Console.WriteLine("Jogo de Boca");
        Console.WriteLine("Valor de N");
        var n = int.Parse(Console.ReadLine());

        Boca res = new Boca();
        res.Solucao1(n);
    }
    else if (opcao == 2)
    {
        Console.WriteLine("\n==========================================================================================\n");
        Console.WriteLine("Gasto de Combutível");

        Console.WriteLine("Tempo gasto em horas:");
        var nn = int.Parse(Console.ReadLine());

        Console.WriteLine("Velocidade média em km/h:");
        var nb = int.Parse(Console.ReadLine());

        GastoCombustivel gasto = new GastoCombustivel();
        gasto.Solucao2(nn,nb);
        Console.WriteLine(gasto);
    }
    else if (opcao == 3)
    {
        Console.WriteLine("\n==========================================================================================\n");
        Console.WriteLine("Intervalo");
        Console.WriteLine("Numero:");
        var nc = float.Parse(Console.ReadLine());

        Intervalo entre = new Intervalo();
        entre.Solucao3(nc);
    }
    else if (opcao == 4)
    {
        Console.WriteLine("\n==========================================================================================\n");
        Console.WriteLine("Média 2");

        Console.WriteLine("Valor A");
        var a = float.Parse(Console.ReadLine());

        Console.WriteLine("Valor B");
        var b = float.Parse(Console.ReadLine());

        Console.WriteLine("Valor C");
        var c = float.Parse(Console.ReadLine());

        Media2 media = new Media2();
        media.Solucacao4(a,b,c);
    }
    else
    {
        Console.WriteLine("Opção invalia");
    }
    Console.ReadKey();
    Console.Clear();
    
}
