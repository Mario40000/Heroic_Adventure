using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {

    public int delay;
    public Transform instancier;
    public GameObject enemy;

    private int charge = 1;

    void Update ()
    {
        if (charge == 1)
        {
            StartCoroutine(enemyInstancier());
            charge = 0;
        }
    }
	
	//Metodo para instanciar enemigos cada x tiempo
    IEnumerator enemyInstancier ()
    {
        Instantiate(enemy, instancier.position, Quaternion.identity);
        yield return new WaitForSeconds(delay);
        charge = 1;
    }
}
