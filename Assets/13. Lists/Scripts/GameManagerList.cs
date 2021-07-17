using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerList : MonoBehaviour
{
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public GameObject[] objectsToSpawn = new GameObject[10];

    private void Start()
    {
        // Elements accessed the same way, through an index.
        objectsToSpawn[2].name = "Jacob";
        enemiesToSpawn[2].name = "Kyle";
    }

}
