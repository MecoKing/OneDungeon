using System;

namespace OneDungeon
{
	class World
	{
		public static Person player = new Person (1);
		public static int killCount = 0;
		public static int coins = 0;
		public static int travelScore = 0;

		public static void Main (string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;

			OpeningDialogue ();

			Console.Write ("YOUR ");
			player.PrintStats ();
			Console.ReadKey ();
			Console.Clear ();

			for (;;) {
				Map terrain = new Map (1);
				terrain.Walk ();

				Console.ReadKey ();
			}
		}

		static void OpeningDialogue ()
		{
			double armourCount = Objects.armours.Length * Mods.armours.Length;
			double weaponCount = Objects.weapons.Length * Mods.weapons.Length;
			double foodCount = Objects.foods.Length * Mods.foods.Length;
			double skillCount = Objects.skills.Length * Mods.skills.Length;
			double raceCount = Objects.races.Length * Mods.races.Length;
			double peopleCount = raceCount * weaponCount * foodCount * (armourCount * 5) * skillCount;
			peopleCount *= (peopleCount < 0) ? -1 : 1;
			double mapCount = Objects.maps.Length * Mods.maps.Length;


			Console.WriteLine ("ONEDUNGEON is a dungeon-crawler RPG written in C# by Micah Merswolke...");
			Console.WriteLine ("OneDungeon is currently offering up to {0} armours, {1} weapons, {2} consumables, {3} races, {4} classes totalling {5} unique characters, along with {6} different maps!", armourCount, weaponCount, foodCount, raceCount, skillCount, peopleCount, mapCount);
			Console.WriteLine ("");
			Console.WriteLine ("Feel free to mess around with the various objects and modifiers in the Objects.cs and Mods.cs files!");
			Console.WriteLine ("");
			Console.WriteLine ("-----");
			Console.WriteLine ("");
			Console.Write ("OneDungeon is an infinite procedurally generated dungeon crawler where everything is unique... ");
			Console.Write ("Every character has ONE weapon, ONE consumable and ONE of each type of armour... ");
			Console.Write ("Every item and map has ONE modifier that changes the item or map's stats and descriptions...");
			Console.WriteLine ("\n");
			Console.Write ("Difficulty increases the further NORTH you travel... and decreases the further SOUTH you travel... ");
			Console.Write ("The lowest level in the game is 1, no map will be easier, however the maps can increase in difficulty infinitely... ");
			Console.Write ("EAST to WEST the level stays the same. ");
			Console.WriteLine ("As well map modifiers change the difficulty of enemies in relation to the map difficulty. ");
			Console.WriteLine ("\n");
			Console.Write ("Enjoy!!!");
			Console.ReadKey ();
			Console.Clear ();
		}
	}
}
