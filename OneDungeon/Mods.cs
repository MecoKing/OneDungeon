using System;

namespace OneDungeon
{
	public class Mods
	{
		public static WeaponMod[] weapons = new WeaponMod[] {
			new WeaponMod ("Wooden", "Hap-Hazardly", 50, 50, 0),
			new WeaponMod ("Copper", "Fiercly", 50, 50, 50),
			new WeaponMod ("Iron", "Bravely", 100, 100, 100),
			new WeaponMod ("Silver", "Confidently", 150, 150, 150),
			new WeaponMod ("Golden", "Forcefully", 150, 50, 300),
			new WeaponMod ("Light", "Quickly", 50, 0, -500),
			new WeaponMod ("Heavy", "Slowly", 0, 50, 500),
		};
		public static ArmourMod[] armours = new ArmourMod[] {
			new ArmourMod ("Torn", -15),
			new ArmourMod ("Cloth", 2),
			new ArmourMod ("Silk", 5),
			new ArmourMod ("Fur", 7),
			new ArmourMod ("Leather", 10),
			new ArmourMod ("Golden", 11),
			new ArmourMod ("Copper", 12),
			new ArmourMod ("Iron", 15),
			new ArmourMod ("Silver", 20),
			new ArmourMod ("Chain", 25),
			new ArmourMod ("Steel", 30),
		};
		public static ConsumableMod[] foods = new ConsumableMod[] {
			new ConsumableMod ("Healthy", 25, 0, 5),
			new ConsumableMod ("Sweet", 0, 25, 0),
			new ConsumableMod ("Enhanced", 20, 20, 20),
			new ConsumableMod ("Fresh", 15, 10, 15),
			new ConsumableMod ("Rotten", -500, -250, -100),
			new ConsumableMod ("Poisonous", -1500, -1000, -500),
			new ConsumableMod ("Strengthening", 0, 0, 120),
			new ConsumableMod ("Raw", -2, 10, 0),
			new ConsumableMod ("Cooked", 5, 15, 10),
			new ConsumableMod ("Roasted", 10, 20, 20),
		};

		public static RaceMod[] races = new RaceMod[] {
			new RaceMod ("Enraged", 5, 20, 25),
			new RaceMod ("Energetic", 0, 120, 0),
			new RaceMod ("Tired", 0, -110, -50),
			new RaceMod ("Strong", 0, 10, 50),
			new RaceMod ("Weak", -10, -5, -30),
			new RaceMod ("Healthy", 50, 30, 10),
			new RaceMod ("Villainous", 10, 20, 30),
		};
		public static SkillMod[] skills = new SkillMod[] {
			new SkillMod ("Master", 150, 150),
			new SkillMod ("Novice", 100, 100),
			new SkillMod ("Skilled", 75, 75),
			new SkillMod ("Average", 50, 50),
			new SkillMod ("Amateur", -20, -20),
			new SkillMod ("Inexperienced", -50, -50),
			new SkillMod ("Unskilled", - 80, -80),
			new SkillMod ("Terrible", -120, -120),
		};

		public static MapMod[] maps = new MapMod[] {
			new MapMod ("Sinister", "Every tree you see looks dark and evil...", 2),
			new MapMod ("Scorched", "There are dozens of charred marks on the ground...", 2),
			new MapMod ("Hostile", "The birds dive down to attack you...", 2),
			new MapMod ("Evil", "The thick air tastes cruel...", 1),
			new MapMod ("Arctic", "Snow and Ice cover the ground, the cold air bites at your face...", 1),
			new MapMod ("Dark", "The dead plants around you are gray and sickly, the shadows are sharp and cruel...", 1),
			new MapMod ("Open", "There are no obstacles obscuring your view...", 0),
			new MapMod ("Misty", "The fresh fog obscures your vision...", 0),
			new MapMod ("Clear", "There is not a single cloud in the sky...", 0),
			new MapMod ("Bright", "The sun shines brightly in your eyes...", -1),
			new MapMod ("Grassy", "You can feel the soft green grass beneath your feet...", -1),
			new MapMod ("Calm", "The air is still, the water lies motionless and the animals remain quiet...", -1),
			new MapMod ("Passive", "Everything about this place is friendly...", -2),
			new MapMod ("Verdant", "You cannot even count the number of different shades of green...", -2),
			new MapMod ("Gentle", "Everything around you is soft and comforting...", -2),
		};
	}
}

