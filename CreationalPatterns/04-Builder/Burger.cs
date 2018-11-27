public class Burger
{
    public Burger(BurgerBuilder burgerBuilder)
    {
        this.size = burgerBuilder.Size;
        this.hasLettuce = burgerBuilder.HasLettuce;
        this.hasPepproni = burgerBuilder.HasPepproni;
        this.hasTomato = burgerBuilder.HasTomato;
    }
    private int size;
    private bool hasPepproni;
    private bool hasTomato;
    private bool hasLettuce;
}