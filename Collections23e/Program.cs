// See https://aka.ms/new-console-template for more information


using Collections23e;

//List<int> myList = new List<int>();
//myList.Add(10);
//myList.Add(20);
//myList.Add(30);
//myList.Insert(1, 15);
//myList[1] = 32;
//myList.Remove(20);
//myList.Insert(0, myList[2]);

//myList.Sort();

//foreach (var item in myList)
//{
//    Console.Write(item + " ");
//}

Player p1 = new Player(1, PlayerType.Warrior, "Fnuggi");
Player p2 = new Player(2, PlayerType.Cleric, "Huggi");


List<Player> players  = new List<Player>() { p1, p2, new Player(3, PlayerType.Mage, "Muggi")};

Console.WriteLine( players[2].Name );


foreach( Player p in players )
{
    Console.WriteLine( p.ToString() );

}


Player p4 = new Player(4, PlayerType.Sorcerer, "Gummi");
players.Add( p4 );

//players.Add( new Player(5, "Sailor", "Summi"));

//players.Add(new Player(1, "Warrior", "Fnuggi"));

//players.Add(p1 );
//players.RemoveAt( 1 );
//players.Remove( p2 );

//Console.WriteLine(players[1] );

int j = players.Count-1;
while(j>=0 )
{
    Console.WriteLine(players[j].ToString() );
    j--;
}

Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();
playerDictionary.Add(1, p1);
playerDictionary.Add(p2.Id, p2);
playerDictionary.Add(p4.Id, p4);

Console.WriteLine(playerDictionary[4]);

Dictionary<string,Player> playerNames = new Dictionary<string,Player>();

playerNames.Add(p1.Name, p1);
playerNames.Add(p2.Name, p2);
playerNames.Add(p4.Name, p4);


Console.WriteLine("Dictionary med name som key");
foreach(Player p in playerNames.Values)
{
    Console.WriteLine(p.ToString() );
}

Console.WriteLine("Udskrivning af keys");
foreach (string name in playerNames.Keys)
{
    Console.WriteLine(name);
}

if ( !playerNames.ContainsKey("Fnuggi") )
    playerNames.Add("Fnuggi", new Player(34, PlayerType.Mage, "Figgi") );




