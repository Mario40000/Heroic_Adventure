using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreenController : MonoBehaviour {

    public Text congratsText;
    public Text endText1;
    public Text endText2;
    public Text endText3;
    public Text resetText;


    // Use this for initialization
    void Start ()
    {
        congratsText.text = "Congratulations!";
        endText1.GetComponent<Text>().enabled = false;
        endText2.GetComponent<Text>().enabled = false;
        endText3.GetComponent<Text>().enabled = false;
        resetText.GetComponent<Text>().enabled = false;
        StartCoroutine(finalText());

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            StaticData.stage = 1;
            SceneManager.LoadScene("Splash");
        }
	
	}

    //Metodo para hacer aparecer los textos finales
    IEnumerator finalText ()
    {
        yield return new WaitForSeconds(2);
        endText1.text = "You have managed to kill the dragon and become incredibly rich and famous";
        endText1.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(4);
        endText2.text = "Finally you will realize your dreams of having a Ferrari and going out with girls!";
        endText2.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(4);
        endText3.text = "Thanks for playing";
        endText3.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(6);
        resetText.text = "Press Space Bar to return menu";
        resetText.GetComponent<Text>().enabled = true;

    }
}
