using UnityEngine;

public class FireBarrierController : MonoBehaviour {

    public int damage;

    private GameObject fire;

    void Start ()
    {
        fire = GameObject.Find("FireDamage");
    }
	//Comprobamos si el jugador tiene el objeto
    //para desactivar las barreras
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player" && StaticData.extinghiser == 1)
        {
            Destroy(gameObject);
        }
    }

    //Dañamos al jugador si se pega al fuego
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            fire.GetComponent<AudioSource>().Play();
            StaticData.life -= damage;
        }
    }
}
