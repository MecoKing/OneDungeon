using System;

namespace OneDungeon
{
	public class Race
	{
		public double Lvl;
		public string name;
		public double health;
		public double energy;
		public double strength;

		public Race (string nm, double hlth, double enrgy, double strngth)
		{
			name = nm;
			health = hlth;
			energy = enrgy;
			strength = strngth;
		}
		public Race (double level)
		{
			Random rndm = new Random ();
			Race species = Objects.races [rndm.Next(Objects.races.Length)];
			RaceMod mod = Mods.races [rndm.Next(Mods.races.Length)];
			Skill ability = new Skill (level);

			Lvl = level;
			string gender = (rndm.Next (2) == 0) ? "Male" : "Female";
			name = mod.adjective + " " + gender + " " + species.name + " - " + ability.name;
			health = (species.health + (species.health * (mod.health / 100) * (Lvl / 100)));
			energy = (species.energy + (species.energy * ((mod.energy / 100) + (ability.energy))  * (Lvl / 100)));
			strength = (species.strength + (species.strength * ((mod.strength / 100) + (ability.strength)) * (Lvl / 100)));
		}
	}
}

