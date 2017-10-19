using System;
namespace fatenp
{
    public class PessoaJuridica : Pessoa
    {

		private String CNPJ { get; set; }

		private String RS { get; set; }


	public override void fazAlgo()
	{
		Console.WriteLine("Uma empresa gera empregos e ajuda a economia.");

	}

    }
}
