abstract class ContaBanco
{
    protected string nome;

    protected string senha;

    protected double saldo;
    
    public abstract double Depositar(double valorAcrescimo);
    public abstract double RetirarDeposito(double valorRetirada); 
}