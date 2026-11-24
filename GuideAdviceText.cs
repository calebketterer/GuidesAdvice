namespace GuidesAdvice
{
    // Kept as a small presentation facade so dialogue interactions do not
    // need to know how progression and hint selection are implemented.
    public static class GuideAdviceText
    {
        public static string GetNextObjective()
        {
            return Progression.ProgressionManager.GetNextObjective();
        }

        public static string GetSummonInstructions()
        {
            return Progression.ProgressionManager.GetSummonInstructions();
        }

        public static string GetRandomHint(GuideAdvicePlayer player)
        {
            return Progression.Hints.HintManager.GetHint(player);
        }
    }
}
