using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour, IDamageable<int>
{
    public int Health { get; set; }
    public int _health;
    private void Start()
    {
        _health = Health;
        _health = 50;
    }

    public void Damage(int damageAmount)
    {
        _health -= damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log(damageAmount);
    }
}
