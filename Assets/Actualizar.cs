using UnityEngine;
using System.Collections;

public class Actualizar : MonoBehaviour {
		
	public TextMesh total;
	public TextMesh record;
	public Puntaje Puntos;
	public EstadoJuego Estado;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnEnable(){
		total.text = Puntos.puntuacion.ToString ();
		if (EstadoJuego.estadoJuego!=null) {
			record.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString ();
		}
}
}