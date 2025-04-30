using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Cowboy : Characters
{
    public Cowboy(string name) : base(name, Resources.Load<Sprite>("Resources/Sprites/Cowboy"), 100)
    {
        this.damage = 15;
    }
    public override float Attack()
    {
        damage *= Random.Range(1, 1.5f);
        return damage;
    }
    public override float Heal()
    {
        health += 10;
        if (health >= 150)
        {
            health = 150;
        }
        return health;
    }
}