using System;

namespace OneDungeon
{
	public class Map
	{
		public double Lvl;
		public double hostility;
		public string name;
		public string description;
		public string modDescription;
		public Person warrior;

		public Map (string nm, string describe)
		{
			name = nm;
			description = describe;
		}
		public Map (double level)
		{
			Random rndm = new Random ();
			Map terrain = Objects.maps [rndm.Next(Objects.maps.Length)];
			MapMod mod = Mods.maps [rndm.Next(Mods.maps.Length)];

			Lvl = level;
			name = mod.adjective + " " + terrain.name;
			description = terrain.description;
			modDescription = mod.description;
			hostility = level + mod.hostility;
			Populate ();
		}

		public void Populate ()
		{
			Random rndm = new Random ();
			int minLevel = (hostility > Lvl) ? Convert.ToInt16(Lvl) : Convert.ToInt16(hostility);
			int maxLevel = (hostility > Lvl) ? Convert.ToInt16(hostility) : Convert.ToInt16(Lvl);
			if (minLevel < 1)
				minLevel = 1;

			warrior = new Person (rndm.Next(minLevel, maxLevel));
		}
		public void PrintStats ()
		{
			Console.WriteLine ("Lvl {0} {1}", Lvl, name);
			Console.WriteLine (description);
			Console.WriteLine (modDescription);
			Console.WriteLine ("----------------------------------------------------------------");
			warrior.PrintStats ();
			Console.WriteLine ("");
		}

		public void Walk ()
		{
			ConsoleKeyInfo direction = new ConsoleKeyInfo ();
			while (direction.KeyChar != 'n' && direction.KeyChar != 'e' && direction.KeyChar != 's' && direction.KeyChar != 'w') {
				Console.WriteLine ("Walk in which direction? \nN - North \nE - East \nS - South \nW - West");
				direction = Console.ReadKey ();
			}
			Console.Clear ();
			Map newMap;

			if (direction.KeyChar == 'n') {
				newMap = new Map (Lvl + 1);
				World.travelScore++;
			}
			else if (direction.KeyChar == 'e' || direction.KeyChar == 'w') {
				newMap = new Map (Lvl);
				World.travelScore++;
			}
			else {
				newMap = (Lvl > 1) ? new Map (Lvl - 1) : new Map (Lvl);
				World.travelScore--;
			}

			Console.WriteLine ("");
			newMap.PrintStats ();
			Console.ReadKey ();
			Console.Clear ();

			while (World.player.health > 0 && newMap.warrior.health > 0) {
				World.player.AttackSequence (newMap.warrior);
			}
			if (World.player.health <= 0) {
				for (;;) {
					Console.WriteLine ("You died, GAME OVER!!!");
					Console.WriteLine ("Score: {0}", (World.killCount * 10) + (World.coins * 100) + World.travelScore);
					Console.WriteLine ("Kills: {0} \nMoney: {1} \nTravel: {2}", World.killCount, World.coins, World.travelScore);
					Console.ReadKey ();
					Console.Clear ();
				}
			}
			else if (newMap.warrior.health <= 0) {
				Console.WriteLine ("{0} died...", newMap.warrior.name);
				World.player.health += World.player.health * 0.3;//Might need some tweaking...
				World.killCount++;
				World.player.DropSequence (newMap.warrior);
				Console.ReadKey ();
				Console.Clear ();
			}

			//enemes attack player
			newMap.Walk ();
		}
	}
}

