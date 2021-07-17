using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable<T> 
{
    // int health; 
    // NO FIELDS

    int Health { get; set; }

    void Damage(T damageAmount);
    // void Damage(float damageAmount);
}
