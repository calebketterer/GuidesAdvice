using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace GuidesAdvice
{
    public class GuideAdvicePlayer : ModPlayer
    {
        // Hint IDs are saved per character. Each progression stage has its own
        // cycle, so reaching a new stage does not erase earlier history.
        private readonly HashSet<string> seenHintIds = new HashSet<string>();
        public string LastSmallTalkId { get; private set; } = string.Empty;

        // Temporary state for the Guide's two-step primary conversation button.
        public bool ShowingWhatHelps { get; set; } = false;

        public void SetLastSmallTalkId(string id)
        {
            LastSmallTalkId = id;
        }

        public bool HasSeenHint(string hintId)
        {
            return seenHintIds.Contains(hintId);
        }

        public void MarkHintSeen(string hintId)
        {
            seenHintIds.Add(hintId);
        }

        public void ResetHintCycle(IEnumerable<string> hintIds)
        {
            foreach (string hintId in hintIds)
                seenHintIds.Remove(hintId);
        }

        public override void SaveData(TagCompound tag)
        {
            tag["GuideAdvice_SeenHints"] = new List<string>(seenHintIds);
            tag["GuideAdvice_LastSmallTalk"] = LastSmallTalkId;
        }

        public override void LoadData(TagCompound tag)
        {
            seenHintIds.Clear();
            LastSmallTalkId = tag.ContainsKey("GuideAdvice_LastSmallTalk")
                ? tag.GetString("GuideAdvice_LastSmallTalk")
                : string.Empty;

            if (tag.ContainsKey("GuideAdvice_SeenHints"))
            {
                foreach (string hintId in tag.GetList<string>("GuideAdvice_SeenHints"))
                    seenHintIds.Add(hintId);
            }
        }
    }
}
