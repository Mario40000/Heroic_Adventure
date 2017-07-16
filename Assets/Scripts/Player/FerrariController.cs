using System.Collections;
using UnityEngine;

public class FerrariController : MonoBehaviour {

    public int speed;
    public int delay;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = (transform.right * speed);
        StartCoroutine(destroyer());
    }

    IEnumerator destroyer ()
    {
        yield return new WaitForSeconds(delay);
        StaticData.ferrari = 0;
        Destroy(gameObject);
    }
	
}
