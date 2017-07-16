using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour {

    private GameObject controller;
    private GameObject[] enemies;

    public GameObject mainBGM;
    public GameObject winBGM;

	// Use this for initialization
	void Start ()
    {
        controller = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

	}

    void FixedUpdate ()
    {
        controller = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }
	
	IEnumerator stageClear ()
    {
        //Eliminamos a todos los enemigos de la pantalla
        for (int i = 0;i < enemies.Length;i++)
        {
            Destroy(enemies[i]);
        }
        controller.GetComponent<Hero1Controller>().enabled = false;
        mainBGM.GetComponent<AudioSource>().Stop();
        winBGM.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(15);
        StaticData.stage = 2;
        SceneManager.LoadScene("Round2");
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StaticData.goal = 1;
            StartCoroutine(stageClear());
        }
    }
}
