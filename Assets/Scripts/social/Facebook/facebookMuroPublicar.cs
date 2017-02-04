using UnityEngine;
using System.Collections;

public class facebookMuroPublicar : MonoBehaviour {
	public string mensaje;
	GameObject redesSociales;
	// Use this for initialization
	void Start () {
		redesSociales = GameObject.Find("RedesSociales");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void setMensaje(string m){
		mensaje = m;
	}
	
	void facebookPublicar(){
		if(redesSociales != null) redesSociales.SendMessage("publicarEnMuro", mensaje);
	}

	public void publicacionExitosa(){
		GameObject.FindGameObjectWithTag ("central").SendMessage ("shareExitoso");
	}
}