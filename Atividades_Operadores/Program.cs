// Atividades sobre Operadores - Sintaxe Básica de C# //



// Atividade 01 - Soma de 3 notas e mostre a média deles. //

int soma = 2 + 2;
int subtracao = 10 - 5;
int multiplicacao = 3 * 7;
double divisao = 3 / 2.5;

Console.WriteLine($"2 + 2 = {soma}");
Console.WriteLine($"10 - 5 = {subtracao}");
Console.WriteLine($"3 * 7 = {multiplicacao}");
Console.WriteLine($"3 / 2.5 = {divisao}");

double num1, num2, num3, resultado;
Console.WriteLine("Insira a primeira Nota:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a segunda Nota:");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a terceira Nota:");
num3 = Convert.ToDouble(Console.ReadLine());


resultado = (num1 + num2 + num3) / 3;
Console.WriteLine($"A média das três notas é: {resultado}.");



// Atividade 02 - Temperatura Leia uma temperatura em Celsius e converta para Fahrenheit. //

double Celsius, Fahrenheit;
Console.WriteLine("Insira a temperatura em Celsius:");
Celsius = Convert.ToDouble(Console.ReadLine());

Fahrenheit = (Celsius * 9 / 5) + 32;
Console.WriteLine($"A temperatura rm Fahrenheit é {Fahrenheit}.");



// Atividade 03 - Área de Quadrado: Leia o lado de um quadrado e calcule a área (lado * lado). Mostre o resultado //

double lado;
Console.WriteLine("Insira a medida do lado do quadrado:");
lado = Convert.ToDouble(Console.ReadLine());

resultado = lado * lado;
Console.WriteLine($"A área do quadrado é: {resultado}.");



// Atividade 04 - Área de Triângulo: Leia a base e a altura de um triângulo e calcule a área. //

double baset, altura;
Console.WriteLine("Insira a base do triângulo:");
baset = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira a altura do triângulo:");
altura = Convert.ToDouble(Console.ReadLine());

resultado = (baset * altura) / 2;
Console.WriteLine($"A área do triângulo é: {resultado}.");



// Atividade 05 - Constante – Área do Círculo Declare uma constante PI = 3.14159. Peça o raio de um círculo e calcule a área. //

double raio;
const double pi = 3.14159;

Console.WriteLine("Insira o raio do círculo:");
raio = Convert.ToDouble(Console.ReadLine());

resultado = (pi * raio * raio);
Console.WriteLine($"A área do círculo é: {resultado}.");



// Atividade 06 -Perímetro do Retângulo Peça a largura e a altura de um retângulo e calcule o perímetro. //

double largura, comprimento;
Console.WriteLine("Insira a largura do retângulo:");
largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira o comprimento do retângulo");
comprimento = Convert.ToDouble(Console.ReadLine());

resultado = 2 * (largura + altura);
Console.WriteLine($" O perímetro do retângulo é: {resultado}.");
