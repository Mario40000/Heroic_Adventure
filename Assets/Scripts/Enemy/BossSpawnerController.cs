using UnityEngine;

public class BossSpawnerController : MonoBehaviour {

    public GameObject boss;
    public Transform spawner;
    private int count = 1;

    //Instanciamos al boss al pisar el trigger
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (count > 0)
            {
                count--;
                Instantiate(boss, spawner.position, Quaternion.identity);
            }
            
        }
    }
}
