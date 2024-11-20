namespace zombie_attack_main;

public class BuffDebuff
{
    private string name;
    private int amount;
    private int duration;
    private Attributes attributes;

    public BuffDebuff(int amount, Attributes attributes, int duration)
    {
        this.amount = amount;
        this.attributes = attributes;
        this.duration = duration;
    }
}