using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Characters
{
    public float health;
    private Sprite sprite;
    private string name;
    protected float damage;

    public Characters() { }
    public Characters(string name, Sprite spr,  float damage)
    {
        this.name = name;
        this.sprite = spr;
        this.damage = damage;
        this.health = 100;
    }
    public abstract float Attack();
    public virtual float Heal()
    {
        health += damage / 2;
        if (health > 100) { health = 100; }
        return health;
    }
    public string GetName()
    {
        return name;
    }
    public Sprite GetSprite() 
    { 
        return sprite; 
    }
    public float GetDamage()
    {
        return damage;
    }
}