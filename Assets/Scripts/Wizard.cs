using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Characters
{
    private float damageMarkeplier;

    public Wizard(float damageMarkeplier, string name) : base(name, Resources.Load<Sprite>("Resources/Sprites/Wizard"), 100)
    {
        this.damage = 20;
        this.damageMarkeplier = damageMarkeplier;
    }
    public override float Attack()
    {
        return damage * damageMarkeplier;
    }
    public override float Heal()
    {
        health += Random.Range(damage, damage * damageMarkeplier);
        if (health >= 150)
        {
            health = 150;
        }
        return health;
    }   
}
