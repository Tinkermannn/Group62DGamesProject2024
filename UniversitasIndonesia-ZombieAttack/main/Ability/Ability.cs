namespace zombie_attack_main;

public class Ability
{
    private string abilityName;
    private string abilityDescription;
    private AbilitySpecialEffect abilitySpecialEffect;
    private AbilityTarget abilityTarget;
    private int damage;
    
    public Ability(string abilityName, string abilityDescription, AbilitySpecialEffect abilitySpecialEffect, AbilityTarget abilityTarget, int damage)
    {
        this.abilityName = abilityName;
        this.abilityDescription = abilityDescription;
        this.abilitySpecialEffect = abilitySpecialEffect;
        this.abilityTarget = abilityTarget;
        this.damage = damage;
    }
}