namespace zombie_attack_main;

class Monster //basic default monsters
{
    private string name;
    private MonsterClass monsterClass;
    private int health = 3;
    private int basicDamage = 2;
    private int attackSpeed = 1;
    private int defense = 1;
    private Ability ability = null;
    private int abilityTiming = null;

    public Monster(string name, MonsterClass monsterClass)
    {
        this.name = name;
        this.monsterClass = monsterClass;
    }

    public void setBasicDamage(int damage)
    {
        this.basicDamage = damage;
    }
    public void setHealth(int health)
    {
        this.health = health;
    }

    public void setDefense(int defense)
    {
        this.defense = defense;
    }

    public void setAttackSpeed()
    {
        this.attackSpeed = attackSpeed;
    }
}