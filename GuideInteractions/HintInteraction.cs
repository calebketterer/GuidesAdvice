using Terraria;
using Terraria.GameContent;

namespace GuidesAdvice.GuideInteractions
{
    public class HintInteraction : NPCInteraction
    {
        public override string GetText() => "Hint";

        public override bool Condition() => true;

        public override void Interact()
        {
            GuideAdvicePlayer player = Main.LocalPlayer.GetModPlayer<GuideAdvicePlayer>();
            Main.npcChatText = GuideAdviceText.GetRandomHint(player);
        }
    }
}
