using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    [SerializeField] public GameObject esfera;
    [SerializeField] public GameObject empty;
   
    void spawnSphere()
    {
        Vector3 sfr = empty.transform.position;
        Instantiate(esfera, sfr, Quaternion.identity);
    }
}
