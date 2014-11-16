using System;

namespace OneDungeon
{
	public class Item
	{
		public Item ()
		{
		}
	}

	public class Weapon : Item
	{
		public double Lvl;
		public string name;
		public string action;
		public double damage;
		public double shield;
		public double energyUse;

		public Weapon (string nm, string act, double atk, double def, double enrgy)
		{
			name = nm;
			action = act;
			damage = atk;
			shield = def;
			energyUse = enrgy;
		}
		public Weapon (double level)
		{
			Random rndm = new Random ();
			Weapon weapon = Objects.weapons [rndm.Next(Objects.weapons.Length)];
			WeaponMod mod = Mods.weapons [rndm.Next(Mods.weapons.Length)];

			Lvl = level;
			name = mod.adjective + " " + weapon.name;
			action = mod.adverb + " " + weapon.action;
			damage = (weapon.damage + (weapon.damage * (mod.damage / 100) * (Lvl / 100)));
			shield = (weapon.shield + (weapon.shield * (mod.shield / 100) * (Lvl / 100)));
			energyUse = (weapon.energyUse + (weapon.energyUse * (mod.energyUse / 100) * (Lvl / 100)));
		}

		public void PrintStats ()
		{
			Console.WriteLine ("Lvl {0} {1}", Lvl, name);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Atk: " + damage);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("Def: " + shield);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine ("Enrgy: " + energyUse);
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
	public class Armour : Item
	{
		public double Lvl;
		public string name;
		public int bodyPosition;
		public double shield;

		public Armour (string nm, double def, int bodyPos)
		{
			name = nm;
			bodyPosition = bodyPos;
			shield = def;
		}
		public Armour (double level)
		{
			Random rndm = new Random ();
			Armour armour = Objects.armours [rndm.Next(Objects.armours.Length)];
			ArmourMod mod = Mods.armours [rndm.Next(Mods.armours.Length)];

			Lvl = level;
			name = mod.adjective + " " + armour.name;
			bodyPosition = armour.bodyPosition;
			shield = (armour.shield + (armour.shield * (mod.shield / 100) * (Lvl / 100)));
		}

		public void PrintStats ()
		{
			Console.WriteLine ("Lvl {0} {1}", Lvl, name);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("Def: " + shield);
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
	public class Consumable : Item
	{
		public double Lvl;
		public string name;
		public double healthRegen;
		public double energyRegen;
		public double strengthRegen;

		public Consumable (string nm, double health, double energy, double strngth)
		{
			name = nm;
			healthRegen = health;
			energyRegen = energy;
			strengthRegen = strngth;
		}
		public Consumable (double level)
		{
			Random rndm = new Random ();
			Consumable food = Objects.foods [rndm.Next(Objects.foods.Length)];
			ConsumableMod mod = Mods.foods [rndm.Next(Mods.foods.Length)];

			Lvl = level;
			name = mod.adjective + " " + food.name;
			healthRegen = (food.healthRegen + (food.healthRegen * (mod.healthRegen / 100) * (Lvl / 100)));
			energyRegen = (food.energyRegen + (food.energyRegen * (mod.energyRegen / 100) * (Lvl / 100)));
			strengthRegen = (food.strengthRegen + (food.strengthRegen * (mod.strengthRegen / 100) * (Lvl / 100)));
		}

		public void PrintStats ()
		{
			Console.WriteLine ("Lvl {0} {1}", Lvl, name);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Hlth: " + healthRegen);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine ("Enrgy: " + energyRegen);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine ("Strngth: " + strengthRegen);
			Console.ForegroundColor = ConsoleColor.White;

		}
	}
}

