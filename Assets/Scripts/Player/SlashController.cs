using UnityEngine;

public class SlashController : MonoBehaviour {

    public float speed;
    public int power;

    // Use this for initialization
    void Start()
    {
        //Damos al ataque un pequeño movimiento
        GetComponent<Rigidbody2D>().velocity = (transform.right * speed);
        Destroy(gameObject, 0.5f);
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag == "Boss" || other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
