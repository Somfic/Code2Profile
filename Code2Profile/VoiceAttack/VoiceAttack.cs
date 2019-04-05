using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Code2Profile.VoiceAttack
{
    public class VoiceAttackBuilder
    {
        private Profile vap;

        /// <summary>
        /// Create a new VoiceAttack profile.
        /// </summary>
        /// <param name="name">The name of the profile.</param>
        /// <returns></returns>
        public VoiceAttackBuilder CreateProfile(string name)
        {
            vap = new Profile();
            vap.Name = name;
            vap.Id = Guid.NewGuid().ToString();
            vap.ExportVAVersion = "1.7.5";
            vap.ExportOSVersionMajor = (byte)Environment.OSVersion.Version.Major;
            vap.ExportOSVersionMinor = (byte)Environment.OSVersion.Version.Minor;
            vap.Commands = new List<ProfileCommand>().ToArray();

            return this;
        }

        /// <summary>
        /// Add a new command to the profile.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public VoiceAttackBuilder AddCommand(Command command)
        {
            ProfileCommand c = new ProfileCommand();
                
            //Setup command from object.
            c.CommandString = command.Phrase;
            c.UseSpokenPhrase = command.IsVoiced; 
            c.Async = command.IsAsync;
            c.BaseId = command.ID.ToString();
            c.Enabled = command.IsEnabled;
            c.SessionEnabled = command.IsEnabled;

            //Standard stuff.
            c.ExecType = 3;
            c.ProcessOverrideActiveWindow = true;
            c.LostFocusBackCompat = true;

            //Add the actions.
            List<ProfileCommandCommandAction> actions = new List<ProfileCommandCommandAction>();
            command.Actions.ForEach(x => actions.Add(x.GetAction()));
            c.ActionSequence = actions.ToArray();

            //Add the command.
            List<ProfileCommand> commands = vap.Commands.ToList();
            commands.Add(c);
            vap.Commands = commands.ToArray();

            return this;
        }

        /// <summary>
        /// Export the profile as a .vap file.
        /// </summary>
        /// <param name="outputDirectory">The output directory.</param>
        /// <returns></returns>
        public VoiceAttackBuilder Export(DirectoryInfo outputDirectory)
        {
            XmlSerializer xmlVap = new XmlSerializer(typeof(Profile));
            string xml = string.Empty;

            var stringWriter = new StringWriter();
            var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
            XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);

            xmlVap.Serialize(xmlWriter, vap);
            File.WriteAllText($"{outputDirectory.FullName}\\{vap.Name}.vap", stringWriter.ToString());

            return this;
        }
    }
}
