using System;

namespace LinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Node node
        }
    }

    public class ListaSimples
    {
        private Node node;

        public void insereNoInicio(object info)
        {
            if (node == null)
                node = new Node(info);
            else
                node = new Node(info, this.node);
        }


        public Node removeInicio()
        {
            Node noh = null;

            if (this.node != null)
            {
                noh = this.node;
                this.node = this.node.next;
            }

            return noh;
        }

        public void insereNoFinal(object info)
        {
            if (this.node == null)
                this.node = new Node(info);
            else
            {
                Node nohAuxilar = this.node;
                while (nohAuxilar.next != null){
                    nohAuxilar = nohAuxilar.next;
                }
                nohAuxilar.next = new Node(info);
            }
        }

        public Node removeFinal()
        {
            Node noh = null;
            Node nohAux;
            Node nohAux2 = new Node(null);

            if (node != null)
            {
                nohAux = this.node;
                while (nohAux.next != null)
                {
                    nohAux2 = nohAux;
                    nohAux = nohAux.next;
                }
                noh = nohAux;
                nohAux = null;
                nohAux2.next = null;
            }
            return noh;
        }

        public 
    }
}
