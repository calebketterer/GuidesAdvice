using Terraria;
using Terraria.WorldBuilding;

namespace GuidesAdvice.Progression
{
    public static class ProgressionManager
    {
        public static ProgressionStage GetCurrentStage()
        {
            if (!NPC.downedBoss1)
                return ProgressionStage.EarlyPreHardmode;

            if (!NPC.downedBoss2)
                return ProgressionStage.EvilBiome;

            if (!NPC.downedBoss3)
                return ProgressionStage.Dungeon;

            if (!Main.hardMode)
                return ProgressionStage.Underworld;

            if (!BossProgression.AllMechanicalBossesDefeated())
                return ProgressionStage.EarlyHardmode;

            if (!NPC.downedPlantBoss)
                return ProgressionStage.PostMech;

            if (!NPC.downedGolemBoss)
                return ProgressionStage.PostPlantera;

            if (!NPC.downedAncientCultist)
                return ProgressionStage.PostGolem;

            if (!NPC.downedMoonlord)
                return ProgressionStage.PostCultist;

            return ProgressionStage.Completed;
        }

        // Housing is the first tutorial objective. Once the Guide has a home,
        // normal boss progression begins.
        public static string GetNextObjective(NPC guide)
        {
            if (guide != null && guide.homeless)
            {
                return "We need a livable home! Let's build an enclosed room with walls, a light, table, chair, and door. Building more houses like this one will allow others to move in!";
            }

            switch (GetCurrentStage())
            {
                case ProgressionStage.EarlyPreHardmode:
                    return "I'd prepare for the Eye of Cthulhu. At night, use a Suspicious Looking Eye (6 Lenses at a Demon or Crimson Altar); it may also appear naturally once your health, defense, and town population are high enough.";

                case ProgressionStage.EvilBiome:
                    return WorldGen.crimson
                        ? "Your next challenge is the Brain of Cthulhu. Search the underground Crimson for Crimson Hearts: breaking three summons it. You can also craft a Bloody Spine from 30 Vicious Powder and 15 Vertebrae at a Crimson Altar, then use it in the Crimson."
                        : "Your next challenge is the Eater of Worlds. Search the underground Corruption for Shadow Orbs: breaking three summons it. You can also craft Worm Food from 30 Vile Powder and 15 Rotten Chunks at a Demon Altar, then use it in the Corruption.";

                case ProgressionStage.Dungeon:
                    return "I'd explore the Dungeon next, but speak to the Old Man at its entrance first. Return at night and ask him to lift his curse; that summons Skeletron. Defeating it lets you explore the Dungeon safely and reach the treasures within.";

                case ProgressionStage.Underworld:
                    return "You're ready to take on the Wall of Flesh. Find a Guide Voodoo Doll dropped by Voodoo Demons in the Underworld, then throw it into lava while the Guide is alive. This begins Hardmode permanently, so upgrade your gear and prepare your world before you do it.";

                case ProgressionStage.EarlyHardmode:
                    return "Hardmode calls for three major victories: the Destroyer, the Twins, and Skeletron Prime. You can fight them in any order. Their Mechanical Worm, Mechanical Eye, and Mechanical Skull are crafted at a Mythril or Orichalcum Anvil using souls and other materials, and each can only be used at night.";

                case ProgressionStage.PostMech:
                    return "With the mechanical bosses defeated, it's time to search the Underground Jungle for Plantera's Bulbs. Break one to begin the fight. They can be easy to miss, so explore the Jungle carefully and mark any bulbs you find before challenging her.";

                case ProgressionStage.PostPlantera:
                    return "Your next destination is the Jungle Temple. Plantera drops the Temple Key, which opens its entrance. Inside, find the Lihzahrd Altar and use a Lihzahrd Power Cell to summon Golem; you can find more cells in Temple chests and from Lihzahrd enemies.";

                case ProgressionStage.PostGolem:
                    return "Head back to the Dungeon. Now that Golem has been defeated, the Cultists should be gathered at its entrance. Defeat them to summon the Lunatic Cultist, but make sure you're prepared before starting the encounter.";

                case ProgressionStage.PostCultist:
                    return "The final stretch has begun: defeat all four Celestial Pillars that appeared after the Lunatic Cultist. Once the last pillar falls, the Moon Lord will arrive shortly. Use this time to heal, check your equipment, and get ready for the final fight.";

                default:
                    return "You've defeated the Moon Lord, so the main progression is complete! There are still optional bosses, events, rare items, achievements, and building projects to discover. What you tackle next is up to you.";
            }
        }
    }
}
