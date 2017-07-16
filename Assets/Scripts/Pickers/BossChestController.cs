using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BossChestController : MonoBehaviour {

    public GameObject goldCoin;
    public GameObject[] instanciers;
    public int treasureValue;
    public Sprite openChest;
    public int content;
    public float delay;

    private GameObject instancier;

    //Abrimos el cofre si lo toca el jugador
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" && content > 0)
        {
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<SpriteRenderer>().sprite = openChest;
            content = 0;
            StartCoroutine(treasure());
        }
    }

    //Corrutina para hacer aparecer las monedas
    IEnumerator treasure ()
    {
        for (int i = 0; i < treasureValue; i++)
        {
            instancier = instanciers[Random.Range(0, instanciers.Length)];
            Instantiate(goldCoin, instancier.GetComponent<Transform>().position, Quaternion.identity);
            yield return new WaitForSeconds(delay);
        }
        StartCoroutine(endGame());
    }

    //Corrutina para acabar el juego
    IEnumerator endGame ()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("EndScreen");
    }
}
