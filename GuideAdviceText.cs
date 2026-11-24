
using Terraria;
using Terraria.ID;
using Terraria.WorldBuilding;

namespace GuidesAdvice
{
    public static class GuideAdviceText
    {
        public static string GetHint()
        {
            if (!NPC.downedBoss1)
            {
                return "You've been exploring, but I think "
                    + "it's time to test your abilities. "
                    + "Have you considered confronting "
                    + "the Eye of Cthulhu?";
            }

            if (!NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    return "You've proven yourself against "
                        + "the Eye of Cthulhu. Perhaps it's "
                        + "time to investigate the Crimson. "
                        + "There's something interesting "
                        + "buried beneath it.";
                }

                return "You've proven yourself against "
                    + "the Eye of Cthulhu. Perhaps it's "
                    + "time to investigate the Corruption. "
                    + "There's something interesting "
                    + "buried beneath it.";
            }

            if (!NPC.downedBoss3)
            {
                return "You've overcome the dangers "
                    + "beneath the surface. I think you're "
                    + "ready to investigate the Dungeon. "
                    + "But be careful who you disturb.";
            }

            if (!Main.hardMode)
            {
                return "You've accomplished quite a bit. "
                    + "Perhaps it's time to venture into "
                    + "the Underworld. I suspect there's "
                    + "something waiting for you there.";
            }

            return "This world has changed considerably. "
                + "There are new materials, creatures, "
                + "and challenges to discover. "
                + "I wouldn't stay on the surface too long.";
        }

        public static string GetElaboration()
        {
            if (!NPC.downedBoss1)
            {
                return "The Eye of Cthulhu tends to appear "
                    + "at night, especially when you've "
                    + "gathered enough life and equipment. "
                    + "You can also summon it yourself "
                    + "using a Suspicious Looking Eye. "
                    + "I'd recommend improving your armor, "
                    + "finding a ranged weapon, and "
                    + "preparing an open area to fight.";
            }

            if (!NPC.downedBoss2)
            {
                if (WorldGen.crimson)
                {
                    return "Explore the underground "
                        + "Crimson until you find its "
                        + "Crimson Hearts. Breaking three "
                        + "will summon the Brain of Cthulhu. "
                        + "Bring strong weapons, healing "
                        + "potions, and prepare an arena. "
                        + "A hammer or explosives can help "
                        + "you break the hearts.";
                }

                return "Explore the underground "
                    + "Corruption until you find its "
                    + "Shadow Orbs. Breaking three will "
                    + "summon the Eater of Worlds. "
                    + "Bring strong weapons, healing "
                    + "potions, and prepare an arena. "
                    + "A hammer or explosives can help "
                    + "you break the orbs.";
            }

            if (!NPC.downedBoss3)
            {
                return "The Dungeon is guarded by "
                    + "a powerful creature. Find the "
                    + "Old Man outside its entrance "
                    + "and speak with him at night. "
                    + "He can help you challenge "
                    + "Skeletron. Make sure you're "
                    + "well equipped before doing so.";
            }

            if (!Main.hardMode)
            {
                return "The Underworld lies at the "
                    + "bottom of the world. Explore "
                    + "its depths and look for a "
                    + "Guide Voodoo Doll. Throwing "
                    + "one into lava will summon "
                    + "the Wall of Flesh. This is "
                    + "a major turning point, so "
                    + "prepare carefully!";
            }

            return "Hardmode has introduced new "
                + "ores and much stronger enemies. "
                + "Try breaking Demon Altars or "
                + "Crimson Altars with the appropriate "
                + "tool to generate new ores. "
                + "Explore underground and improve "
                + "your equipment before tackling "
                + "the new bosses.";
        }
    }
}
