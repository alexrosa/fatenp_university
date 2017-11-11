using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private ListaComandos lsComandos;
    public float duracao = 1f;
    private float tempoInicial;
	// Use this for initialization
	void Start () {
        lsComandos = new ListaComandos();
        tempoInicial = Time.time;
        lsComandos.inserir(Vector3.up);
        lsComandos.inserir(Vector3.down);
        lsComandos.inserir(Vector3.left);
        lsComandos.inserir(Vector3.right);
        lsComandos.inserir(Vector3.up);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!lsComandos.isEmpty())
            {

                Vector3 acao = lsComandos.desEnfileirar();
                float time = (Time.time - tempoInicial) / duracao;
                gameObject.transform.Translate(acao * time);
            }
        }
        /*
        if (Input.GetMouseButtonDown(0)){
            
            Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            lsComandos.inserir(pos);
        }*/
	}
}
