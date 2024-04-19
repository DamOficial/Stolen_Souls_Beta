public class ItemBase
{
    public string name;
    public string description;
    public float weight;
    public int value;

    public virtual void Use() { } // Método base para usar el objeto
}
