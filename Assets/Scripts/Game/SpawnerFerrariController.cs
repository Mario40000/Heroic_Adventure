using UnityEngine;

public class SpawnerFerrariController : MonoBehaviour {

    public GameObject ferrari;
    public Transform instancier;

    //Instanciamos el ferrari cada vez que desaparezca
	// Update is called once per frame
	void Update ()
    {
	    if( StaticData.ferrari == 0)
        {
            StaticData.ferrari = 1;
            Instantiate(ferrari, instancier.position, Quaternion.identity);
        }
	}
}
