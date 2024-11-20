namespace zombie_attack_main;

public class MonsterBuilder
{
    private Monster monster;

    public Monster normalZombie()
    {
        monster = new Monster("Normal Zombie", MonsterClass.Normal);
        return monster;
    }
}