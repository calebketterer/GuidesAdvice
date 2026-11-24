using Terraria;
using Terraria.GameContent;

namespace GuidesAdvice.GuideInteractions
{
    public class WhatsNextInteraction : NPCInteraction
    {
        public override string GetText() => "What's Next?";

        public override bool Condition() => true;

        public override void Interact()
        {
            Main.npcChatText = GuideAdviceText.GetNextObjective();
        }
    }
}
