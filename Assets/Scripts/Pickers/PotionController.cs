using UnityEngine;

public class PotionController : MonoBehaviour {

    public new Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        rigidbody.AddForce(Vector3.up * 1, ForceMode2D.Impulse);
        if(StaticData.life < StaticData.maxLife)
        {
            StaticData.life += 30;
        }
        Destroy(gameObject, 2);
    }
}
