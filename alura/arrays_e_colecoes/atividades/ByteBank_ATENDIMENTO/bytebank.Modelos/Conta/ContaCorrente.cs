namespace bytebank.Modelos.Conta
{
	public class ContaCorrente:IComparable<ContaCorrente>
	{
		private int _numero_agencia;

		private string _conta;

		private double saldo;

		public Cliente Titular { get; set; }

		public string Nome_Agencia { get; set; }

		public int Numero_agencia
		{
			get
			{
				return _numero_agencia;
			}
			set
			{
				if (value > 0)
				{
					_numero_agencia = value;
				}
			}
		}

		public string Conta
		{
			get
			{
				return _conta;
			}
			set
			{
				if (value != null)
				{
					_conta = value;
				}
			}
		}

		public double Saldo
		{
			get
			{
				return saldo;
			}
			set
			{
				if (!(value < 0.0))
				{
					saldo = value;
				}
			}
		}

		public static int TotalDeContasCriadas { get; set; }

		public bool Sacar(double valor)
		{
			if (saldo < valor)
			{
				return false;
			}
			if (valor < 0.0)
			{
				return false;
			}
			saldo -= valor;
			return true;
		}

		public void Depositar(double valor)
		{
			if (!(valor < 0.0))
			{
				saldo += valor;
			}
		}

		public bool Transferir(double valor, ContaCorrente destino)
		{
			if (saldo < valor)
			{
				return false;
			}
			if (valor < 0.0)
			{
				return false;
			}
			saldo -= valor;
			destino.saldo += valor;
			return true;
		}

        public int CompareTo(ContaCorrente? other)
        {
			if (other==null)
			{
				return 1;
			}
			else
			{
				return this.Numero_agencia.CompareTo(other.Numero_agencia);
			}
        }

        public ContaCorrente(string numero_conta, int numero_agencia)
		{
			Numero_agencia = numero_agencia;
			Conta = numero_conta;
			Titular = new Cliente();
			TotalDeContasCriadas++;
		}
	
		public override string ToString()
		{
			return "==== Dados da Conta ====\n" +
			$"Numero da conta: {this.Conta}\n" +
			$"Numero da agencia: {this.Numero_agencia}\n" +
			$"Saldo da conta: {this.Saldo}\n"+
			$"Titular da conta: {this.Titular.Nome}\n"+
			$"CPF do titular: {this.Titular.Cpf}\n" +
			$"Profissao do titular: {this.Titular.Profissao}\n";
		}
	}

    
}