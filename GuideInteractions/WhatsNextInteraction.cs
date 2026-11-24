using Terraria;
using Terraria.GameContent;

namespace GuidesAdvice.GuideInteractions
{
    public class WhatsNextInteraction : NPCInteraction
    {
        public override string GetText()
        {
            GuideAdvicePlayer player = LocalPlayer.GetModPlayer<GuideAdvicePlayer>();
            return player.ShowingWhatHelps ? "What Helps?" : "What's Next?";
        }

        public override bool Condition() => true;

        public override void Interact()
        {
            GuideAdvicePlayer player = LocalPlayer.GetModPlayer<GuideAdvicePlayer>();

            if (!player.ShowingWhatHelps)
            {
                Main.npcChatText = GuideAdviceText.GetNextObjective(TalkNPC);
                player.ShowingWhatHelps = true;
            }
            else
            {
                Main.npcChatText = GuideAdviceText.GetBossFightTips(TalkNPC);
            }
        }
    }
}
