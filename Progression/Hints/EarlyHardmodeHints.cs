namespace GuidesAdvice.Progression.Hints
{
    public static class EarlyHardmodeHints
    {
        public static readonly System.Collections.Generic.List<HintDefinition> All =
            new System.Collections.Generic.List<HintDefinition>
            {
                new HintDefinition(
                    "hardmode-new-ores",
                    "Use the Pwnhammer from the Wall of Flesh to break Demon or Crimson "
                    + "Altars. The first three generate Cobalt or Palladium, Mythril or "
                    + "Orichalcum, then Adamantite or Titanium. Later altars repeat that cycle."),

                new HintDefinition(
                    "hardmode-wings",
                    "Wings make exploring and boss fights much easier. "
                    + "Many early Hardmode wings are crafted from Souls of Flight "
                    + "dropped by Wyverns."),

                new HintDefinition(
                    "hardmode-mechanical-items",
                    "Mechanical boss summoning items are crafted at a Mythril "
                    + "or Orichalcum Anvil. Their recipes use different souls, "
                    + "bars, and other materials."),

                new HintDefinition(
                    "hardmode-altar-warning",
                    "You don't need to break every altar. Breaking additional "
                    + "altars adds more Hardmode ore, but the returns diminish "
                    + "after the three ore tiers have been generated."),

                new HintDefinition(
                    "hardmode-life-fruit",
                    "After you defeat your first mechanical boss, Life Fruit can begin "
                    + "growing in the Underground Jungle. Each one increases your maximum "
                    + "life beyond the Life Crystal limit.",
                    () => Terraria.NPC.downedMechBoss1 || Terraria.NPC.downedMechBoss2 || Terraria.NPC.downedMechBoss3),

                new HintDefinition(
                    "hardmode-biomes",
                    "Hardmode introduces dangerous Hallow and evil-biome enemies. "
                    + "Be cautious when exploring newly converted areas, and "
                    + "look for the materials they drop.")
            };
    }
}
