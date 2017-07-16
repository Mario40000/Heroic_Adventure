using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    public Text play;
    public Text options;

    void Start ()
    {
        play.text = "Press Space bar to play";
        options.text = "Press CTRL for options";
    }

	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("HistoryScreen");
        } 

        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("OptionsMenu");
        }
  
	}

}
