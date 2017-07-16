using UnityEngine;

public class CameraController : MonoBehaviour {

    //Variables

    private GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        //Actualizamos la posicion de la camara
        if (player != null)
        {
                transform.position = new Vector3(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.y, transform.position.z);
            
        }

    }
}
