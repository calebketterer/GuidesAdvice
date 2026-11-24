
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent;

namespace GuidesAdvice.GuideInteractions
{
    public class BackToHintInteraction : NPCInteraction
    {
        public override string GetText()
        {
            return "Back";
        }

        public override bool Condition()
        {
            return Main.LocalPlayer
                .GetModPlayer<GuideAdvicePlayer>()
                .ShowingDetails;
        }

        public override void Interact()
        {
            GuideAdvicePlayer player =
                Main.LocalPlayer.GetModPlayer<GuideAdvicePlayer>();

            player.ShowingDetails = false;

            Main.npcChatText =
                GuideAdviceText.GetHint();
        }
    }
}
