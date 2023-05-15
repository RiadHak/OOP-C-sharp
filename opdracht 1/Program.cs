bool answer;
do
{
    Console.WriteLine("wat is je Charmander's naam?");
    string char_name = Console.ReadLine(); ;
    Charmander ans = new Charmander(char_name, "Fire", "Water");
    for (int i = 0; i < 10; i++)
    {
        ans.battle_cry();
    }
    Console.WriteLine("wil je dooe spelen?(Y/N)");
    string inp = Console.ReadLine();
    answer = inp == "Y" ? true : false;

} while (answer);



//Charmander pokemon = new Charmander("riad","fire","water");
//pokemon.battle_cry();



class Charmander
{
    public string name;
    public string strength;
    public string weakness;

    public Charmander(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public void battle_cry()
    {
        Console.WriteLine(this.name + " is zijn Battlecry aan het doen? ");
    }
}