namespace GuidesAdvice.Progression.Hints
{
    public static class DungeonHints
    {
        public static readonly System.Collections.Generic.List<HintDefinition> All =
            new System.Collections.Generic.List<HintDefinition>
            {
                new HintDefinition(
                    "dungeon.old-man",
                    "The Old Man outside the Dungeon is more than a warning. "
                    + "Speak with him at night when you're ready to challenge "
                    + "the creature guarding the entrance."),

                new HintDefinition(
                    "dungeon.water-bolt",
                    "Some useful magic weapons can be found on the shelves inside "
                    + "the Dungeon. Be cautious: the Dungeon is dangerous until "
                    + "its guardian has been defeated."),

                new HintDefinition(
                    "dungeon.shadow-key",
                    "Golden Chests in the Dungeon can contain Shadow Keys. "
                    + "You'll need one to open Shadow Chests in the Underworld.")
            };
    }
}
