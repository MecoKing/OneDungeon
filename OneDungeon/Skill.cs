using System;

namespace OneDungeon
{
	public class Skill
	{
		public double Lvl;
		public string name;
		public double strength;
		public double energy;

		public Skill (string nm, double strngth, double enrgy)
		{
			name = nm;
			strength = strngth;
			energy = enrgy;
		}
		public Skill (double level)
		{
			Random rndm = new Random ();
			Skill ability = Objects.skills [rndm.Next(Objects.skills.Length)];
			SkillMod mod = Mods.skills [rndm.Next(Mods.skills.Length)];

			Lvl = level;
			name = mod.adjective + " " + ability.name;
			strength = (ability.strength + (ability.strength * (mod.strength / 100) * (Lvl / 100)));
			energy = (ability.energy + (ability.energy * (mod.energy / 100) * (Lvl / 100)));
		}
	}
}

