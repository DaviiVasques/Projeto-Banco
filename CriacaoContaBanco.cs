using System;
using System.Globalization;
using System.Collections.Generic;

class CriacaoContaBanco
{
    CultureInfo moedaBrasil = new CultureInfo("pt-BR");
    private string _nome;
    private string _senha;
    public List<string> titular { get; private set; }
    public double saldo { get; private set; }

    public CriacaoContaBanco(string nome, string senha,List<string> titular, double saldo)
    {
        _nome = nome;
        _senha = senha;
        this.titular = titular;
        this.saldo = saldo;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }

    public string Senha
    {
        get { return _senha; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _senha = value;
            }
        }
    }


    public override string ToString()
    {
        string titulares = string.Join(", ", titular);

        return "O seu nome é: " + _nome + ", a sua senha é: "+ _senha + ", o titular é: " + titulares +
            " e o seu saldo é: " + saldo.ToString("C", moedaBrasil);
    }
}
