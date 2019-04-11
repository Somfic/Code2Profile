using System.IO;

namespace Examples.VoiceMacro
{
    using Code2Profile.VoiceMacro;

    internal class VoiceMacro
    {
        private static void Main(string[] args)
        {
            new VoiceMacroBuilder()
                .CreateProfile("test")
                    .AddCommand(new CommandBuilder()
                        .UsePhrase("Test command")
                        .AddAction(new PauseAction() { Miliseconds = 10 }))
                    .AddCommand(new CommandBuilder()
                        .UsePhrase("Testing")
                        .AddAction(new SpeakTextAction() { Text = "Hello!" }))
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}

namespace Examples.VoiceAttack
{
    using Code2Profile.VoiceAttack;

    internal class VoiceAttack
    {
        private static void Main(string[] args)
        {
            new VoiceAttackBuilder()
                .CreateProfile("test")
                    .AddCommand(new CommandBuilder()
                        .UsePhrase("Test command")
                        .AddAction(new PauseAction(10))
                    .AddCommand(new CommandBuilder()
                        .UsePhrase("Testing")
                        .AddAction(new SpeakTextAction() { Text = "Hello!" }))
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
