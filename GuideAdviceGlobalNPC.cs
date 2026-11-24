
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent;
using GuidesAdvice.GuideInteractions;

namespace GuidesAdvice
{
    public class GuideAdviceGlobalNPC : GlobalNPC
    {
        public override void GetChat(
            NPC npc,
            ref string chat)
        {
            if (npc.type != NPCID.Guide)
                return;

            GuideAdvicePlayer player =
                Main.LocalPlayer.GetModPlayer<GuideAdvicePlayer>();

            player.ShowingDetails = false;

            chat = GuideAdviceText.GetHint();
        }

        public override void RegisterChatButtons(
            NPC npc,
            NPCInteractionList interactions)
        {
            if (npc.type != NPCID.Guide)
                return;

            var vanillaTip = interactions.Interactions
                .OfType<NPCInteractions.Actions.GuideTip>()
                .FirstOrDefault();

            interactions.Disable(vanillaTip);

            interactions.Append(new ElaborateInteraction());
            interactions.Append(new BackToHintInteraction());
        }
    }
}
