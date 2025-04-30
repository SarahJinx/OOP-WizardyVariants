using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Characters
{
    public Sukamon()
    {
        this.damage = 1;
        this.health = 100;
    }
    public override float Attack()
    {
        if (health < 5)
        {
            return 100;
        }
        return damage;
    }
    public override float Heal()
    {
        health += damage / 3;
        if (health >= 150)
        {
            health = 150;
        }
        return health;
    }
}