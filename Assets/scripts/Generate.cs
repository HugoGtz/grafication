using UnityEngine;

public class Generate : MonoBehaviour
{
	public GameObject rocks;
//	public TextMesh Marcador;
//	int score = 0;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1.5f, 2f);
	}


	void CreateObstacle()
	{
		Instantiate(rocks);
	}

//	void Puntaje(Collider2D colision){
//		if (colision.gameObject.name == "Puntajehola") {
//			score++;
//			ActualizarMarcador ();
//			}
//	}
//
//	void ActualizarMarcador(){
//		Marcador.text = score.ToString();
//
//	}
}