using UnityEngine;

public class GoldCoinController : MonoBehaviour {

    public new Rigidbody2D rigidbody;
    public int goldValue;

    // Use this for initialization
    void Start()
    {
        rigidbody.AddForce(Vector3.up * 1, ForceMode2D.Impulse);
        StaticData.gold += goldValue;
        Destroy(gameObject, 2);
    }
}

