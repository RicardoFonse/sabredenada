//See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Óla Homem de Ferro");

//Pessoa p = new Pessoa ();

    //p.Nome = "Ricardo";
    //p.Sobrenome = "Batista Fonseca";
    //p.DataNascimento
    //p.CPF = 12312312


*/

Console.WriteLine("digite seu nome :");
string? nome = Console.ReadLine();

Console.WriteLine("digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine("digite sua data de nascimento:");
DateTime.TryParse(Console.ReadLine(), out DateTime datanascimento);

Console.WriteLine("digite seu CPF sem ponto ou caracter:");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("digite seu peso:");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine("digite sua altura :");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa (nome, sobrenome, datanascimento, cpf, altura, peso );



int idade = p.CalcularIdade();

decimal imc = Math.Round(p.CalculaIMC(),2);

bool sair = false;

while(!sair)
{
    Console.WriteLine("Escolha uma das opções abaixo!");
    Console.WriteLine("0 - Informações dos usuários");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verificar as maioridade do usuário");
    Console.WriteLine("3 - Sair");

    string? opcao = Console.ReadLine();

    switch(opcao)
    {
        case "0":
        Console.WriteLine($"Nome Completo; {p.nome} {p.sobrenome}");
        Console.WriteLine($"Data de Nascimento: {p.datanascimento}");
        Console.WriteLine($"Altura: {p.altura}");
        Console.WriteLine($"CPF: {p.cpf}");
        Console.WriteLine($"Peso: {p.}");
        Console.WriteLine($"Idade: {p.idade}");
        break;

        case "1":
        Console.WriteLine($"Seu imc é {imc}");

        if(imc >= 16)
        {
            Console.WriteLine($"Ola seu imc aponta estar Muito abaixo do peso");
        }
        else if(imc >= 18 && imc <= 17)
        {
            Console.WriteLine($"Ola seu imc aponta estar Abaixo do peso" );
        }
        else if (imc >= 19 && imc <= 24)
        {
            Console.WriteLine("Ola seu imc a ponta estar normal do peso");
        }
        else if (imc >= 25 && imc <= 29)
        {
            Console.WriteLine("Ola seu imc a ponta estar Acima do peso");
        }
        else if (imc >= 30 && imc <= 35)
        {
            Console.WriteLine("Ola seu imc a ponta estar Obesidade de grau 1");
        }
        else if (imc >= 36 && imc <=40)
        {
            Console.WriteLine("Ola seu imc a ponta estar Obesidade de grau 2");
        }
        else if (imc >= 41)
        {
            Console.WriteLine("Ola seu imc a ponta estar Obesidade de grau 3");
        }
        break;

        case "2":
        if(idade  >= 18)
        {
        Console.WriteLine($"Ola {nome} parabens vc já é Maior de idade por ter {idade} de idade");
        }else 
        Console.WriteLine($"Ola {nome}, voce é Menor de idade por ter {idade} anos de idade");
        break;

        case "3":
        sair = true;
        break;

    }
}