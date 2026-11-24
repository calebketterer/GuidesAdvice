namespace GuidesAdvice
{
    // Keeps the interaction classes separate from progression and hint implementation.
    public static class GuideAdviceText
    {
        public static string GetNextObjective(Terraria.NPC guide)
        {
            return Progression.ProgressionManager.GetNextObjective(guide);
        }

        public static string GetBossFightTips(Terraria.NPC guide)
        {
            return Progression.BossProgression.GetBossFightTips(guide);
        }

        public static string GetRandomHint(GuideAdvicePlayer player)
        {
            return Progression.Hints.HintManager.GetHint(player);
        }
    }
}
