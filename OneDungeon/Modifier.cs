using System;

namespace OneDungeon
{
	public class Modifier
	{
		public Modifier ()
		{
		}
	}

	public class WeaponMod : Modifier
	{
		public string adjective;
		public string adverb;
		public double damage;//% increase
		public double shield;//% increase
		public double energyUse;//% increase

		public WeaponMod (string adj, string adv, double atk, double def, double enrgy)
		{
			adjective = adj;
			adverb = adv;
			damage = atk;
			shield = def;
			energyUse = enrgy;
		}
	}
	public class ArmourMod : Modifier
	{
		public string adjective;
		public double shield;

		public ArmourMod (string adj, double def)
		{
			adjective = adj;
			shield = def;
		}
	}
	public class ConsumableMod : Modifier
	{
		public string adjective;
		public double healthRegen;
		public double energyRegen;
		public double strengthRegen;

		public ConsumableMod (string adj, double health, double energy, double strngth)
		{
			adjective = adj;
			healthRegen = health;
			energyRegen = energy;
			strengthRegen = strngth;
		}
	}

	public class RaceMod : Modifier
	{
		public string adjective;
		public double health;
		public double energy;
		public double strength;

		public RaceMod (string adj, double hlth, double enrgy, double strngth)
		{
			adjective = adj;
			health = hlth;
			energy = enrgy;
			strength = strngth;
		}
	}
	public class SkillMod : Modifier
	{
		public string adjective;
		public double strength;
		public double energy;

		public SkillMod (string adj, double strngth, double enrgy)
		{
			adjective = adj;
			strength = strngth;
			energy = enrgy;
		}
	}

	public class MapMod : Modifier
	{
		public string adjective;
		public double hostility;
		public string description;

		public MapMod (string adj, string describe, double hostile)
		{
			adjective = adj;
			description = describe;
			hostility = hostile;
		}
	}
}

