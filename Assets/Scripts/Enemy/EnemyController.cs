using UnityEngine;

public class EnemyController : MonoBehaviour {

    private GameObject target;
    private GameObject slashSound;
    private GameObject smash;

    public GameObject coin;
    public GameObject deadEnemy;
    public int speed;
    public int damage;

    // Use this for initialization
    void Start ()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
        
        slashSound = GameObject.Find("SwordSlash");
        smash = GameObject.Find("EnemySmash");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
            transform.position = Vector3.MoveTowards(transform.position, target.GetComponent<Transform>().position, speed * Time.deltaTime);
        }
        
    }
    //Metodo de muerte y de daño
    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag == "HeroSlash")
        {
            slashSound.GetComponent<AudioSource>().Play();
            Instantiate(deadEnemy, GetComponent<Transform>().position, Quaternion.identity);
            Instantiate(coin, GetComponent<Transform>().position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Player")
        {
            smash.GetComponent<AudioSource>().Play();
            StaticData.life -= damage;
        }
    }
}
