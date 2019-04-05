using System;
using System.Collections.Generic;

namespace Code2Profile.VoiceAttack
{
    public class Command
    {
        public string Phrase { get; internal set; } = "";
        public Guid ID { get; internal set; } = Guid.NewGuid();
        public bool IsEnabled { get; internal set; } = true;
        public bool IsAsync { get; internal set; } = false;
        public bool IsVoiced { get; internal set; } = true;
        public int MinimalConfidence { get; internal set; } = 0;
        public List<IAction> Actions { get; internal set; } = new List<IAction>();
    }
}
