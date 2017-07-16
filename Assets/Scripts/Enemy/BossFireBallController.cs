using UnityEngine;
using System.Collections;

public class BossFireBallController : MonoBehaviour {

    private GameObject target;
    private GameObject explosion;

    public float speed;
    public float lifeTime;
    public Transform instancier;
    public GameObject fire;

	// Use this for initialization
	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        explosion = GameObject.Find("FireBallExplosion");
        StartCoroutine(fireBallLife());
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Seguimos al player con los disparos
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.GetComponent<Transform>().position, speed * Time.deltaTime);
        }
        
    }

    //Cuando las bolas impactan se destruyen e instancian fuego
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StaticData.life -= 20;
            explosion.GetComponent<AudioSource>().Play();
            Instantiate(fire, instancier.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    //Acotamos la vida de las bolas
    IEnumerator fireBallLife ()
    {
        yield return new WaitForSeconds(lifeTime);
        explosion.GetComponent<AudioSource>().Play();
        Instantiate(fire, instancier.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
