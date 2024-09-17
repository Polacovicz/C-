//Sequência de escape de caracteres

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

//Para cadeia de caracteres literais
Console.WriteLine("Hello \"World\"!");

//Para exibir um cmainho de arquivo sem erro duas \\ barras invertidas.
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoices for customer \"Matusalem Company\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"    c:\source\repos
        this is where your code goes");
        Console.WriteLine(@"    c:\invoices");

// Caracteres de escape Unicode
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World");

//Para gerar chamadas em japônes
// Nihon no seikyū-sho o seisei suru ni wa:
Console.WriteLine("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// Comando para rodar a aplicação
Console.WriteLine(@"c:\invoices\app.exe -j");
