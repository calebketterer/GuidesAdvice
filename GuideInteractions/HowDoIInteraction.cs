using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent;
using GuidesAdvice.Progression;

namespace GuidesAdvice.GuideInteractions
{
    public class HowDoIInteraction : NPCInteraction
    {
        public override string GetText() => "How do I do that?";

        public override bool Condition() => BossProgression.HasNextVitalBoss();

        public override void Interact()
        {
            Main.npcChatText = GuideAdviceText.GetSummonInstructions();
        }
    }
}
