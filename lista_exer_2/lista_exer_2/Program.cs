using System;

namespace lista_exer_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			/*
	        int[] resultado = leitorDeValores();
            Console.WriteLine("Exercício 1 - Os valores digitados foram:");
            for (int i = 0; i < resultado.Length; i++)
                Console.Write(resultado[i]);
            Console.WriteLine(" --- ");
            int[] valores = { -1, 0, -2, -3, -5, -10, -5, 9 };
            Console.WriteLine("Exercício 2) O array de {1} contém: {0} negatios.", leNumerosNegativos(valores), valores.Length);
			Console.WriteLine(" --- ");
            */
            int[] valores = { 1, 2, 3, 9 };
            Console.WriteLine("Exercício 3) O resultado é: {0}", calculaSomaVetor(valores, 4));
		}

        //questão 1
        public static int[] leitorDeValores(){
            int[] resultado = new int[10];
            int valor_digitado = 0;

            for (int i = 0; i < resultado.Length; i++)
            {
                Console.Write("Digite um valor: ");
				string line = Console.ReadLine();

				if (int.TryParse(line, out valor_digitado)){
                    resultado[i] = valor_digitado;     
                }else{
                    Console.WriteLine("Valor informado não é válido"); 
                }
            }
                
            return resultado;
        }

        //questão 2
        public static int leNumerosNegativos(int[] array){
            int qtd_negativos = 0;

            foreach (int valor in array)
                if (valor < 0) 
                    qtd_negativos += 1;
            
            return qtd_negativos;
        }

        //questão 3
        public static int calculaDigitos(int decimais){

            int resultado = 0;

            foreach (char c in Math.Abs(decimais).ToString())
                resultado += c - '0';
            
            return resultado;

        }

        //questão 4
        public static int retornaNrVezes (int[] array, int valor)
        {
            int qtd_vezes = 0;

            foreach (int valor_array in array)
            {
                if (valor_array == valor)
                    qtd_vezes++;
            }

            return qtd_vezes;
        }

        //questão 5
        public static Boolean[] verificaPositios(int[] lista_inteiro)
        {
            Boolean[] resultado = new Boolean[lista_inteiro.Length];
            for (int i = 0; i < resultado.Length; i++)
            {
                if (lista_inteiro[i] > 0)
                    resultado[i] = true;
                else
                    resultado[i] = false;
            }

            return resultado;
        }

        //questão 6
        public static int calculaSomaVetor(int[] array, int n)
        {
            //se N = 0 então retorna o valor do array de indice 0
            if (n == 0)
                return 0;
            else{
                int x = calculaSomaVetor(array, n - 1);
                if (array[n-1] > 0)
                    x += array[n-1];
                return x;
            }
                
        }

        //questão 7
        public static int verMaiorPosicaoArray(int[] array)
        {
            int valor = 0;
            foreach (int vl_array in array){
                if (vl_array > valor)
                    valor = vl_array;
            }
            return valor;
        }

        //questão 8
        public static int[] lerTecladoArray()
        {
            string linha = Console.ReadLine();
            int[] numeros = new int[linha.Length];
            int i = 0;
            foreach (char c in linha)
            {
                numeros[i] = c;
                i++;
                Console.WriteLine("resultado = {0}", c);
            }
           return numeros;
        }

        //questão 9
        public static int[] trocaValorArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int valor = array[i] % 2;
                if (valor == 0 || valor == 2)
                    array[i] = 1;
                else
                    array[i] = -1;
            }
            return array;
        }

        //questão 10

        public static int fibonacci_1(int n)
        {
            if (n < 2)
                return n;
            else
                return fibonacci_1(n - 1) + fibonacci_1(n - 2);
        }

        public static int fiboonaci_2(int n)
        {
            int resultado = 0;
            int aux = 1;
            for (int i = 0; i < n; i++){
                int temp = resultado;
                resultado = aux;
                aux = temp + aux;
            }
            return resultado;
        }

    }
}
