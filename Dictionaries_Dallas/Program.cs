using System.Collections.Generic;
using System.Collections;

//creats a dictionary method that with 10 vaules added to it
Dictionary<int, string> topGames = new Dictionary<int, string>();
topGames.Add(1, "tiny Tina's Wonderlands");
topGames.Add(2, "CS:GO");
topGames.Add(3, "Halo 3");
topGames.Add(4, "Elden Ring");
topGames.Add(5, "Sonic Adventure 2");
topGames.Add(6, "Kirby Airride");
topGames.Add(7, "Donkey Kong 64");
topGames.Add(8, "Runescape");
topGames.Add(9, "GTA: San Andress");
topGames.Add(10, "Valorant");

//call keyvaluepair for each of the topgames and writes it out to the console
foreach (KeyValuePair<int, string> kvp in topGames)
{
    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
}

//makes a if statment to check if topgames containskey 1 and if it dose prints out the following prhease to the console
if (topGames.ContainsKey(1))
{
    Console.WriteLine($"My favorite game is: {topGames[1]}");
}
//makes a string object named result and gives it a vaule of ""
string result = "";

topGames.TryGetValue(11, out result);
//creates a if statment to set result not equal to "" and then prints out results to the console
if (result != "")
{
    Console.WriteLine(result);
}
//if it dose contain"" then prints out there is no game in the eleventh position
else
{
    Console.WriteLine("There is no game in the eleventh position.");
}
//if statment that check if topgamescontains key 5 and if it dose prints out the following prash
if (topGames.ContainsKey(5))
{
    topGames[5] = "rocket League";
}
//writs topgames[5] to the console
Console.WriteLine(topGames[5]);

//crates a hashtable called haskTable and gives it a vaule of new Hashtable(topgames)
Hashtable haskTable = new Hashtable(topGames);

string favGame = (string)haskTable[1];
//prints follwoing prash to the console
Console.WriteLine($"Favorite Game: {favGame}");
//creats a Hashtable capitals and sets it equal to new Hashtable and gives it the following 4 vaules of string
Hashtable capitals = new Hashtable()
{
    { "Oklahoma", "Oklahoma city" },
    { "New york", "Albany" },
    { "Taxas", "Austin" },
    { "Ohio", "Colombus" }
};
//creats a foreach method to check each dictionaryenyry kvp in capitals and prints out the follwoing console.writeline
foreach (DictionaryEntry kvp in capitals)
{
    Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
}
//clears capitals.
capitals.Clear();