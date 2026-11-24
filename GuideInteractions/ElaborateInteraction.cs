
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent;

namespace GuidesAdvice.GuideInteractions
{
    public class ElaborateInteraction : NPCInteraction
    {
        public override string GetText()
        {
            return "Elaborate";
        }

        public override bool Condition()
        {
            return !Main.LocalPlayer
                .GetModPlayer<GuideAdvicePlayer>()
                .ShowingDetails;
        }

        public override void Interact()
        {
            GuideAdvicePlayer player =
                Main.LocalPlayer.GetModPlayer<GuideAdvicePlayer>();

            player.ShowingDetails = true;

            Main.npcChatText =
                GuideAdviceText.GetElaboration();
        }
    }
}
