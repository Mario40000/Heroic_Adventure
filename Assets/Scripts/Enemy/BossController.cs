using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {

    public new Rigidbody2D rigidbody;
    public int life;
    public int speed;
    public int delay;
    public float fireRate;
    public float retard;
    public Transform instancier;
    public Transform fireInstancier;
    public GameObject treasure;
    public GameObject explosion;
    public GameObject fireBall;

    private GameObject damage;
    private GameObject dieSound;
    private GameObject mainBgm;
    private GameObject winBgm;
    private GameObject player;
    private GameObject fireCast;
    

	// Use this for initialization
	void Start ()
    {
        dieSound = GameObject.Find("DragonDying");
        damage = GameObject.Find("DamageSound");
        mainBgm = GameObject.Find("BossBGM");
        winBgm = GameObject.Find("WinBGM");
        player = GameObject.FindGameObjectWithTag("Player");
        fireCast = GameObject.Find("FireBallCast");
        StartCoroutine(move());
        InvokeRepeating("fire", retard, fireRate);
    }
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = (transform.right * speed);

        if (life <= 0)
        {
            StartCoroutine(dead());
        }
    }

    //Metodo para perder vida
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "HeroSlash")
        {
            damage.GetComponent<AudioSource>().Play();
            life--;
        }
        else
        {
            return;
        }
    }
    
    //Cambiamos el sentido del vuelo
    IEnumerator move ()
    {
        while (gameObject != null)
        {
            yield return new WaitForSeconds(delay);
            speed *= -1;
        }
    }

    //Metodo para matar al dragon
    IEnumerator dead ()
    {
        speed = 0;
        mainBgm.GetComponent<AudioSource>().Stop();
        winBgm.GetComponent<AudioSource>().Play();
        dieSound.GetComponent<AudioSource>().Play();
        Instantiate(explosion, instancier.position, Quaternion.identity);
        yield return new WaitForSeconds(3);
        Instantiate(explosion, instancier.position, Quaternion.identity);
        Instantiate(treasure, instancier.position, Quaternion.identity);
        Destroy(gameObject);

    }

    //Metodo para disparar
    void fire ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            
            Instantiate(fireBall, fireInstancier.position, fireInstancier.rotation);
            //Hacemos sonar los disparos
            fireCast.GetComponent<AudioSource>().Play();
        }
    }
}
