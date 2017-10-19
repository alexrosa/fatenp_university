using System;
namespace fatenp
{
    public abstract class Pessoa
    {
        private String Nome { get; set; }

        private String Endereco { get; set; }

        public abstract void fazAlgo();
    }
}
