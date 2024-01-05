using FundamentosCSharp.Models; // using serve para chamar a classe atraves do seu namespace 

// classes instanciadas 
Pessoa pessoa1 = new Pessoa();
Calculadora calc = new Calculadora();

// pessoa1 é a variável 
pessoa1.Nome = "Lucas";
pessoa1.Idade = 30;
pessoa1.Apresentar();


// declarando variáveis
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80; // valor decimal 
decimal preco = 1.60M; // valor monetario
bool condicional = true; 

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00")); // para que o ultimo zero nao seja excluido
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condicional: " + condicional);


// O tipo DateTime (struct)
DateTime dataAtual = DateTime.Now;  // sempre pega a data da maquina que esta executando 
Console.WriteLine(dataAtual);

DateTime dataAtual2 = DateTime.Now.AddDays(5); // acrescer alguns dias no horario atual
Console.WriteLine(dataAtual2);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); // retirar a hora, imprimir apenas a data 
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); // imprimir data, hora e minutos - retirar os segundos


// operadores de atribuição
int a = 10;
int b = 20;

int c = a + b; // c esta sendo atribuido ao valor da soma entre a + b 
Console.WriteLine(c);

// c = c + 5; 
c += 5; // combinando os operadores += que é a mesma coisa de ser representado acima 
Console.WriteLine(c);

// convertendo tipos de variáveis (cast - casting)
int d = Convert.ToInt32("5"); // transformando uma string em um numero inteiro 
Console.WriteLine(d);
// o Parse tem a mesma função do Convert, porém caso tenha um valor nulo ele não retornará o null, mas irá gerar um erro em sua aplicação 

// convertendo para string
int inteiro = 5;
string k = inteiro.ToString(); // string nao pode receber int diretamente, é preciso fazer o casting - conversão utilizando o ToString
Console.WriteLine(k);

// ordem dos operadores
double h = 4 / (2 + 2); // obedece a mesma ordem das operações matemáticas - parenteses, expoentes, divisão e multiplicação e por fim adição e substração 
Console.WriteLine(h);


// operador condicional
int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}"); // o simbolo $ serve para misturar variavel com texto na hora de executar o programa 
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
} 
else if (possivelVenda) 
{
    Console.WriteLine("Venda realizada"); // a condição sendo verdadeira, esse código é executado
} else {
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque"); // a condição sendo falsa, esse código é executado 
}


// utilizando o switch case
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}


// operador OR tambem chamado de pipe (||)
bool maiorDeIdade = false;
bool possuiAutorizacaoDoResponsavel = true;

if (maiorDeIdade || possuiAutorizacaoDoResponsavel) // a primeira ou a segunda precisa ser verdadeira para o if executar
{
    Console.WriteLine("Entrada liberada");
} else {
    Console.WriteLine("Entrada não liberada"); // o else so executa se ambos nao forem verdadeiro 
}


// operador AND (&&)
bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7) // ambos precisam ser verdadeiros para o if executar 
{
    Console.WriteLine("Aprovado");
} else {
    Console.WriteLine("Reprovado"); // uma condição sendo falsa já será executado pelo else 
}


// operador NOT (!) Inverte o valor booleano, se for true vira false, se for false vira true 
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde) // o if considera que a condição seja verdadeira, com o (!) ela será falsa - inverte o esperado
{
    Console.WriteLine("Vou pedalar");
} else {
    Console.WriteLine("Vou pedalar outro dia");
}


// operadores aritmeticos
calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);

// usando metodo Math
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);


// incremento e decremento
int numeroIncremento = 10;

Console.WriteLine("Incrementando o 10");
numeroIncremento++; // numero = numero + 1;

Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
numeroDecremento--; // numero = numero - 1;

Console.WriteLine(numeroDecremento);


// laço de repetição FOR
int numero = 5;

for(int contador = 0; contador <= 10; contador++) // declaração da variável + condição de parada + incremento ou decremento 
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

