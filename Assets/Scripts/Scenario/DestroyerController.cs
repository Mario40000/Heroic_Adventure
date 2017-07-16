using UnityEngine;

public class DestroyerController : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other);
            StaticData.ferrari = 0;

        }
    }

}