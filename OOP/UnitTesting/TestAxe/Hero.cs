public class Hero
{
    private string name;
    private int experience;
    private Axe weapon;

    public Hero(string name)
    {
         this.name = name;
         experience = 0;
         weapon = new Axe(10, 10);
    }

    public string Name
    {
        get { return  name; }
    }

    public int Experience
    {
        get { return  experience; }
    }

    public Axe Weapon
    {
        get { return  weapon; }
    }

    public void Attack(Dummy target)
    {
         weapon.Attack(target);

        if (target.IsDead())
        {
             experience += target.GiveExperience();
        }
    }
}
