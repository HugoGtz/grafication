﻿using UnityEngine;
using System.Collections;

public class Puntaje : MonoBehaviour {
	public int puntuacion = 0;
	public TextMesh marcador;
    public GameObject Fondo1;
	
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
		ActualizarMarcador();
	}
	
	void PersonajeHaMuerto(Notification notificacion){
		if(puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima){
			EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
			EstadoJuego.estadoJuego.Guardar();
		}
	}
	
	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion+=puntosAIncrementar;
		ActualizarMarcador();
	}
	
	void ActualizarMarcador(){
		marcador.text = puntuacion.ToString();
        if (puntuacion == 5) {
            Fondo1.SetActive(true);
        }

        if (puntuacion == 10)
        {
            Fondo1.SetActive(false);
        }
        if (puntuacion == 15)
        {
            Fondo1.SetActive(true);
        }

        if (puntuacion == 20)
        {
            Fondo1.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}