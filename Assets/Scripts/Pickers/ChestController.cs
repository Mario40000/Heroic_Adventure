using UnityEngine;

public class ChestController : MonoBehaviour {

    public Sprite openChest;
    public int content;
    public Transform instancier;
    public GameObject coin;
    public GameObject potion;
    //Abrimos el cofre si lo toca el jugador
    void OnCollisionEnter2D(Collision2D other )
    {
        if(other.gameObject.tag == "Player" && content > 0)
        {
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
            content = 0;
            int counter = Random.Range(0, 5);
            if(counter > 3)
            {
                Instantiate(coin, instancier.position, Quaternion.identity);
            }
            else
            {
                Instantiate(potion, instancier.position, Quaternion.identity);
            }
            
        }
    }
}
