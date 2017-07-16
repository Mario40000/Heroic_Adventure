using UnityEngine;
using UnityEngine.UI;

public class ExtinghiserHudController : MonoBehaviour {

    public GameObject extinghiser;

	// Use this for initialization
	void Start ()
    {
        extinghiser.GetComponent<Image>().enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(StaticData.extinghiser == 1)
        {
            extinghiser.GetComponent<Image>().enabled = true;
        }
	}
}
