
System.Console.WriteLine("Matriz - Cardádio Estruturado");
//constante
const int row = 3;
const int col = 5;

string[,] cardapio = new string[row, col]
{
{"segunda","terça","quarta","quinta","sexta"},
{"virado","strogonf","feijoada","lazanha","bacalhau"},
{"R$21,00","R$22,00","R$23,00","R$24,00","R$25,00"}
};

double[,] preco = new string[row, col]
{
    {21,22,23,24,25}
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write($"{preco[i,j]}\t");
    }
    Console.WriteLine();
}



// System.Console.WriteLine("Matriz - Cardádio Estruturado");
// //constante
// const int row = 3;
// const int col = 5;

// string[,] cardapio = new string[row, col]
// {
// {"segunda","terça","quarta","quinta","sexta"},
// {"virado(0)","strogonf(1)","feijoada(2)","lazanha(3)","bacalhau(4)"},
// {21,22,23,24,25}
// };

// string[,] suco = new string[row, col]
// {
// {"laranja(0)","maracuja(1)","uva(2)","acerola(3)","manga(4)"},
// {7,8,9,10,11}
// };


// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < col; j++)
//     {
//         Console.Write($"{cardapio[i,j]}\t");
//     }
//     Console.WriteLine();
// }

// System.Console.WriteLine("Escolha um item do cardápio:");

// string opcao = Console.ReadLine();

// switch(opcao)
// {
//     case"1":
//     System.Console.WriteLine($"O prato escolhido foi {cardapio[1,0]} e vai custar {cardapio[2,0]}");
//     break
//     case"2":
//     System.Console.WriteLine($"O prato escolhido foi {cardapio[1,2]} e vai custar {cardapio[2,2]}");
//     break
//     case"3":
//     System.Console.WriteLine($"O prato escolhido foi {cardapio[1,3]} e vai custar {cardapio[2,3]}");
//     break
//     case"4":
//     System.Console.WriteLine($"O prato escolhido foi {cardapio[1,4]} e vai custar {cardapio[2,4]}");
//     break
            
// }
// Console.ReadKey();

// string[] pt = {"virado","strogonf","feijoada","lazanha","bacalhau"};

// switch (opcao)