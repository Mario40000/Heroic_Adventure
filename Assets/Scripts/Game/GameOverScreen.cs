using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        StartCoroutine(start());
        StaticData.stage = 1;
    }

    //Metodo para volver al titulo despues del game over
    IEnumerator start ()
    {
        yield return new WaitForSeconds(25);
        SceneManager.LoadScene("Splash");
    }
	
}
