using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour {

    public Scrollbar healthBar;
	// Update is called once per frame
	void Update ()
    {
        //actualizamos la barra de vida
        healthBar.size = StaticData.life / 100f;
	}
}
