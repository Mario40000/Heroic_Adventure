using UnityEngine;

public class FireController : MonoBehaviour {

    public float delay;

    void Start ()
    {
        //Matamos el fuego segun el delay
        Destroy(gameObject, delay);
    }
}
