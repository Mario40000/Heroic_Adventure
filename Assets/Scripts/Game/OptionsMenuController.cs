using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenuController : MonoBehaviour {

    public Text exit;
    public Text reset;

    void Start ()
    {
        exit.text = "Press ESC for quit game";
        reset.text = "Press Space Bar to return";
    }

	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }

        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Splash");
        }
	}
}
