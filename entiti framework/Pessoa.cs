using System;

public class Pessoa
{
    //Atributos

    public string? Nome;
    public string? Sobrenome;
    public DateTime DataNascimento;
    public int CPF ;
    public decimal Peso;
    public decimal Altura;

    public Pessoa (string? nome, string? sobrenome, DateTime datanascimento, int cpf, decimal peso , decimal altura)
    {
        Nome = nome ;
        Sobrenome = sobrenome;
        DataNascimento = datanascimento;
        CPF= cpf;
        Peso = peso;
        Altura = altura;
    }
    //Metodos 
    public int CalcularIdade()
    {
        DateTime dataAtual = DateTime.Now;
        int Idade = dataAtual.Year - DataNascimento.Year;

        return Idade ;

    }
    public decimal CalculaIMC()
    {
        decimal peso = (decimal)Peso;
        decimal altura = (decimal) Altura;

        decimal Imc = peso / (altura * altura);

        return Imc;
    }
    public bool Maioridade()
    {
        int Idade = CalcularIdade();
        return Idade >=18;

    }
   



}