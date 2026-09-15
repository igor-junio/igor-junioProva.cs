// o que deve ser feito?
// Desenvover um sistema simples contendo: 3 clase difente , e o codico organizado , e o uso correto de poo.
// cada clase deve funcionar de forma independente.

// Requisitos do sistema. o sistema deve conter:
// 3 clase (Ex: Produto, Pessoa, Conta, etc. )
// Atributos privados (private)
// Propiedades (get / set) 
// Construtor em cada classe
// Metodo ToString() em cada classe

// Sugestoes de classe
// Voce pode escolher qualquer 3 classe, por exemplo:
// Pessoa , Produto , ContaBancaria, ou , Aluno , Retangulo , Funcionario, . ou criar suas proprias classe

// Encapsulanto (Obrigatorio)
// Todos os atributos devem ser: private
// O acesso deve ser feito por: Properties (get / set)
// Validaçoes devem ser aplicadas quando necessario.

// Construtores (obrigatorio)
// Cada classe deve ter: um contrutor com paramentros
// O construtor deve: inicializar os Atributos, Garantir Valores Validos
//




using System;

class Pessoa
{
    private string nome;
    private int idade;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("O nome não pode ser vazio.");

            nome = value;
        }
    }
    
public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
                throw new Exception("A idade não pode ser negativa.");

            idade = value;
        }
    }

public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public override string ToString()
    {
        return $"Nome: {Nome} | Idade: {Idade}";
    }
}

public override string ToString()
    {
        return $"Nome: {Nome} | Idade: {Idade}";
    }
}

class Produto
{
    private string nome;
    private double preco;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("O nome do produto não pode ser vazio.");

            nome = value;
        }
    }
    
public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
                throw new Exception("O preço não pode ser negativo.");

            preco = value;
        }
    }

public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

public override string ToString()
    {
        return $"Produto: {Nome} | Preço: R$ {Preco:F2}";
    }
}

class ContaBancaria
{
    private int numero;
    private double saldo;

    public int Numero
    {
        get { return numero; }
        set
        {
            if (value <= 0)
                throw new Exception("O número da conta deve ser maior que zero.");

            numero = value;
        }
    }

    public double Saldo
    {
        get { return saldo; }
        set
        {
            if (value < 0)
                throw new Exception("O saldo não pode ser negativo.");

            saldo = value;
        }
    }

    public ContaBancaria(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public override string ToString()
    {
        return $"Conta: {Numero} | Saldo: R$ {Saldo:F2}";
    }
}

class Program
{



