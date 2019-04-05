using Code2Profile.VoiceAttack;
using System.IO;

namespace Examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new VoiceAttackBuilder()
                .CreateProfile("test")
                        .AddCommand(new CommandBuilder()
                            .UsePhrase("Hello")
                            .AddAction(new ActionSay("Hello there"))
                        .BuildCommand())
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
