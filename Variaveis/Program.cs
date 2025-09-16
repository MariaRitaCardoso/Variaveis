// See https://aka.ms/new-console-template for more information

// String para armazenar texto
// Atalho de comentário : Ctrl + K + C
string nome = "Maria Cardoso";

// tipo de variável para valores inteiros: 1, 1 e etc
int idade = 16;

// tipo de variável para valores decimais: 1.5, 2.5 e etc
float altura = 1.68f;
double preco = 17.5;
decimal saldo = 1000.50m;

// tipo de variável para valores lógicos: true ou false 
bool estudante = true;

// tipo de variável para valores únicos: 'A', 'B' e etc
char genero = 'F';

// tipo de variável para valores constantes: PI = 3.14
const double pi = 3.14;

// Forma 1
Console.WriteLine(nome);

//Forma 2 - Interpolação de strings 
Console.WriteLine($"A {nome} tem {idade} anos");

// Forma 3 - Concatenação de strings
Console.WriteLine("A " + nome + " tem " + idade + " anos. ");

// Utilizando /n para pular uma linha
// Semelhante ao <br> do HTML que já utilizamos
Console.WriteLine($"\n O valor de pi é: {pi}");