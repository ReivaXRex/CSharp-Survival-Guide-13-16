using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryPrimitive : MonoBehaviour
{
    // public Dictionary<string, int> people = new Dictionary<string, int>();
    
    public Dictionary<int, string> books = new Dictionary<int, string>();

    // Start is called before the first frame update
    void Start()
    {
        books.Add(0, "Book One: Volume A");
        books.Add(1, "Book One: Volume B");
        books.Add(2, "Book Two: Volume A");
        books.Add(3, "Book Two: Volume B");

        // Debug.Log(books[2]);

        foreach (KeyValuePair<int, string> book in books)
        {
            Debug.Log(book.Value);
        }

        foreach (string book in books.Values)
        {
            Debug.Log("Title: " + book);
        }

        #region People & Age
        /*
        people.Add("Alex", 26);
        people.Add("Bryan", 34);
        people.Add("Cynthia", 18);
        people.Add("Darlene", 42);

        int alexAge = people["Alex"];
        Debug.Log("Alex's age is " + alexAge);
        */
        #endregion
    }

}
