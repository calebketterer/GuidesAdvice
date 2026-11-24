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

        public static string GetNextObjective()
        {
            switch (GetCurrentStage())
            {
                case ProgressionStage.EarlyPreHardmode:
                    return "Your first major challenge is the Eye of Cthulhu. "
                        + "Explore, improve your equipment, and prepare for a fight "
                        + "against a creature that becomes active at night.";

                case ProgressionStage.EvilBiome:
                    return WorldGen.crimson
                        ? "Your next major objective is the Brain of Cthulhu. "
                            + "Explore the underground Crimson and investigate its "
                            + "Crimson Hearts."
                        : "Your next major objective is the Eater of Worlds. "
                            + "Explore the underground Corruption and investigate "
                            + "its Shadow Orbs.";

                case ProgressionStage.Dungeon:
                    return "The Dungeon is your next major destination. "
                        + "Find the Old Man at its entrance and learn what happens "
                        + "when his curse is lifted.";

                case ProgressionStage.Underworld:
                    return "Your next major objective is the Wall of Flesh. "
                        + "Prepare for a dangerous journey through the Underworld "
                        + "before triggering the transition to Hardmode.";

                case ProgressionStage.EarlyHardmode:
                    return "Hardmode has begun. Your next major milestone is to "
                        + "defeat all three mechanical bosses: the Destroyer, "
                        + "the Twins, and Skeletron Prime. You can tackle them "
                        + "in any order.";

                case ProgressionStage.PostMech:
                    return "All three mechanical bosses have fallen. Search the "
                        + "Underground Jungle for a Plantera's Bulb, then prepare "
                        + "for the fight that follows.";

                case ProgressionStage.PostPlantera:
                    return "Plantera is defeated. Your next major objective is "
                        + "to explore the Jungle Temple and defeat Golem.";

                case ProgressionStage.PostGolem:
                    return "Golem has fallen. The next major event is at the "
                        + "Dungeon: seek out the Lunatic Cultist and prepare "
                        + "for what his defeat will unleash.";

                case ProgressionStage.PostCultist:
                    return "The Celestial Pillars have appeared. Destroy all four "
                        + "and prepare yourself for the final battle against "
                        + "the Moon Lord.";

                default:
                    return "You've defeated the Moon Lord! The main progression "
                        + "is complete, but there are still optional challenges, "
                        + "events, building projects, and secrets to discover.";
            }
        }

        public static string GetSummonInstructions()
        {
            return BossProgression.GetNextVitalBossInstructions();
        }
    }
}
