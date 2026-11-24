namespace GuidesAdvice.Progression.Hints
{
    public static class EvilBiomeHints
    {
        public static readonly System.Collections.Generic.List<HintDefinition> All =
            new System.Collections.Generic.List<HintDefinition>
            {
                new HintDefinition(
                    "evil.shadow-orbs-hearts",
                    "The glowing objects deep in your world evil biome are important. "
                    + "Breaking Shadow Orbs or Crimson Hearts can provide valuable "
                    + "items, but breaking the third one summons a boss."),

                new HintDefinition(
                    "evil.explosives",
                    "Bombs and other explosives can help you reach Shadow Orbs or "
                    + "Crimson Hearts that are blocked by the biome's stone."),

                new HintDefinition(
                    "evil.potions",
                    "Boss fights are much easier with preparation. Healing potions, "
                    + "Ironskin, Swiftness, and food buffs can all help."),

                new HintDefinition(
                    "evil.arena",
                    "A simple boss arena can make a major difference. Platforms, "
                    + "campfires, and heart lanterns give you room to move and "
                    + "help you recover during a fight.")
            };
    }
}
