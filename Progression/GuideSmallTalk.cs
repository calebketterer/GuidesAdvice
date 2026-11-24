using System.Collections.Generic;
using System.Linq;
using Terraria;

namespace GuidesAdvice.Progression
{
    public static class GuideSmallTalk
    {
        private sealed class Entry
        {
            public string Id { get; }
            public string Text { get; }

            public Entry(string id, string text)
            {
                Id = id;
                Text = text;
            }
        }

        private static readonly List<Entry> EarlyPreHardmode = new List<Entry>
        {
            new Entry("smalltalk.pre.1", "The world is full of things worth discovering. "
                + "Don't be afraid to spend a day exploring before taking on another boss."),
            new Entry("smalltalk.pre.2", "If you find something strange underground, "
                + "it may be worth investigating. Just make sure you have a way back."),
            new Entry("smalltalk.pre.3", "A good home is more than a place to sleep. "
                + "Town NPCs can offer useful services once they have somewhere to live.")
        };

        private static readonly List<Entry> EvilBiome = new List<Entry>
        {
            new Entry("smalltalk.evil.1", "Those chasms in the world evil can be dangerous. "
                + "Bring ropes, platforms, and plenty of light."),
            new Entry("smalltalk.evil.2", "The deeper parts of the Corruption and Crimson "
                + "are not welcoming places. Prepare before heading down.")
        };

        private static readonly List<Entry> Dungeon = new List<Entry>
        {
            new Entry("smalltalk.dungeon.1", "The Dungeon holds many secrets, but its "
                + "inhabitants are not known for welcoming visitors."),
            new Entry("smalltalk.dungeon.2", "If you plan to explore the Dungeon, "
                + "make sure you have dealt with its guardian first.")
        };

        private static readonly List<Entry> Underworld = new List<Entry>
        {
            new Entry("smalltalk.underworld.1", "The Underworld is a dangerous place. "
                + "Obsidian Skin potions can make its lava much less troublesome."),
            new Entry("smalltalk.underworld.2", "I would make sure the Guide is safe "
                + "before handling any Voodoo Dolls. Just a bit of advice.")
        };

        private static readonly List<Entry> Hardmode = new List<Entry>
        {
            new Entry("smalltalk.hardmode.1", "Hardmode changes more than the enemies. "
                + "Keep an eye out for new materials and new ways to improve your gear."),
            new Entry("smalltalk.hardmode.2", "If the world feels much more dangerous "
                + "than it used to, that's because it is. Take your time upgrading.")
        };

        public static string GetMessage(GuideAdvicePlayer player)
        {
            List<Entry> entries = GetEntriesForCurrentStage();
            List<Entry> choices = entries
                .Where(entry => entry.Id != player.LastSmallTalkId)
                .ToList();

            if (choices.Count == 0)
                choices = entries;

            Entry selected = choices[Main.rand.Next(choices.Count)];
            player.SetLastSmallTalkId(selected.Id);
            return selected.Text;
        }

        private static List<Entry> GetEntriesForCurrentStage()
        {
            switch (ProgressionManager.GetCurrentStage())
            {
                case ProgressionStage.EarlyPreHardmode:
                    return EarlyPreHardmode;
                case ProgressionStage.EvilBiome:
                    return EvilBiome;
                case ProgressionStage.Dungeon:
                    return Dungeon;
                case ProgressionStage.Underworld:
                    return Underworld;
                default:
                    return Hardmode;
            }
        }
    }
}
