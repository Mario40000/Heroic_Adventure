using UnityEngine;
using System.Collections;

public class Hero1Controller : MonoBehaviour {

    public float speed;
    public Transform rightInstancier;
    public Transform leftInstancier;
    public GameObject rightSlash;
    public GameObject leftSlash;
    public GameObject deadHero;

    private Animator animator;
    private GameObject dead;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
        dead = GameObject.Find("DeadScream");
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Transiciones de la animacion
        animator.SetFloat("horSpeed", Mathf.Abs(Input.GetAxis("Horizontal")));
        animator.SetFloat("verSpeed", Mathf.Abs(Input.GetAxis("Vertical")));
        

        if(Input.GetAxis("Horizontal") > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        //Ataque
        if(Input.GetButtonDown("Jump"))
        {
            if(gameObject.GetComponent<SpriteRenderer>().flipX == false)
            {
                Instantiate(rightSlash, rightInstancier.position, Quaternion.identity);
            }
            if (gameObject.GetComponent<SpriteRenderer>().flipX == true)
            {
                Instantiate(leftSlash, leftInstancier.position, Quaternion.identity);
            }
        }

        if(StaticData.life <= 0)
        {
            StartCoroutine(playerDead());
        }


    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Actualizamos la posicion del heroe multiplicando movimiento por velocidad
        Vector3 movement = new Vector3((moveHorizontal) , moveVertical, 0.0f);
        GetComponent<Rigidbody2D>().velocity = movement * speed;
    }
    //Metodo de muerte del jugador
    IEnumerator playerDead ()
    {
        dead.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.5f);
        Instantiate(deadHero, GetComponent<Transform>().position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}
