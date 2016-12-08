using UnityEngine;

public class elJugadorPerron : MonoBehaviour {
	
	// The force which is added when the player jumps
	// This can be changed in the Inspector window
	public Vector2 jumpForce = new Vector2(0, 300);
	public GameObject Camara;
	
	void Start () {
		//NotificationCenter.DefaultCenter().AddObserver(this, "Die");
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Jump
		if (Input.GetMouseButtonDown(0))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jumpForce);
		}
		
	}
	void MuerteCamara(){
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			Die();
		}
	}
	
	//Die by collision
	void OnCollisionEnter2D(Collision2D other)
	{
		Die();
	}
	
	void Die()
	{
		Camara.SetActive (true);
		
	}
}
