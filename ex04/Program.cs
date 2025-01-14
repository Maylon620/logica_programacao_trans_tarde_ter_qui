// Escreva uma programa que pergunte o nome do usuário e apresente nome + boas vindas

Console.WriteLine("Qual é seu nome?");

string nome = Console.ReadLine();

Console.WriteLine("Qual é seu sobrenome?");

string sobrenome = Console.ReadLine();

Console.WriteLine("Qual é seu ultimosobrenome?");

string ultimosobrenome = Console.ReadLine();

//Console.WriteLine("Seja bem-vindo(a) " + nome + sobrenome + ultimonome);
Console.WriteLine($"Seja bem-vindo(a) {nome} {sobrenome} {sobrenome} {ultimosobrenome} ");