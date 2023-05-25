/*
//exercicio1

Console.WriteLine("Meu 1º programa console ");

string nome = "Wil";
int idade = 42;

System.Console.WriteLine("Me chamo "+nome+" e tenho "+idade+" anos de idade");

Console.ReadKey();


//exercicio2
Console.WriteLine("Soma simples");
int v1, v2, result;
v1 = 5;
v2 = 6;
result = v1 + v2;
System.Console.WriteLine(result);

Console.ReadKey();

//exercicio3
Console.WriteLine("cálculo de média simples");
//instrucoes
//declarando as variaveis
double n1, n2, n3, n4, media;
const double parametro = 6.0;
n1 = 8.0;
n2 = 5.5;
n3 = 6.5;
n4 = 9.5;
media = (n1+n2+n3+n4)/4;
//mensagens
string ap = "Aprovado";
string rp = "Reprovado";
string situacao = media>=parametro?ap:rp;
System.Console.WriteLine("a média é "+media+" e o aluno está "+situacao);
Console.ReadKey();

//exercicio4
Console.WriteLine("Cálculo de área Traspézio");
//instrucoes
//declaracao de variaveis
float b,B,h,area;
B = 8.0f;
b = 6.0f;
h = 5f;
const float n = 2f;
area = (B+b)*h/n;

System.Console.WriteLine("a área do trapezio é "+area);

Console.ReadKey();

//exercicio5
Console.WriteLine("Casting");
//instrucoes
//declaracao de variaveis
Console.Write("Digite o 1º numero inteiro: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o 2º numero inteiro: ");
int n2 = int.Parse(Console.ReadLine());

double result = n1/n2;

System.Console.WriteLine(result);

Console.ReadKey();

//exercicio6
Console.WriteLine("if else simples");
//instrucoes
//declaracao de variaveis
System.Console.Write("Que h são?");
int h = int.Parse(Console.ReadLine());

if (h <=12)
{
    System.Console.WriteLine("Bom Dia !");
}
else if (h >12 && h<=18)
{
    System.Console.WriteLine("Bom Tarde !");
}
else
{
     System.Console.WriteLine("Boa Noite !");
}

Console.ReadKey();

//exercicio7
Console.WriteLine("Cadastro simples if else");
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
string idade = Console.ReadLine();

Console.Write("Digite seu email: ");
string email = Console.ReadLine();

Console.Write("Digite seu login: ");
string login = Console.ReadLine();

Console.Write("Digite sua senha com 6 digitos: ");
string senha = Console.ReadLine();


Console.WriteLine("AUTENTICAÇÃO");

Console.Write("Digite seu login: ");
string login2 = Console.ReadLine();

Console.Write("Digite sua senha: ");
string senha2 = Console.ReadLine();

if (login == login2 && senha == senha2)
{
    Console.WriteLine($"{nome} seu acesso está liberado !! em {DateTime.Now}");
}
else
{
    Console.WriteLine($"{nome} seu acesso está negado !! em {DateTime.Now}");
}

Console.ReadKey();

//exercicio8
Console.WriteLine("Cálculo de pagamento");
System.Console.WriteLine("valor do boleto R$ 1.500,00");
//declarando variaveis
double boleto = 1500.00;
double result;

//pegando as informações do usuario
System.Console.WriteLine("Escolha a opção de pagamento:");
System.Console.WriteLine("(1) a vista\n(2) parcelado 2x\n(3) parcelado 3x");
int opcao;
int.TryParse(Console.ReadLine(),out opcao);

//estrutura condicional
if (opcao == 1)
{
    result = boleto;
    System.Console.WriteLine($"O pagamento será a vista no valor de {result.ToString("c")}");
}
else if (opcao == 2)
{
    result = boleto/2;
    System.Console.WriteLine($"O pagamento será parcelado em 2x no valor de {result.ToString("c")} por parcela");
}
else if (opcao == 3)
{
    result = boleto/3;
    System.Console.WriteLine($"O pagamento será parcelado em 3x no valor de {result.ToString("c")} por parcela");
}
else
{
System.Console.WriteLine("Opção inválida !!");
}
Console.ReadKey();


//exercicio9
Console.WriteLine("Empréstimos");
_etq:
System.Console.Write("Digite o valor a ser emprestado a partir de R$ 1.000,00 => ");
//declarando variaveis
double valor = double.Parse(Console.ReadLine());
const double parametro = 1000.00;
double result;
if (valor < parametro)
{
    System.Console.WriteLine("Valor abaixo do permitido !");
goto _etq;
}

_etq2:
System.Console.WriteLine("Selecione uma opção para pagamento:\n(1) a vista - desconto de 5%\n(2) parcelado em 4x - juros de 18%\n(3) parcelado em 12 x - juros de 62%");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        result = valor * 0.95;
        System.Console.WriteLine($"pagamento a vista com 5% de desconto - parcela única de {result.ToString("c")}");
        break;
    case "2":
        result = (valor * 1.18) / 4;
        System.Console.WriteLine($"pagamento parcelado em 4 x - parcelas de {result.ToString("c")}");
        break;
    case "3":
        result = (valor * 1.62) / 12;
        System.Console.WriteLine($"pagamento parcelado em 12 x - parcelas de {result.ToString("c")}");
        break;

    default:
        System.Console.WriteLine($"Opção inválida !!");
        goto _etq2;
        //break;


}

Console.ReadKey();

//exercicio 10
Console.WriteLine("Array básico");
//criando nosso array
int[] numeros = new int[5];

//preenchendo nosso array
numeros[0] = 6;
numeros[1] = 4;
numeros[2] = 15;
numeros[3] = 11;
numeros[4] = 2;

System.Console.WriteLine($"eu sou o nº {numeros[1]}");

Console.ReadKey();


//exercicio 11
Console.WriteLine("Array básico");
//criando nosso array forma 1
string[] meuArray = new string[3];
meuArray[0] = "Uil";
meuArray[1] = "Robsu";
meuArray[2] = "Soraio";

//criando nosso array forma 2
string[] otroArray = new string[3]{"Maria","Ana","Cléo"};

//criando nosso array forma 3
string[] maisOtroArray = {"Mario","Ano","Lia","Gia","Manoel","Jéssica"};

System.Console.WriteLine($"Valor da posição 3 é {meuArray[2]}");
System.Console.WriteLine($"Valor da posição 2 é {otroArray[1]}");
System.Console.WriteLine($"Valor da posição 6 é {maisOtroArray[5]}");

Console.ReadKey();

//exerciocio 12
Console.WriteLine("Comandos básicos com Array");
//obtendo o tamanho do array
string[]meuArray = {"Uil","Robsu","Bia","Camila"};
System.Console.WriteLine($"O tamanho do array é {meuArray.Length}");

System.Console.WriteLine($"O tamanho do array é {meuArray.Count()}");

Console.ReadKey();

//exerciocio13
Console.WriteLine("Comandos básicos com Array");
//obtendo média aritmética do array
int[] n = {5,10,15};
System.Console.WriteLine($"A média dos valores é {n.Average()}");

//obtendo a soma aritmética do array
System.Console.WriteLine($"A soma dos valores é {n.Sum()}");

Console.ReadKey();

//exercicio 13
Console.WriteLine("Comandos básicos com Array");
//obtendo a posição do valor no array
int[] n ={1500,12,120,32,14,456,16,177,80,19};


int indice = Array.IndexOf(n,14);

System.Console.WriteLine($"O índice do nº escolhido é {indice}");

Console.ReadKey();

//exerciocio 14
Console.WriteLine("Array - Vetor");
System.Console.WriteLine("Lanches Imundos");
//declarando meus arrays
//enunciado array de escolhas
string[] e = {"(1) ","(2) ","(3) ","(4) ","(5)"};
//array de lanches
string[] l = {"Xsalada","Xovo","Xbanana","Xtudo","Xnada"};
//array de peços
double[] p = {20.0,15.0,12.5,8.5,15.9};

//mensagem
string msg = "Opção inválida !!";

_etq:
//solicitar a escolha ao usuario
System.Console.WriteLine($"Escolha um lanche:\n{e[0]} - {l[0]} - {p[0].ToString("c")} \n{e[1]} - {l[1]} - {p[1].ToString("c")}\n{e[2]} - {l[2]} - {p[2].ToString("c")}\n{e[3]} - {l[3]} - {p[3].ToString("c")}\n{e[4]} - {l[4]} - {p[4].ToString("c")}");

string opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
    System.Console.WriteLine($"O lanche escolhido foi {l[0]} - {p[0].ToString("c")}");
    break;
     case "2":
    System.Console.WriteLine($"O lanche escolhido foi {l[1]} - {p[1].ToString("c")}");
    break;
     case "3":
    System.Console.WriteLine($"O lanche escolhido foi {l[2]} - {p[2].ToString("c")}");
    break;
     case "4":
    System.Console.WriteLine($"O lanche escolhido foi {l[3]} - {p[3].ToString("c")}");
    break;
     case "5":
    System.Console.WriteLine($"O lanche escolhido foi {l[4]} - {p[4].ToString("c")}");
    break;
    default:
        System.Console.WriteLine(msg);
       goto _etq;

}

Console.ReadKey();

//exercicio 15
Console.WriteLine("Array - Vetor");
System.Console.WriteLine("Lanches Imundos");
//declarando meus arrays
//enunciado array de escolhas
string[] e = { "(1) ", "(2) ", "(3) ", "(4) ", "(5)" };
//array de lanches
string[] l = { "Xsalada", "Xovo", "Xbanana", "Xtudo", "Xnada" };
//array de peços
double[] p = { 20.0, 15.0, 12.5, 8.5, 15.9 };
//preço do suco
double suco = 8.0;
double total;
//mensagem
string msg = "Opção inválida !!";

_etq:
//solicitar a escolha ao usuario
System.Console.WriteLine($"Escolha um lanche:\n{e[0]} - {l[0]} - {p[0].ToString("c")} \n{e[1]} - {l[1]} - {p[1].ToString("c")}\n{e[2]} - {l[2]} - {p[2].ToString("c")}\n{e[3]} - {l[3]} - {p[3].ToString("c")}\n{e[4]} - {l[4]} - {p[4].ToString("c")}");

string opcao = Console.ReadLine();
switch (opcao)
{
    case "1":
    _etq1:
        System.Console.WriteLine($"O lanche escolhido foi {l[0]} - {p[0].ToString("c")}\nDeseja acrescentar um suco por + {suco.ToString("c")} ?\n(1) SIM\n(2) NÃO");
        string opcaoSuco0 = Console.ReadLine();
        if (opcaoSuco0 == "1")
        {
            total = suco + p[0];
            System.Console.WriteLine($"Lanche: {l[0]} - {p[0].ToString("c")}\nSuco: {suco.ToString("c")}\nTotal: {total.ToString("c")}");
        }
        else if (opcaoSuco0 == "2")
        {
            System.Console.WriteLine($"Lanche: {l[0]} - {p[0].ToString("c")}");
        }
        else
        {
            System.Console.WriteLine($"Opção inválida !!");
            goto _etq1;
        }
        break;
    case "2":
     _etq2:
        System.Console.WriteLine($"O lanche escolhido foi {l[1]} - {p[1].ToString("c")}\nDeseja acrescentar um suco por + {suco.ToString("c")} ?\n(1) SIM\n(2) NÃO");
        string opcaoSuco1 = Console.ReadLine();
        if (opcaoSuco1 == "1")
        {
            total = suco + p[1];
            System.Console.WriteLine($"Lanche: {l[1]} - {p[1].ToString("c")}\nSuco: {suco.ToString("c")}\nTotal: {total.ToString("c")}");
        }
        else if (opcaoSuco1 == "2")
        {
            System.Console.WriteLine($"Lanche: {l[1]} - {p[1].ToString("c")}");
        }
        else
        {
            System.Console.WriteLine($"Opção inválida !!");
            goto _etq2;
        }
        break;
    case "3":
    _etq3:
        System.Console.WriteLine($"O lanche escolhido foi {l[2]} - {p[2].ToString("c")}\nDeseja acrescentar um suco por + {suco.ToString("c")} ?\n(1) SIM\n(2) NÃO");
        string opcaoSuco2 = Console.ReadLine();
        if (opcaoSuco2 == "1")
        {
            total = suco + p[2];
            System.Console.WriteLine($"Lanche: {l[2]} - {p[2].ToString("c")}\nSuco: {suco.ToString("c")}\nTotal: {total.ToString("c")}");
        }
        else if (opcaoSuco2 == "2")
        {
            System.Console.WriteLine($"Lanche: {l[2]} - {p[2].ToString("c")}");
        }
        else
        {
            System.Console.WriteLine($"Opção inválida !!");
            goto _etq3;
        }
        break;
    case "4":
    _etq4:
        System.Console.WriteLine($"O lanche escolhido foi {l[3]} - {p[3].ToString("c")}\nDeseja acrescentar um suco por + {suco.ToString("c")} ?\n(1) SIM\n(2) NÃO");
        string opcaoSuco3 = Console.ReadLine();
        if (opcaoSuco3 == "1")
        {
            total = suco + p[3];
            System.Console.WriteLine($"Lanche: {l[3]} - {p[3].ToString("c")}\nSuco: {suco.ToString("c")}\nTotal: {total.ToString("c")}");
        }
        else if (opcaoSuco3 == "2")
        {
            System.Console.WriteLine($"Lanche: {l[3]} - {p[3].ToString("c")}");
        }
        else
        {
            System.Console.WriteLine($"Opção inválida !!");
            goto _etq4;
        }
        break;
    case "5":
    _etq5:
        System.Console.WriteLine($"O lanche escolhido foi {l[4]} - {p[4].ToString("c")}\nDeseja acrescentar um suco por + {suco.ToString("c")} ?\n(1) SIM\n(2) NÃO");
        string opcaoSuco4 = Console.ReadLine();
        if (opcaoSuco4 == "1")
        {
            total = suco + p[4];
            System.Console.WriteLine($"Lanche: {l[4]} - {p[4].ToString("c")}\nSuco: {suco.ToString("c")}\nTotal: {total.ToString("c")}");
        }
        else if (opcaoSuco4 == "2")
        {
            System.Console.WriteLine($"Lanche: {l[4]} - {p[4].ToString("c")}");
        }
         else
        {
            System.Console.WriteLine($"Opção inválida !!");
            goto _etq5;
        }
        break;
    default:
        System.Console.WriteLine(msg);
        goto _etq;

}

Console.ReadKey();



//exercicio 16

//bhaskara
Console.WriteLine("Bhaskara");
Console.Write("Digite o valor de a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de c: ");
double c = double.Parse(Console.ReadLine());

double delta = Math.Pow(b, 2) - (4 * a * c);

double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine("O valor de delta é: " + delta.ToString("0.00") + " , o valor de x1 é: " + x1.ToString("0.00") + " e o valor de x2 é: " + x2.ToString("0.00"));
Console.ReadKey();


//exerciocio 17
Console.WriteLine("Maior número");
Console.Write("Digite o valor de a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Digite o valor de b: ");
double b = double.Parse(Console.ReadLine());

if (a>b)
{
  
    System.Console.WriteLine($"o maior numero é {a}");
}
else if(b>a)
{
        System.Console.WriteLine($"o maior numero é {b}");

}else
{
        System.Console.WriteLine($"os nº são iguais");

}

Console.ReadKey();


//exerciocio 18
Console.WriteLine("estrutura de repetição - while");
int n1, n2;
n1 = 10;
n2 = 0;
while (n1>n2)
{
 n2++;       
System.Console.WriteLine(n2);
}

Console.ReadKey();


//exercicio19
Console.WriteLine("estrutura de repetição - for");
string[] nomes = {"jania","paula","bia"};
for (int i = 0; i < nomes.Length; i++)
{
   System.Console.WriteLine(nomes.Length);     
   System.Console.WriteLine($"posição {i} - {nomes[i]}");     
}

Console.ReadKey();



//exercicio20
Console.WriteLine("estrutura de repetição - for");
//declarando minha coleção
string[] n = new string[10];

for (int i = 0; i < n.Length; i++)
{
    System.Console.Write($"Coloque um nome na {i + 1}ª posição da coleção: ");
    n[i] = Console.ReadLine();
}
_etq1:
System.Console.WriteLine($"Deseja imprimir a lista de nomes?\n(1) Sim\n(2) Não");
string result = Console.ReadLine();

switch (result)
{
    case "1":
        for (int i = 0; i < n.Length; i++)
        {
            System.Console.Write($"O {i + 1}º nome da lista é: {n[i]}\n");
        }
        break;

    case "2":
        System.Console.WriteLine("A lista não será impressa na tela, tecle qualquer tecla para encerrar...");
        break;

    default:
        System.Console.WriteLine("Opção inválida !!");
        goto _etq1;

}


Console.ReadKey();


//exerciocio21
System.Console.WriteLine("Lista de nomes");
//declarando a lista
//(1) sim | (2) não
List<string> lista = new List<string>();
string opcao = "1";
while (opcao == "1")
{
    System.Console.Write("Digite um nome para inserir na lista: ");
    string nome = Console.ReadLine();
    lista.Add(nome);
_etq1:
    System.Console.WriteLine("Deseja inserir outro nome à lista?\n(1) sim | (2) não");
    opcao = Console.ReadLine();
    if (opcao != "1" && opcao != "2")
    {
        System.Console.WriteLine("Opção inválida !!");
        goto _etq1;
    }
}
_etq2:
System.Console.WriteLine($"A lista tem {lista.Count} itens,\ndeseja imprimí-los?\n(1) sim | (2) não");
opcao = Console.ReadLine();
if (opcao != "1" && opcao != "2")
{
    System.Console.WriteLine("Opção inválida !!");
    goto _etq2;
}
else if (opcao == "1")
{
    // foreach (var item in lista)
    // {
    //     System.Console.WriteLine(item);
    // }

    lista.ForEach(i=>Console.WriteLine(i));

}
else
{
    System.Console.WriteLine("Passar bem... tecle qualquer tecla para encerrar...");
}

Console.ReadKey();


//exercicio22
System.Console.WriteLine("Matriz - boletim escolar");

string[,] boletim = new string[3,4];
// 1ª forma de preenchimento
// 1ª linha - cabeçalho
boletim[0,0] = "Prova1";
boletim[0,1] = "Prova2";
boletim[0,2] = "Prova3";
boletim[0,3] = "Prova4";

// 2ª linha - valores
boletim[1,0] = "10,0";
boletim[1,1] = "8,5";
boletim[1,2] = "7,5";
boletim[1,3] = "6,5";

// 3ª linha - valores
boletim[2,0] = "8,5";
boletim[2,1] = "9,5";
boletim[2,2] = "8,5";
boletim[2,3] = "7,5";

// imprimindo a Matriz
// 1ª forma de impressão
Console.WriteLine($"{boletim[0,0]}\t{boletim[0,1]}\t{boletim[0,2]}\t{boletim[0,3]}\t\n{boletim[1,0]}\t{boletim[1,1]}\t{boletim[1,2]}\t{boletim[1,3]}\t\n{boletim[2,0]}\t{boletim[2,1]}\t{boletim[2,2]}\t{boletim[2,3]}\t\n");


//exercicio23
System.Console.WriteLine("Matriz - boletim escolar");

// 2ª forma de preenchimento
string[,] boletim = new string[3, 4]
{
{"prova1","prova2","prova3","prova4"},
{"10,0","8,5","7,0","6,5"},
{"6,5","7,5","9,0","8,5"}
};


// imprimindo a Matriz
// 2ª forma de impressão
Console.WriteLine($"{boletim[0, 0]}\t{boletim[0, 1]}\t{boletim[0, 2]}\t{boletim[0, 3]}\t\n{boletim[1, 0]}\t{boletim[1, 1]}\t{boletim[1, 2]}\t{boletim[1, 3]}\t\n{boletim[2, 0]}\t{boletim[2, 1]}\t{boletim[2, 2]}\t{boletim[2, 3]}\t\n");



//exerciocio24
System.Console.WriteLine("Matriz - boletim escolar");
//constante
const int row = 3;
const int col = 4;

// 3ª forma de preenchimento
string[,] boletim = new string[row, col]
{
{"prova1","prova2","prova3","prova4"},
{"10,0","8,5","7,0","6,5"},
{"6,5","7,5","9,0","8,5"}
};


// imprimindo a Matriz
// 3ª forma de impressão
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
      Console.Write($"{boletim[i,j]}\t"); 
    }
    Console.WriteLine();
}


//exercicio25

System.Console.WriteLine("Cardápio");

//declaração de constantes
const int rowNomes = 2;
const int colNomes = 7;
const int rowValores = 2;
const int colValores = 7;

//linhna de cabeçalho do menu
string[] data = new string[]
{
"2ª feira","3ª feira","4ª feira","5ª feira","6ª feira","Sábado","Domingo"
};

//1ª matriz string
string[,] Nomes = new string[rowNomes, colNomes];
//linha1 - nomes dos pratos
Nomes[0, 0] = "(1) - Comercial";
Nomes[0, 1] = "(2) - Macarronada";
Nomes[0, 2] = "(3) - Virado";
Nomes[0, 3] = "(4) - Peixe";
Nomes[0, 4] = "(5) - Feijoada";
Nomes[0, 5] = "(6) - Churrasco";
Nomes[0, 6] = "(7) - Filé";

//linha2 - nomes dos sucos
Nomes[1, 0] = "(1) - Suco Uva";
Nomes[1, 1] = "(2) - Suco Maçã";
Nomes[1, 2] = "(3) - Suco Pêra";
Nomes[1, 3] = "(4) - Suco Abacate";
Nomes[1, 4] = "(5) - Suco Limão";
Nomes[1, 5] = "(6) - Suco Abacaxi";
Nomes[1, 6] = "(7) - Suco Cupuaçú";


//2ª matriz double
double[,] Valores = new double[rowValores, colValores];
//linha1 - valores dos sucos
Valores[0, 0] = 30;
Valores[0, 1] = 32;
Valores[0, 2] = 35;
Valores[0, 3] = 38;
Valores[0, 4] = 42;
Valores[0, 5] = 50;
Valores[0, 6] = 52;

//linha2 - valores dos sucos
Valores[1, 0] = 15;
Valores[1, 1] = 12;
Valores[1, 2] = 15;
Valores[1, 3] = 12;
Valores[1, 4] = 12;
Valores[1, 5] = 16;
Valores[1, 6] = 12;

System.Console.WriteLine();
//imprimindo dados na tela
for (int i = 0; i < rowNomes; i++)
{
    for (int j = 0; j < colNomes; j++)
    {
        Console.WriteLine($"{data[j]}{Nomes[i, j]} - {Valores[i, j].ToString("c")}");
    }
    Console.WriteLine();

}
//oferecendo as opções de menu
_etq0:
Console.WriteLine("Escolha seu prato:");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
    _etq1:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 0]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 0]}\nO suco do dia é {Nomes[1, 0]}\nTotal - {(Valores[0, 0] + Valores[1, 0]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 0]}\nTotal - {Valores[0, 0].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq1;
        }

        break;



    case "2":
    _etq2:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 1]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 1]}\nO suco do dia é {Nomes[1, 1]}\nTotal - {(Valores[0, 1] + Valores[1, 1]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 1]}\nTotal - {Valores[0, 1].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq2;
        }

        break;




    case "3":
    _etq3:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 2]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 2]}\nO suco do dia é {Nomes[1, 2]}\nTotal - {(Valores[0, 2] + Valores[1, 2]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 2]}\nTotal - {Valores[0, 2].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq3;
        }

        break;



    case "4":
    _etq4:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 3]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 3]}\nO suco do dia é {Nomes[1, 3]}\nTotal - {(Valores[0, 3] + Valores[1, 3]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 3]}\nTotal - {Valores[0, 3].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq4;
        }

        break;



    case "5":
    _etq5:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 4]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 4]}\nO suco do dia é {Nomes[1, 4]}\nTotal - {(Valores[0, 4] + Valores[1, 4]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 4]}\nTotal - {Valores[0, 4].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq5;
        }

        break;



    case "6":
    _etq6:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 5]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 5]}\nO suco do dia é {Nomes[1, 5]}\nTotal - {(Valores[0, 5] + Valores[1, 5]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 5]}\nTotal - {Valores[0, 5].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq6;
        }

        break;



    case "7":
    _etq7:
        System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 6]}\nDeseja acrescentar o suco do dia?\n(1) Sim | (2) Não");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 6]}\nO suco do dia é {Nomes[1, 6]}\nTotal - {(Valores[0, 6] + Valores[1, 6]).ToString("c")} ");
        }
        else if (opcao == "2")
        {
            System.Console.WriteLine($"O prato escolhido foi {Nomes[0, 6]}\nTotal - {Valores[0, 6].ToString("c")} ");
        }
        else
        {
            System.Console.WriteLine("Opção inválida !!");
            goto _etq7;
        }

        break;

    default:

        System.Console.WriteLine("Opção inválida !!");
        goto _etq0;

}


//exercicio26




*/
