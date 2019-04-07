
using Code2Profile.VoiceMacro;
using System.IO;
using System.Windows.Forms;

namespace Examples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new VoiceMacroBuilder()
                .CreateProfile("test")
                    .AddCommand(new CommandBuilder()
                        .UsePhrase("Test command")
                        .AddAction(new KeyboardAction() { Key = Keys.A })
                        .AddAction(new SpeakTextAction() { Text = "Hello from C#!", Volume = 100, Speed = 0 })
                    .BuildCommand())
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