// laço de repetição WHILE
int numero1 = 5;
int cont = 1;

while(cont <= 10) // como a condição é sempre verdadeira, é necessário inserir uma saída para não ficar em loop infinito
{
    Console.WriteLine($"{cont} Execução: {numero1} x {cont} = {numero1 * cont}");
    cont++; // condição de saída nessa situação é o incremento 

    if (cont == 6)
    {
        break; // serve para interromper o fluxo de execução antes de chegar ao seu final (também é uma condição de saída)
    }
}

// laço de repetição DO WHILE
int soma = 0;
int numero2 = 0;

do // executa o codigo independente da condição ser verdadeira ou falsa
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero2 = Convert.ToInt32(Console.ReadLine()); // convertendo o numero inteiro para uma string 
    soma += numero2; // soma = soma + numero 

} while(numero2 != 0); // condição enquanto numero2 for diferente de zero o laço continua

Console.WriteLine($"Total da soma dos números digitados é: {soma}"); 


// exemplo de menu interativo
string opcao;
bool exibirMenu = true; // se essa condição inicial fosse falsa, o while nao iria iniciar, pois ele somente analisa quando é true 

while(exibirMenu)
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false; // a variavel se torna falso, e sendo falso no while ele nao executa 
            // Environment.Exit(0) essa é uma forma de encerrar o programa e nao ler o que estiver fora da execução 
            break;
        
        default: // caso nao seja digitado nenhuma das opcoes acima, ela caira no default 
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("O programa se encerrou");


// arrays
int[] arrayInteiros = new int[4]; // array com 3 posições - pode armazenar 3 valores diferentes

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length); // cria uma copia do array e redimensiona seu tamanho, semelhante ao Resize 

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // cria uma copia para um array redimensionado (altera o tamanho) para menor ou maior 

Console.WriteLine("Array com FOR");
for(int contador1 = 0; contador1 < arrayInteiros.Length; contador1++) // é mais indicado quando se necessita saber o valor do contador 
{
    Console.WriteLine($"Na posição {contador1} está o {arrayInteiros[contador1]}");
}

// percorrendo o array com FOREACH
Console.WriteLine("Array com FOREACH");

int contadorForeach = 0; // nesse caso esse so funciona para mostrar a posição, não é nenhuma condição 

foreach(int valor in arrayInteiros) // foreach funciona apenas para listas 
{
  Console.WriteLine($"Na posição {contadorForeach} está o {valor}");
  contadorForeach++;
}


// listas (é mais preferível que seja utilizado ao inves do array)
List<string> listaString = new List<string>(); // nao é necessário determinar uma capacidade máxima para a lista 

listaString.Add("CE");
listaString.Add("PE");
listaString.Add("BA");
listaString.Add("AL");

Console.WriteLine($"Itens na minha lista {listaString.Count} - Capacidade: {listaString.Capacity}"); // capacidade interna do array (não é a capacidade da lista em si)

listaString.Add("SP"); // é possível adicionar sem precisar se preocupar em redimensionar (diferente do array que precisa)

Console.WriteLine($"Itens na minha lista {listaString.Count} - Capacidade: {listaString.Capacity}"); // a capacidade interna aumentou (redimensionou sozinho) ao add mais um elemento na lista

listaString.Remove("AL");

Console.WriteLine($"Itens na minha lista {listaString.Count} - Capacidade: {listaString.Capacity}");

// percorrendo a lista com o FOR
Console.WriteLine("Percorrendo a lista com o FOR");
for(int contador2 = 0; contador2 < listaString.Count; contador2++)
{
    Console.WriteLine($"Posição número {contador2} - {listaString[contador2]}");
}

// percorrendo a lista com o FOREACH
Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach1 = 0;

foreach(string item in listaString)
{
    Console.WriteLine($"Posição número {contadorForeach1} - {item}");
    contadorForeach1++;
}

