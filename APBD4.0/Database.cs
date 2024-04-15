namespace APBD4._0;

public class Database
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public Database()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}