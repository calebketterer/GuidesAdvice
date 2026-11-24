using System.Collections.Generic;
using System.Linq;
using GuidesAdvice.Progression;

namespace GuidesAdvice.Progression.Hints
{
    public static class HintManager
    {
        public static string GetHint(GuideAdvicePlayer player)
        {
            List<HintDefinition> stageHints = GetHintsForCurrentStage();
            List<HintDefinition> available = stageHints
                .Where(hint => hint.IsAvailable())
                .ToList();

            if (available.Count == 0)
                return "I don't have a useful hint for this moment. Keep exploring, "
                    + "and come back after you've made a little more progress.";

            List<HintDefinition> unseen = available
                .Where(hint => !player.HasSeenHint(hint.Id))
                .ToList();

            // Start a fresh cycle only after every currently applicable hint
            // in this stage has been shown.
            if (unseen.Count == 0)
            {
                player.ResetHintCycle(available.Select(hint => hint.Id));
                unseen = available;
            }

            HintDefinition selected = unseen[Terraria.Main.rand.Next(unseen.Count)];
            player.MarkHintSeen(selected.Id);
            return selected.Text;
        }

        private static List<HintDefinition> GetHintsForCurrentStage()
        {
            switch (ProgressionManager.GetCurrentStage())
            {
                case ProgressionStage.EarlyPreHardmode:
                    return EarlyPreHardmodeHints.All;

                case ProgressionStage.EvilBiome:
                    return EvilBiomeHints.All;

                case ProgressionStage.Dungeon:
                    return DungeonHints.All;

                case ProgressionStage.Underworld:
                    return UnderworldHints.All;

                case ProgressionStage.EarlyHardmode:
                    return EarlyHardmodeHints.All;

                case ProgressionStage.PostMech:
                    return PostMechHints.All;

                case ProgressionStage.PostPlantera:
                    return PostPlanteraHints.All;

                case ProgressionStage.PostGolem:
                    return PostGolemHints.All;

                case ProgressionStage.PostCultist:
                    return PostCultistHints.All;

                default:
                    return CompletedHints.All;
            }
        }
    }
}
