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

            // Most of the time we leave the vanilla randomized dialogue untouched.
            // Occasionally, a stage-appropriate mod message is selected as an
            // additional entry in the effective dialogue pool.
            GuideAdvicePlayer player = Main.LocalPlayer.GetModPlayer<GuideAdvicePlayer>();
            if (Main.rand.Next(4) == 0)
                chat = Progression.GuideSmallTalk.GetMessage(player);
        }

        public override void RegisterChatButtons(
            NPC npc,
            NPCInteractionList interactions)
        {
            if (npc.type != NPCID.Guide)
                return;

            // Our Hint button replaces the vanilla Guide Tip button.
            var vanillaTip = interactions.Interactions
                .OfType<NPCInteractions.Actions.GuideTip>()
                .FirstOrDefault();

            if (vanillaTip != null)
                interactions.Disable(vanillaTip);

            interactions.Append(new WhatsNextInteraction());
            interactions.Append(new HowDoIInteraction());
            interactions.Append(new HintInteraction());
        }
    }
}
