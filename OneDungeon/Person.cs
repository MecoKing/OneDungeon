using System;

namespace OneDungeon
{
	public class Person
	{
		public double Lvl;
		public string name;
		public double health;
		public double energy;
		public double strength;
		public bool isBlocking;

		public Race species;
		public Consumable food;
		public Weapon item;
		public Armour[] clothing;

		public Person (double level)
		{
			species = new Race (level);
			food = new Consumable (level);
			item = new Weapon (level);
			clothing = new Armour[5];
			Clothe (level);

			Lvl = level;
			name = species.name;
			health = species.health;
			energy = species.energy;
			strength = species.strength;
			isBlocking = false;
		}

		public void Clothe (double level)
		{
			for (int bodyPos = 0; bodyPos < 5; bodyPos++) {
				Armour cloth = new Armour (level);
				while (cloth.bodyPosition != bodyPos) {
					cloth = new Armour (level);
				}
				clothing [bodyPos] = cloth;
			}
		}
		public void PrintStats ()
		{
			Console.WriteLine ("CHARACTER:");
			Console.WriteLine ("Lvl {0} {1}", Lvl, name);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Hlth: " + health);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine ("Enrgy: " + energy);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("Strngth: " + strength);
			Console.ForegroundColor = ConsoleColor.White;

			Console.WriteLine ("WEAPON:");
			item.PrintStats ();
			Console.WriteLine ("ARMOUR:");
			for (int i = 0; i < clothing.Length; i++) {
				clothing [i].PrintStats ();
			}
			Console.WriteLine ("INVENTORY:");
			food.PrintStats ();
		}

		public double Damage ()
		{
			return item.damage + (strength / 5);
		}
		public double Defense (int bodyPos)
		{
			if (isBlocking)
				return clothing [bodyPos].shield + item.shield + strength;
			else
				return clothing [bodyPos].shield + (strength / 5);
		}

		public void AttackSequence (Person foe) {
			energy += energy * 0.1;
			foe.energy += foe.energy * 0.1;
			if (energy > 10000)
				energy = 10000;
			if (foe.energy > 10000)
				foe.energy = 10000;
			if (health > 500)
				health = 500;
			if (energy < 0)
				energy *= -1;
			if (foe.energy < 0)
				foe.energy *= -1;

			Random rndm = new Random ();


			int move = rndm.Next (8);
			if (move == 0 || move == 1 || move == 2 || move == 3) {
				foe.isBlocking = false;
				foe.Attack (this, rndm.Next (5));
			}
			else if (move == 4 || move == 5 || move == 6) {
				foe.isBlocking = true;
				Console.WriteLine ("{0} Blocked!", foe.name);
			}
			else {
				foe.health += foe.food.healthRegen;
				foe.energy += foe.food.energyRegen;
				foe.strength += foe.food.energyRegen;
				Console.WriteLine ("{0} ate {1}", foe.name, foe.food.name);
				foe.food = new Consumable ("Nothing", 0, 0, 0);
			}


			ConsoleKeyInfo action = new ConsoleKeyInfo ();
			while (action.KeyChar != 'a' && action.KeyChar != 'b' && action.KeyChar != 'e') {
				Console.WriteLine ("Action: \nA - Attack \nB - Block \nE - Eat");
				action = Console.ReadKey ();
			}
			Console.Clear ();

			if (action.KeyChar == 'a') {
				isBlocking = false;
				ConsoleKeyInfo target = new ConsoleKeyInfo ();
				int targetArea;

				while (target.KeyChar != '0' && target.KeyChar != '1' && target.KeyChar != '2' && target.KeyChar != '3' && target.KeyChar != '4') {
					Console.WriteLine ("Target: \n0 - Head ({0}) \n1 - Chest ({1}) \n2 - Arms ({2}) \n3 - Legs ({3}) \n4 - Feet ({4})",
					                   foe.clothing[0].name, foe.clothing[1].name, foe.clothing[2].name, foe.clothing[3].name, foe.clothing[4].name);
					target = Console.ReadKey ();
				}
				Console.Clear ();

				if (target.KeyChar == '0')
					targetArea = 0;
				else if (target.KeyChar == '1')
					targetArea = 1;
				else if (target.KeyChar == '2')
					targetArea = 2;
				else if (target.KeyChar == '3')
					targetArea = 3;
				else
					targetArea = 4;

				Attack (foe, targetArea);
			}
			else if (action.KeyChar == 'b') {
				Console.WriteLine ("You Block");
				isBlocking = true;
			}
			else if (action.KeyChar == 'e') {
				Console.WriteLine ("You ate a {0}", food.name);
				health += food.healthRegen;
				energy += food.energyRegen;
				strength += food.strengthRegen;
				food = new Consumable ("Nothing", 0, 0, 0);
				PrintStats ();
				Console.ReadKey ();
				Console.Clear ();
			}
		}
		public void Attack (Person foe, int targetArea)
		{
			string bodyPart;
			if (targetArea == 0)
				bodyPart = "Head";
			else if (targetArea == 1)
				bodyPart = "Chest";
			else if (targetArea == 2)
				bodyPart = "Arms";
			else if (targetArea == 3)
				bodyPart = "Legs";
			else
				bodyPart = "Feet";

			if (energy - item.energyUse > 0) {
				if (foe.isBlocking) {
					Console.WriteLine ("{0} {1} {2} in the {3} with {4}", name, item.action, foe.name, bodyPart, item.name);
					Console.WriteLine ("{0} blocked the attack", foe.name);
					energy -= foe.item.energyUse / 4;
				} else {
					Console.WriteLine ("{0} {1} {2} in the {3} with {4}", name, item.action, foe.name, bodyPart, item.name);
				}
				double atk = Damage();
				double def = foe.Defense(targetArea);
				foe.health -= (atk - def > 0) ? atk - def : 0;
				energy -= item.energyUse;

				Console.WriteLine ("");
				foe.PrintStats ();
				Console.ReadKey ();
				Console.Clear ();
			}
			else {
				Console.WriteLine ("{0} is too tired to attack...", name);
			}
		}

