using UnityEngine;

public class DeadEnemyController : MonoBehaviour {

    public int delay;

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, delay);
	}
	
}
