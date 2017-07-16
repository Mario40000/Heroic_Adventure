using UnityEngine;
using UnityEngine.UI;

public class GoldCoinsTextController : MonoBehaviour {

    public Text goldText;

	// Use this for initialization
	void Start ()
    {
        goldText.text = StaticData.gold + "";
	}
	
	// Update is called once per frame
	void Update ()
    {
        goldText.text = StaticData.gold + "";
    }
}