		public void DropSequence (Person foe) {
			Random rndm = new Random ();
			int drop = rndm.Next (3);
			ConsoleKeyInfo response = new ConsoleKeyInfo ();

			if (drop == 0) {
				Console.WriteLine ("{0} dropped: {1}. Pick up? y / n", foe.name, foe.item.name);
				foe.item.PrintStats ();
				Console.WriteLine ("");
				item.PrintStats ();
				Console.WriteLine ("");
				while (response.KeyChar != 'y' && response.KeyChar != 'n') {
					response = Console.ReadKey ();
				}
				Console.Clear ();
				if (response.KeyChar == 'y') {
					Console.WriteLine ("You dropped: {0}, \nYou picked up: {1}", item.name, foe.item.name);
					item = foe.item;
				}
			}
			else if (drop == 1) {
				Console.WriteLine ("{0} dropped: {1}. Pick up? y / n", foe.name, foe.food.name);
				foe.food.PrintStats ();
				Console.WriteLine ("");
				food.PrintStats ();
				Console.WriteLine ("");
				while (response.KeyChar != 'y' && response.KeyChar != 'n') {
					response = Console.ReadKey ();
				}
				if (response.KeyChar == 'y') {
					Console.WriteLine ("You dropped: {0}, \nYou picked up: {1}", food.name, foe.food.name);
					food = foe.food;
				}
			}
			else {
				int bodyPart = rndm.Next (5);
				Console.WriteLine ("{0} dropped: {1}. Pick up? y / n", foe.name, foe.clothing[bodyPart].name);
				foe.clothing[bodyPart].PrintStats ();
				Console.WriteLine ("");
				clothing[bodyPart].PrintStats ();
				Console.WriteLine ("");
				while (response.KeyChar != 'y' && response.KeyChar != 'n') {
					response = Console.ReadKey ();
				}
				if (response.KeyChar == 'y') {
					Console.WriteLine ("You dropped: {0}, \nYou picked up: {1}", clothing[bodyPart].name, foe.clothing[bodyPart].name);
					clothing[bodyPart] = foe.clothing[bodyPart];
				}
			}
			int coinCount = rndm.Next (100, 2001);
			Console.WriteLine ("You gained {0} coins", coinCount);
			World.coins += coinCount;

			Console.ReadKey ();
			Console.Clear ();
			PrintStats ();
		}
	}
}

