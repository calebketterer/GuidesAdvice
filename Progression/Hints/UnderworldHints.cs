namespace GuidesAdvice.Progression.Hints
{
    public static class UnderworldHints
    {
        public static readonly System.Collections.Generic.List<HintDefinition> All =
            new System.Collections.Generic.List<HintDefinition>
            {
                new HintDefinition(
                    "underworld.voodoo-doll",
                    "Voodoo Demons carry Guide Voodoo Dolls. Be careful around lava: "
                    + "a doll falling into it while the Guide is alive summons "
                    + "the Wall of Flesh."),

                new HintDefinition(
                    "underworld.obsidian",
                    "Obsidian can be made where water and lava meet. It is useful "
                    + "for crafting fire-resistant equipment and several important "
                    + "Underworld items."),

                new HintDefinition(
                    "underworld-hellstone",
                    "Hellstone is valuable, but mining it releases lava. "
                    + "Obsidian Skin potions make gathering it much safer."),

                new HintDefinition(
                    "underworld-preparation",
                    "Defeating the Wall of Flesh permanently changes the world. "
                    + "Consider preparing travel routes, protecting important "
                    + "areas, and upgrading your equipment before the fight.")
            };
    }
}
