public class BurgerBuilder
{
    public BurgerBuilder(int size)
    {
        this.Size = size;    
    }

    public int Size { get; set; }
    public bool HasPepproni { get; set; }
    public bool HasLettuce { get; set; }
    public bool HasTomato { get; set; }

    
    public BurgerBuilder AddPepporini()
    {
        this.HasPepproni = true;
        return this;
    }

    public BurgerBuilder AddTomato()
    {
        this.HasTomato = true;
        return this;
    }

    public BurgerBuilder AddLettuce()
    {
        this.HasLettuce = true;
        return this;
    }
}