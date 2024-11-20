namespace zombie_attack_main;

public class PotionBuilder
{
    private string name;
    private Rarity rarity;
    private int amount;
    public Potion HealthPotion(Rarity rarity)
    {
        this.rarity = rarity;
        switch (rarity)
        {
            case Rarity.Common:
                name = "Common Health Potion";
                amount = 2;
                break;
            case Rarity.Rare:
                name = "Rare Health Potion";
                amount = 5;
                break;
            case Rarity.Epic:
                name = "Epic Health Potion";
                amount = 10;
                break;
            default:
                break;
        }
        name = "HealthPotion";
        buffdebuff = new BuffDebuff(amount, Attributes.Health, null);
    }
}