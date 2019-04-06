using Code2Profile.VoiceAttack;
using Code2Profile.VoiceMacro;
using System.IO;

namespace Examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new VoiceAttackBuilder()
                .CreateProfile("test")
                        .AddCommand(new Code2Profile.VoiceAttack.CommandBuilder()
                            .UsePhrase("Hello")
                            .AddAction(new ActionSay("Hello there"))
                        .BuildCommand())
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));

            new VoiceMacroBuilder()
                .CreateProfile("test")
                    .AddCommand(new Code2Profile.VoiceMacro.CommandBuilder()
                        .UsePhrase("testing123!")
                    .BuildCommand())
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
