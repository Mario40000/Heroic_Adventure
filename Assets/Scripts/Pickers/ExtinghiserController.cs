using UnityEngine;

public class ExtinghiserController : MonoBehaviour {

    public new Rigidbody2D rigidbody;

	// Use this for initialization
	void Start ()
    {
        rigidbody.AddForce(Vector3.up * 1, ForceMode2D.Impulse);
        StaticData.extinghiser = 1;
        Destroy(gameObject, 2);
    }

}
