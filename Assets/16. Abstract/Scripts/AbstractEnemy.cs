using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemy : MonoBehaviour
{
    public int health;
    public int speed;
    public int gems;

    public abstract void Attack();

    public virtual void Die()
    {
        Destroy(this.gameObject);    
    }

    public class MossGiant : AbstractEnemy
    {
        public override void Attack()
        {
            throw new System.NotImplementedException();
        }
        public override void Die()
        {
            // Custom particles for Moss Giant death.

            base.Die();
        }
    }

    
}
