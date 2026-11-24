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
        public override void GetChat(NPC npc, ref string chat)
        {
            if (npc.type != NPCID.Guide)
                return;

            // Preserve vanilla randomized dialogue, with occasional stage-appropriate additions.
            GuideAdvicePlayer player = Main.LocalPlayer.GetModPlayer<GuideAdvicePlayer>();
            player.ShowingWhatHelps = false;

            if (Main.rand.Next(4) == 0)
                chat = Progression.GuideSmallTalk.GetMessage(player);
        }

        public override void RegisterChatButtons(
            NPC npc,
            NPCInteractionList interactions)
        {
            if (npc.type != NPCID.Guide)
                return;

            // Replace the vanilla Guide Tip in its original position instead of appending
            // our buttons after the default interactions, which can push Hint onto a new row.
            var vanillaTip = interactions.Interactions
                .OfType<NPCInteractions.Actions.GuideTip>()
                .FirstOrDefault();


            // Housing advice is now part of What's Next? until the Guide has a home.
            interactions.Disable(NPCInteractionDatabase.HousingButton);
            if (vanillaTip != null){
                    interactions.InsertBefore(new HintInteraction(), vanillaTip);
                    interactions.Disable(vanillaTip);
                }
                
            interactions.Append(new WhatsNextInteraction());
        }
    }
}
