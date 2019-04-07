
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
                        .AddAction(new PauseAction() { Miliseconds = 10 })
                    .BuildCommand())
                .BuildProfile(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
