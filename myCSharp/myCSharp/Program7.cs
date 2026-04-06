//public struct Stats
//{
//    public int Health;
//    public int Strength;
//    public int Agility;
//    public int IncreaseStrength(ref int value)
//    {
//        return Strength + value;
//    }
//}

//public class item
//{
//    public string Name;
//    public int Power;
//    private bool IsEquipped = false;

//    public bool Equip()
//    {
//        return IsEquipped = true;
//    }
//}

//public class Character
//{
//    public string Name;
//    public Stats CharacterStats;
//    public List<item> Inventory;

//    public void AddItem(item item)
//    {
//        List<item> list = new List<item>();
//    }

//    public void Train()
//    {
//       CharacterStats.Strength += 5;
//    }

//    void EquipFirstItem()
//    {
//        Inventory[0].Equip();
//    }
//}

//class Program
//{

//    static void ModifyItem(ref Character chat)
//    {
//        chat.Inventory[0].Power += 5;
//    }

//    static void BoostStats(Character character)
//    {
//        character.CharacterStats.Strength += 10;
//    }

//    static void Main()
//    {
//        Character hero = new Character();
//        hero.CharacterStats.Health = 100;
//        hero.CharacterStats.Strength = 10;
//        hero.CharacterStats.Agility = 15;
//        item sword = new item() {Name = "sword", Power = 25};
//        item shield = new item() {Name = "shield", Power = 15};
//        hero.AddItem(sword);
//        hero.AddItem(shield);
//        BoostStats(hero);
//        ModifyItem(ref hero);

//    }
//}
