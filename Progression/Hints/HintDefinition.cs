using System;

namespace GuidesAdvice.Progression.Hints
{
    public sealed class HintDefinition
    {
        public string Id { get; }
        public string Text { get; }
        public Func<bool> IsAvailable { get; }

        public HintDefinition(string id, string text, Func<bool> isAvailable = null)
        {
            Id = id;
            Text = text;
            IsAvailable = isAvailable ?? (() => true);
        }
    }
}
