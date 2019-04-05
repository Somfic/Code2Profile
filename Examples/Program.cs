using Code2Profile.VoiceAttack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            VoiceAttackBuilder vapb = new VoiceAttackBuilder();
            vapb.CreateProfile("testing!")
                .AddCommand(new CommandBuilder()
                    .UsePhrase("Hello there")
                    .AddAction(new ActionKeyPress(Keys.A))
                    .AddAction(new ActionPause(2))
                    .Build())
                .AddCommand(new CommandBuilder()
                    .UsePhrase("Hello again!")
                    .AddAction(new ActionKeyDown(Keys.Add))
                    .Build())
                .Export(new DirectoryInfo(Directory.GetCurrentDirectory()));
        }
    }
}
