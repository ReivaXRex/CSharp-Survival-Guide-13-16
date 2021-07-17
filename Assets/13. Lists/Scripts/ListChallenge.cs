using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListChallenge : MonoBehaviour
{
    public List<string> names = new List<string>();

    void Start()
    {
        foreach (var name in names)
        {
            Debug.Log(name);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var nameToRemove = names[Random.Range(0, names.Count)]; // Create a variable to hold a random name taken from the list.
            names.Remove(nameToRemove); // Remove an element from a list using a string.

            foreach (var name in names)
            {
                Debug.Log(name);
            }

            Debug.Log("Removed: " + nameToRemove);
        }
    }
}
