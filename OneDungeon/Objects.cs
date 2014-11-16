using System;

namespace OneDungeon
{
	public class Objects
	{
		public static Weapon[] weapons = new Weapon[] {
			new Weapon ("Sword", "Slashed", 10, 10, 10),
			new Weapon ("Axe", "Cut", 10, 15, 10),
			new Weapon ("Battle-Axe", "Sliced", 20, 20, 15),
			new Weapon ("Spear", "Stabbed", 5, 20, 5),
			new Weapon ("Hammer", "Smashed", 20, 5, 25),
			new Weapon ("War Hammer", "Crushed", 40, 10, 50),
			new Weapon ("Knife", "Pierced", 10, 5, 5),
			new Weapon ("Shield", "Shoved", 5, 20, 0),
			new Weapon ("Bow", "Shot", 10, 0, 2),
			new Weapon ("Crossbow", "Sniped", 15, 5, 1),
			new Weapon ("Trident", "Poked", 15, 25, 10),
			new Weapon ("Staff", "Smacked", 10, 30, 5),
		};
		public static Armour[] armours = new Armour[] {//BodyPos: 0-Head / 1-Chest / 2-Arms / 3-Legs / 4-Feet
			new Armour ("Crown", 10, 0),
			new Armour ("Helm", 7, 0),
			new Armour ("Hat", 5, 0),
			new Armour ("Cap", 2, 0),
			new Armour ("Chestplate", 10, 1),
			new Armour ("Cloak", 7, 1),
			new Armour ("Robe", 5, 1),
			new Armour ("Tunic", 2, 1),
			new Armour ("Gauntlets", 10, 2),
			new Armour ("Gloves", 7, 2),
			new Armour ("Bracelet", 5, 2),
			new Armour ("Ring", 2, 2),
			new Armour ("Greaves", 10, 3),
			new Armour ("Skirt", 7, 3),
			new Armour ("Leggings", 5, 3),
			new Armour ("Tights", 2, 3),
			new Armour ("Boots", 10, 4),
			new Armour ("Shoes", 7, 4),
			new Armour ("Sandals", 5, 4),
			new Armour ("Socks", 2, 4),
		};
		public static Consumable[] foods = new Consumable[] {
			new Consumable ("Health Potion", 25, 0, 0),
			new Consumable ("Energy Potion", 0, 25, 0),
			new Consumable ("Strength Potion", 0, 0, 25),
			new Consumable ("Apple", 10, 20, 0),
			new Consumable ("Pear", 10, 20, 0),
			new Consumable ("Loaf of Bread", 15, 0, 2),
			new Consumable ("Cake", 20, 40, 0),
			new Consumable ("Chicken", 10, 10, 20),
			new Consumable ("Mutton", 10, 15, 20),
			new Consumable ("Carrot", 10, 10, 2),
		};

		public static Race[] races = new Race[] {//150 skillpoints total
			new Race ("Human", 100, 25, 25),
			new Race ("Elf", 100, 40, 10),
			new Race ("Dwarf", 90, 30, 30),
			new Race ("Goblin", 90, 40, 20),
			new Race ("Troll", 90, 20, 40),
			new Race ("Mutant", 100, 30, 20),
			new Race ("Draconian", 100, 20, 30),
			new Race ("Dark Elf", 90, 40, 20),
		};
		public static Skill[] skills = new Skill[] {//50 skillpoints total
			new Skill ("Swordsman", 25, 25),
			new Skill ("Marksman", 10, 40),
			new Skill ("Berserker", 40, 10),
			new Skill ("Guard", 25, 25),
			new Skill ("Ninja", 5, 45),
			new Skill ("Hero", 35, 15),
			new Skill ("Commander", 30, 20),
			new Skill ("Pirate", 20, 30),
		};

		public static Map[] maps = new Map[] {
			new Map ("Forest", "You are in the middle of a clearing in the forest..."),
			new Map ("Mountain", "From up here you can see all the world around you..."),
			new Map ("Cliffs", "You stand precariously on the edge of a steep cliff..."),
			new Map ("Caves", "A swarm of bats flood out of the tunnels..."),
			new Map ("Field", "A field of grass stretches out in every direction around you..."),
			new Map ("Valley", "Large mountains tower on either side of you..."),
			new Map ("Swamp", "You stand up to your knees in muddy water..."),
			new Map ("Beach", "The water stretches out as far as the eye can see..."),
			new Map ("Jungle", "The dense canopy shelters you from the humid air above..."),
			new Map ("Hills", "You stand atop one of many green rolling hills..."),
			new Map ("Desert", "You start hallucinating under the fierce desert heat..."),
			new Map ("Hamlet", "You enter a small village, the houses look empty and few people are seen in the streets..."),
			new Map ("Dungeon", "You enter into a deep stone dungeon..."),
			new Map ("Castle", "You enter through the large castle gate into an grand hall..."),
			new Map ("Fort", "You cautiously enter a large fort, the guards around you watch you suspicously..."),
		};
	}
}

