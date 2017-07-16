using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject mainBgm;
    public Text missionText;
    public GameObject player;
    public Transform spawner;
     
	// Use this for initialization
	void Start ()
    {

        Instantiate(player, spawner.position, Quaternion.identity);
        textController();
        staticDataController();
	}
	
	// Update is called once per frame
	void Update ()
    {
        textController();

        if (StaticData.life <= 0)
        {
            StartCoroutine(gameOver());
        }
	
	}

    IEnumerator gameOver ()
    {
        mainBgm.GetComponent<AudioSource>().Stop();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("GameOver");
    }

    //Actualizamos el mensaje de pista segun avanzamos
    public void textController ()
    {
        if(StaticData.stage == 2)
        {
            missionText.text = "Kill the dragon";
        }
        else
        {
            if (StaticData.goal == 1)
            {
                missionText.text = "Well done!";
            }
            else
            {
                if (StaticData.extinghiser == 0)
                {
                    missionText.text = "Find the magic relic";
                }
                if (StaticData.extinghiser == 1)
                {
                    missionText.text = "Cross the magic fire barrier";
                }
            }
        }
    }

    //Actualizamos los datos estaticos
    void staticDataController ()
    {
        if(StaticData.stage == 1)
        {
            StaticData.extinghiser = 0;
            StaticData.gold = 0;
            StaticData.life = 100;
            StaticData.goal = 0;
            StaticData.ferrari = 0;
        }
        if(StaticData.stage == 2)
        {
            StaticData.goal = 0;
        }
    }

}
