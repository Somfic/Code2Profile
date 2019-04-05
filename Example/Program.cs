using System;
using System.IO;
using Code2Profile.VoiceAttack;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            VoiceAttackBuilder vap = new VoiceAttackBuilder();
            vap.CreateProfile("testing!");
            Command c = vap.AddCommand(new CommandBuilder().UsePhrase("Hello there").UsePhrase(false).SetEnabled(true).SetAsync(false).Build());
            vap.AddAction(c, new ActionPressKey('c'));
            vap.Export(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
