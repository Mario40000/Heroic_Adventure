using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HistoryScreenController : MonoBehaviour {

    public Text mainText;
    public int relay;

	// Use this for initialization
	void Start ()
    {
        mainText.text = "The story tells us that in these woods a dragon is hiding, which has a great treasure, but in order to reach the first one must pass through a barrier of magic fire that protects it, many have tried but have failed, will you Who can do it? Good luck, adventurer!";
        StartCoroutine(start());
    }
	
	IEnumerator start ()
    {
        yield return new WaitForSeconds(relay);
        SceneManager.LoadScene("Round1");
    }
}
