using UnityEngine;

public class WheelFerrariController : MonoBehaviour {

    public Transform wheel;

    void Update ()
    {
        wheel.Rotate(Vector3.forward * 90);
    }
}
