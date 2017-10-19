using System;
namespace fatenp
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(){}

            public String Cpf { get; set; }

            public String Rg { get; set; }

            

        public override void fazAlgo()
        {
			Console.WriteLine("Uma pessoa física trabalha e estuda.");

		}
    }
}
