using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC
{
    public string namePC;
    public int idPC;

    public PlayerC(int id)
    {
        this.idPC = id;
    }

}


public class PlayerConnect : MonoBehaviour
{
    public Dictionary<int, PlayerC> playerDictionary = new Dictionary<int, PlayerC>();
    PlayerC p4 = new PlayerC(4);

    // Start is called before the first frame update
    void Start()
    {
        PlayerC p1 = new PlayerC(1);
        p1.namePC = "Myles";
        PlayerC p2 = new PlayerC(2);
        p2.namePC = "Joe";
        PlayerC p3 = new PlayerC(3);
        p3.namePC = "Josh";

        p4.namePC = "Xavier";


        playerDictionary.Add(p1.idPC, p1);
        playerDictionary.Add(p2.idPC, p2);
        playerDictionary.Add(p3.idPC, p3);
        playerDictionary.Add(p4.idPC, p4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[2];
            Debug.Log(player.namePC);

            var player2 = playerDictionary[p4.idPC];
            Debug.Log(player2.namePC);
        }
    }
}
