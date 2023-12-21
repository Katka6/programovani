

//string[] pokemons = File.ReadAllLines("pokedex.txt");

//foreach (string pokemon in pokemons)
//{
 //   Console.WriteLine(pokemon);
//}


//StreamReader reader = new StreamReader("pokedex.txt");

//while (!reader.EndOfStream)
//{
//    string line = reader.ReadLine();
//  Console.WriteLine(line);
//}

//using (StreamReader using_reader = new StreamReader("pokedex.txt"))
//{
//    while (!using_reader.EndOfStream)
 //   {
   //     string line = using_reader.ReadLine();
 //       Console.WriteLine(line);
 //   }
//}
//Console.WriteLine();
//if (File.Exists("favorite.txt"))
//{
 //   string previousFavorite = File.ReadAllText("favorite.txt");
 //   Console.WriteLine("your previous favorite pokemon was:");
//    Console.WriteLine(previousFavorite);
//}
//else
//{
//    Console.WriteLine("you dont have a favorite pokemon.");
//}

//string previousFavorite = File.ReadAllText("favorite.txt");
//Console.WriteLine("your favorite pokemon is");
//Console.WriteLine(previousFavorite);

//Console.WriteLine("what's your favorite pokemon?");
//string favorite = Console.ReadLine();
//File.WriteAllText("pokedex.txt", favorite);






string[] pokemonStats = File.ReadAllLines("pokedex.txt");

foreach (string pokemon in pokemonStats)
{
   //Console.WriteLine(pokemon);
    string[] parts = pokemon.Split(',');
    Console.Write(parts[0]);
    Console.WriteLine("Name:" + parts[1]);
    Console.WriteLine("Type 1:" + parts[2]);
    Console.WriteLine("Type 2:" + parts[3]);
}

























