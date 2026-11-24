namespace GuidesAdvice.Progression.Hints
{
    public static class PostPlanteraHints
    {
        public static readonly System.Collections.Generic.List<HintDefinition> All =
            new System.Collections.Generic.List<HintDefinition>
            {
                new HintDefinition(
                    "postplantera-temple-key",
                    "Plantera drops the Temple Key. Use it to open the entrance "
                    + "to the Jungle Temple, where Golem awaits."),

                new HintDefinition(
                    "postplantera-dungeon",
                    "The Dungeon becomes more dangerous after Plantera is defeated, "
                    + "but its new enemies also drop powerful equipment."),

                new HintDefinition(
                    "postplantera-truffle-worm",
                    "The Truffle Worm is bait for the Duke Fishron fight. "
                    + "It is found in the Underground Glowing Mushroom biome "
                    + "and can be difficult to catch.")
            };
    }
}
