using System;

namespace DIO.Bank
{
  public class Conta
  {

    private TipoConta tipoConta { get; set; }
    private double Credito { get; set; }
    private double Saldo { get; set; }
    private string Nome { get; set; }

    public Conta(TipoConta tipoConta, double credito, double saldo, string nome)
    {
      this.tipoConta = tipoConta;
      this.Credito = credito;
      this.Saldo = saldo;
      this.Nome = nome;
    }

    public bool Sacar(double valorSaque)
    {
      if (this.Saldo < valorSaque)
      {
        Console.WriteLine("Saldo Insuficiente");
        return false;
      }

      this.Saldo -= valorSaque;
      Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
      return true;
    }

    public void Depositar(double valorDeposito)
    {
      this.Saldo += valorDeposito;
      System.Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
    }

    public void Transferir(double valorTransferencia, Conta contaDestino)
    {
      if (this.Sacar(valorTransferencia))
      {
        contaDestino.Depositar(valorTransferencia);
      }
    }

    public override string ToString()
    {
        string retorno = $"Tipo Conta {this.tipoConta} | " + 
                         $"Nome {this.Nome} | " + 
                         $"Saldo {this.Saldo} | " + 
                         $"Credito {this.Credito} |";
      return retorno;
    }

  }
}