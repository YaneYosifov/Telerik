public class Chef
{
    public void Cook()
    {
        Carrot carrot = this.GetCarrot();
        var peeledCarrot = Peel(carrot);
        var cutCarrot = this.Cut(peeledCarrot);
        Bowl bowl = this.GetBowl();
        bowl.Add(cutCarrot);

        Potato potato = this.GetPotato();
        var peeledPotato = Peel(potato);
        var cutPotato = this.Cut(peeledPotato);
        bowl.Add(cutPotato);
    }

    private Carrot GetCarrot()
    {
        // ...
    }

    private Potato GetPotato()
    {
        // ...
    }

    private void Cut(Vegetable potato)
    {
        // ...
    }

    private Bowl GetBowl()
    {
        // ... 
    }
}