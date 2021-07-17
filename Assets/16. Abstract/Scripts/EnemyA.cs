using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour, IDamageable<float>, Shoot
{
    public int Health { get; set; }

    private void Start()
    {
        Health = 50;
    }

    public void Damage(float damageAmount)
    {
        Health -= (int)damageAmount;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }

    /* public void Damage(float damageAmount)
    {
        throw new System.NotImplementedException();
    }
    */

}
