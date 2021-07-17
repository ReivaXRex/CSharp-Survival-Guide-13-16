using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildListChallenge : MonoBehaviour
{
    public GameObject[] SpawnList = new GameObject[3];
    public List<GameObject> objectsCreated = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && objectsCreated.Count < 10)
        {
            // Select a random object to spawn from the Array.
            GameObject objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];

            // Create random x axis and y axis values and assign them to a Vector3.
            int randomPosX = Random.Range(-10, 10);
            int randomPosY = Random.Range(-10, 10);
            Vector3 randomPos = new Vector3(randomPosX, randomPosY, 0);

            // Spawn the randomly selected Object from the Array at the andom osition Vector3 created above &
            // store the spawnedObject in a variable.
            GameObject SpawnedObject = Instantiate(objectToSpawn, randomPos, Quaternion.identity);

            // Add the object created to the List.
            objectsCreated.Add(SpawnedObject);

            if (objectsCreated.Count == 10)
            {
                foreach (var obj in objectsCreated)
                {
                    obj.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                objectsCreated.Clear();
            }

        }

    }
}
