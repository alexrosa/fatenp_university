using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comando {

    public Vector3 posicao { get; set; }
    public Comando proximo;

    public Comando(Vector3 posicao){
        this.posicao = posicao;
        this.proximo = null;
    }
}
