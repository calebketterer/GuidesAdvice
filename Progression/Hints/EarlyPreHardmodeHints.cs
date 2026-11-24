using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace GuidesAdvice.Progression.Hints
{
    public static class EarlyPreHardmodeHints
    {
        public static readonly List<HintDefinition> All = new List<HintDefinition>
        {
            new HintDefinition(
                "early.mana-crystals",
                "Three Fallen Stars can be combined to craft a Mana Crystal. "
                + "Each one permanently increases your maximum mana, up to the normal limit."),

            new HintDefinition(
                "early.life-crystals",
                "Life Crystals are found underground, often embedded in stone. "
                + "Use them to permanently increase your maximum life."),

            new HintDefinition(
                "early.floating-islands",
                "Floating Islands can contain useful loot and unique equipment. "
                + "Look high above the surface, and consider building or finding "
                + "a way to reach them safely."),

            new HintDefinition(
                "early.accessory-combining",
                "Some accessories can be combined at a Tinker's Workshop. "
                + "When you find the Goblin Tinkerer, check his shop for one. "
                + "Combining accessories can free up equipment slots."),

            new HintDefinition(
                "early.goblin-tinkerer",
                "After defeating a Goblin Army, search the Cavern layer for the "
                + "Bound Goblin. Freeing him unlocks reforging and the Tinker's Workshop."),

            new HintDefinition(
                "early.re-forging",
                "The Goblin Tinkerer can reforge weapons and accessories. "
                + "A useful modifier can make a noticeable difference, though "
                + "the price increases with the item's value.",
                () => NPC.downedGoblins),

            new HintDefinition(
                "early.armor-set",
                "Wearing a complete matching armor set often grants a set bonus. "
                + "Check the bonus before choosing separate pieces with slightly "
                + "higher defense."),

            new HintDefinition(
                "early.underground-chests",
                "Underground cabins and chests can contain accessories that "
                + "remain useful for a long time. Exploring caves is often "
                + "worthwhile even after you have decent weapons.")
        };
    }
}
