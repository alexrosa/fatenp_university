using System;
namespace fatenp
{
    public class Dojo
    {

        public void troca ( String v1, String v2){

           String aux = v1;
            v1 = v2;
            v2 = aux;
		
            Console.WriteLine("V1 = {0} e V2 = {1}", v1, v2);

        }



    }
}
