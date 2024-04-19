public class Weapon : ItemBase
{
    public int damage;
    public int ammo;

    public override void Use()
    {
        // Implementar la lógica para disparar el arma
    }
}

public class Ammunition : ItemBase
{
    public int amount;
    public Weapon compatibleWeapon;

    public override void Use()
    {
        // Implementar la lógica para usar la munición con el arma compatible
    }
}

public class HealthKit : ItemBase
{
    public int healAmount;

    public override void Use()
    {
        // Implementar la lógica para usar el botiquín de primeros auxilios y curar al jugador
    }
}

public class Key : ItemBase
{
    public string doorName;

    public override void Use()
    {
        // Implementar la lógica para usar la llave y desbloquear la puerta correspondiente
    }
}
