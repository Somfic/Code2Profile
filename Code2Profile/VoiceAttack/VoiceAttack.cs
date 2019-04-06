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
            vap = new Profile
            {
                Name = name,
                Id = Guid.NewGuid().ToString(),
                ExportVAVersion = "1.7.5",
                ExportOSVersionMajor = Environment.OSVersion.Version.Major,
                ExportOSVersionMinor = Environment.OSVersion.Version.Minor,
                Commands = new List<ProfileCommand>().ToArray(),
                LastEditedCommand = Guid.Empty.ToString(),
                CategoryGroups = ""
            };

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
            c.Id = command.ID.ToString();

            //Standard stuff.
            c.ExecType = 3;
            c.ProcessOverrideActiveWindow = true;
            c.LostFocusBackCompat = true;
            c.OriginId = Guid.Empty.ToString();
            c.SourceProfile = Guid.Empty.ToString();
            c.lastEditedAction = Guid.Empty.ToString();

            //Add the actions.
            List<ProfileCommandCommandAction> actions = new List<ProfileCommandCommandAction>();
            foreach (var action in command.Actions)
            {
                ProfileCommandCommandAction a = action.GetAction();
                //a.KeyCodes = new ProfileCommandCommandActionKeyCodes();
                a.Caption = "";
                a._caption = "";
                a.RandomSounds = "";
                actions.Add(a);
            }

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
        public VoiceAttackBuilder BuildProfile(DirectoryInfo outputDirectory)
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
