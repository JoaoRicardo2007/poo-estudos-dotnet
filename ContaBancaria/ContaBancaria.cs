class ContaBancaria
{
    public string Titular { get; private set; }

    public decimal Saldo { get; private set; }


    public ContaBancaria(string titular)
    {
        Titular = titular;
    }
    public void Depositar(decimal deposito)
    {
        if (deposito <= 0)
        {
            return;
        }

        Saldo += deposito;
    }
    public bool Sacar(decimal saque)
    {
        if (saque > Saldo)
        {
            return false;
        }
        else if(saque <= 0)
        {
           return false;
        }

        Saldo -= saque;
        return true;
    }
}