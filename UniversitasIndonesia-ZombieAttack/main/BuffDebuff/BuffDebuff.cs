namespace zombie_attack_main;

public class BuffDebuff
{
    private string name;
    private int amount;
    private Attributes attributes;

    public BuffDebuff(int amount, Attributes attributes)
    {
        this.amount = amount;
        this.attributes = attributes;
    }
}