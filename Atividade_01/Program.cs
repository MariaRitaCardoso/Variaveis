string nome;
int idade;
string cidade;
string programação;
string hobbie;
char letra;
int numero1;
int numero2;

// Atividade 1:

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite sua cidade:");
cidade = Console.ReadLine();

Console.WriteLine("Digite a área da programação que mais gosta:");
programação = Console.ReadLine();

Console.WriteLine("Digite o seu hobbie:");
hobbie = Console.ReadLine();

Console.WriteLine($"O seu nome é {nome}, você tem {idade} anos, sua cidade é {cidade}, sua área da programação que mais gosta é {programação} e seu hobbie é {hobbie}.");



// Atividade 2:

Console.WriteLine("Digite uma letra:");
letra = Convert.ToChar(Console.ReadLine().ToUpper());

Console.WriteLine($"Você digitou a letra: {letra}.");



// Atividade 3:

Console.WriteLine("Digite o primeiro número:");
numero1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
numero2 = Convert.ToInt16(Console.ReadLine());

int soma = numero1 + numero2;

Console.WriteLine($"A soma entre {numero1} e {numero2} é igual a {soma}.");
