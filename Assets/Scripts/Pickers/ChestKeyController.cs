using UnityEngine;

public class ChestKeyController : MonoBehaviour {

    public Sprite openChest;
    public Transform instancier;
    public GameObject key;
    public int content;
    //Abrimos el cofre si lo toca el jugador
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && content > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
            gameObject.GetComponent<AudioSource>().Play();
            content = 0;
            Instantiate(key, instancier.position, Quaternion.identity);
        }
    }
}
