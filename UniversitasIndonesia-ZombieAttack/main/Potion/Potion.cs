namespace zombie_attack_main;

public class Potion
{
    private string name;
    private Attributes attributes;
    private int amount;

    public Potion(string name, Attributes attributes, int amount)
    {
        this.name = name;
        this.attributes = attributes;
        this.amount = amount;
    }
}