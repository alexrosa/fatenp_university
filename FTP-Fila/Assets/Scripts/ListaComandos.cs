using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaComandos
{
    private Comando inicioLista;
    private Comando fimLista;

    //insere um novo item
    public void inserir(Vector3 posicao)
    {
        
        if (inicioLista == null){
            Comando aux = new Comando(posicao);
            inicioLista = aux;
            fimLista = aux;
        }else{
            Comando aux = inicioLista;

            while(aux.proximo != null){
                aux = aux.proximo;
            }
            Comando novo_noh = new Comando(posicao);
            aux.proximo = novo_noh;
            fimLista = novo_noh;
        }

    }

    //removendo comando da fila (limpa a lista)
    public Vector3 desEnfileirar(){
        Comando aux = inicioLista;
        Vector3 posicao = aux.posicao;
        inicioLista = aux.proximo;
        return posicao;
    }

    //verificando se a lista esta vazia
    public bool isEmpty(){
        return (inicioLista == null);
    }

    //listando os itens da lista
    public void listar(){
        Comando aux = inicioLista;
        while(aux != null){
            Debug.Log("listando item "+aux.posicao);
            aux = aux.proximo;
        }
    }
}
