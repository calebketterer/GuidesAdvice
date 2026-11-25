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

        public static string GetBossFightTips(NPC guide)
        {
            if (guide != null && guide.homeless)
            {
                return "Make sure there's enough space, but not too much! Check by going to the right side of your inventory and clicking the icon shaped like a house.";
            }

            switch (ProgressionManager.GetCurrentStage())
            {
                case ProgressionStage.EarlyPreHardmode:
                    return "Before the Eye of Cthulhu, explore underground for Life Crystals and better gear. Consider building a long platform arena with Campfires for regeneration. Prioritize movement with boots, a double jump, or a grappling hook. A bow or other ranged weapon lets you keep your distance. Don't forget healing potions!";

                case ProgressionStage.EvilBiome:
                    return WorldGen.crimson
                        ? "Against the Brain of Cthulhu, make room in the Crimson cavern and use platforms to change height. Clear its Creepers first, keep moving when the Brain teleports, and use a weapon that can hit several targets during the opening phase."
                        : "For the Eater of Worlds, fight where you have room to move and avoid getting surrounded by its body. Piercing weapons and attacks that hit multiple segments are especially effective. Platforms help you change elevation and avoid its charges.";

                case ProgressionStage.Dungeon:
                    return "Before facing Skeletron, build a roomy arena near the Dungeon with platforms at several heights. Focus on destroying its hands, keep moving during its spinning attack, and avoid staying directly beneath its head. Bring healing and useful buffs.";

                case ProgressionStage.Underworld:
                    return "For the Wall of Flesh, prepare a long, clear bridge across the Underworld before summoning it. Remove obstacles and watch for gaps or lava. Its advance never stops, so ranged or piercing weapons, reliable mobility, and healing are especially useful.";

                case ProgressionStage.EarlyHardmode:
                    return "For the mechanical bosses, upgrade your armor and weapons with Hardmode materials and prepare a large arena with platforms, Campfires, and Heart Lanterns. Wings help considerably. Use piercing or area attacks against the Destroyer, and keep moving against the Twins and Skeletron Prime.";

                case ProgressionStage.PostMech:
                    return "When fighting Plantera, make a spacious arena in the Underground Jungle and stay inside the Jungle; she becomes much more dangerous outside it. Clear enough room to circle around her, and bring strong mobility, healing, and combat buffs.";

                case ProgressionStage.PostPlantera:
                    return "Inside the Jungle Temple, clear space around the Lihzahrd Altar before summoning Golem. Give yourself room to dodge its attacks, keep your distance when needed, and bring healing potions and your usual combat buffs.";

                case ProgressionStage.PostGolem:
                    return "When facing the Lunatic Cultist, watch its attack patterns and summoned projectiles rather than rushing in. When it creates copies, identify the real Cultist before attacking; hitting a decoy can trigger a dangerous attack.";

                case ProgressionStage.PostCultist:
                    return "For the Moon Lord, bring your strongest available equipment, plenty of healing, and a long route or arena with room to dodge. Focus on the hands and head before attacking the exposed core. Watch for the eye-beam and keep moving.";

                default:
                    return "For optional challenges, prepare an arena suited to the encounter, bring your strongest available equipment, and choose buffs that complement your build. If you have a particular boss in mind, I can offer more specific advice.";
            }
        }

    }
}
