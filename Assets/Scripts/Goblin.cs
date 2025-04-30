public class Goblin : Characters
{
    public Goblin()
    {
        this.damage = 10;
        this.health = 100;
    }
    public override float Attack()
    {
        if (health < 20)
        {
            return damage * 3;
        }
        return damage;
    }
    public override float Heal()
    {
        health += damage / 2;
        if (health >= 150)
        {
            health = 150;
        }
        return health;
    }
}
