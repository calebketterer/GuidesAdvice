using Terraria;
using Terraria.WorldBuilding;

namespace GuidesAdvice.Progression
{
    public static class BossProgression
    {
        public static bool AllMechanicalBossesDefeated()
        {
            return NPC.downedMechBoss1
                && NPC.downedMechBoss2
                && NPC.downedMechBoss3;
        }

        public static bool HasNextVitalBoss()
        {
            return ProgressionManager.GetCurrentStage() != ProgressionStage.Completed;
        }

        public static string GetNextVitalBossInstructions()
        {
            switch (ProgressionManager.GetCurrentStage())
            {
                case ProgressionStage.EarlyPreHardmode:
                    return "Eye of Cthulhu\n\n"
                        + "You can summon it with a Suspicious Looking Eye at night "
                        + "(between 7:30 PM and 4:30 AM). The item is crafted from "
                        + "6 Lenses at a Demon or Crimson Altar.\n\n"
                        + "It may also appear naturally at dusk if you have at "
                        + "least 200 maximum life, at least 11 defense, and four "
                        + "town NPCs present. No other boss can be alive. Build "
                        + "an arena and bring mobility accessories.";

                case ProgressionStage.EvilBiome:
                    if (WorldGen.crimson)
                    {
                        return "Brain of Cthulhu\n\n"
                            + "You can summon it by breaking three Crimson Hearts "
                            + "in the underground Crimson. Alternatively, craft a "
                            + "Bloody Spine from 30 Vicious Powder and 15 Vertebrae "
                            + "at a Crimson Altar, then use it while in the Crimson. "
                            + "The Bloody Spine can be used at any time.";
                    }

                    return "Eater of Worlds\n\n"
                        + "You can summon it by breaking three Shadow Orbs "
                        + "in the underground Corruption. Alternatively, craft "
                        + "Worm Food from 30 Vile Powder and 15 Rotten Chunks "
                        + "at a Demon Altar, then use it while in the Corruption. "
                        + "Worm Food can be used at any time.";

                case ProgressionStage.Dungeon:
                    return "Skeletron\n\n"
                        + "Find the Old Man standing outside the Dungeon. Speak "
                        + "to him at night and choose the option to lift his curse. "
                        + "This summons Skeletron. Defeating him removes the "
                        + "Dungeon Guardian threat from normal exploration.";

                case ProgressionStage.Underworld:
                    return "Wall of Flesh\n\n"
                        + "Find a Guide Voodoo Doll dropped by Voodoo Demons "
                        + "in the Underworld. While the Guide is alive, throw "
                        + "the doll into lava in the Underworld to summon the "
                        + "Wall of Flesh. This permanently starts Hardmode in "
                        + "the world, so prepare your equipment and base first.";

                case ProgressionStage.EarlyHardmode:
                    return GetMechanicalBossInstructions();

                case ProgressionStage.PostMech:
                    return "Plantera\n\n"
                        + "After all three mechanical bosses are defeated, "
                        + "Plantera's Bulbs begin growing in the Underground "
                        + "Jungle. Break a bulb to summon Plantera. Explore "
                        + "carefully: the bulb can be difficult to spot, and "
                        + "Plantera becomes more dangerous outside the Jungle.";

                case ProgressionStage.PostPlantera:
                    return "Golem\n\n"
                        + "Defeat Plantera to obtain the Temple Key, then enter "
                        + "the Jungle Temple. Find the Lihzahrd Altar and use "
                        + "a Lihzahrd Power Cell on it to summon Golem. Power "
                        + "Cells are found in Temple chests and dropped by "
                        + "Lihzahrd enemies.";

                case ProgressionStage.PostGolem:
                    return "Lunatic Cultist\n\n"
                        + "After Golem is defeated, the Cultists appear at the "
                        + "Dungeon entrance. Defeat the four Cultists there to "
                        + "summon the Lunatic Cultist. Make sure you're ready "
                        + "before engaging them.";

                case ProgressionStage.PostCultist:
                    return "Moon Lord\n\n"
                        + "Defeat the four Celestial Pillars that appear after "
                        + "the Lunatic Cultist. Once the final pillar falls, "
                        + "the Moon Lord will arrive shortly. Heal, prepare an "
                        + "arena, and make sure your equipment is upgraded.";

                default:
                    return "There are no remaining bosses in the main progression. "
                        + "You can pursue optional bosses, events, achievements, "
                        + "or whatever projects interest you.";
            }
        }

        private static string GetMechanicalBossInstructions()
        {
            string instructions = "Mechanical bosses\n\n"
                + "You must defeat all three mechanical bosses. Their "
                + "summoning items can be used only at night and are crafted "
                + "at a Mythril or Orichalcum Anvil:\n";

            if (!NPC.downedMechBoss2)
            {
                instructions += "• Mechanical Eye (The Twins): 3 Lenses, "
                    + "5 Iron or Lead Bars, and 6 Souls of Light.\n";
            }

            if (!NPC.downedMechBoss1)
            {
                instructions += "• Mechanical Worm (The Destroyer): 6 Rotten "
                    + "Chunks or Vertebrae, 5 Iron or Lead Bars, and "
                    + "6 Souls of Night.\n";
            }

            if (!NPC.downedMechBoss3)
            {
                instructions += "• Mechanical Skull (Skeletron Prime): 30 Bones, "
                    + "5 Iron or Lead Bars, 3 Souls of Light, and "
                    + "3 Souls of Night.\n";
            }

            instructions += "After the first Demon or Crimson Altar is broken, "
                + "an undefeated mechanical boss has a 10% chance to appear "
                + "naturally at dusk. You can fight the remaining bosses in any order.";

            return instructions;
        }
    }
}
