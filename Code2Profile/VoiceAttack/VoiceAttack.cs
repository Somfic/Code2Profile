using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public VoiceAttackBuilder AddCommand(CommandBuilder command)
        {
            return AddCommand(command.BuildCommand());
        }

        /// <summary>
        /// Add a new command to the profile.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        public VoiceAttackBuilder AddCommand(Command command)
        {
            ProfileCommand c = new ProfileCommand
            {
                //Setup command from object.
                CommandString = command.Phrase,
                UseSpokenPhrase = command.IsVoiced,
                Async = command.IsAsync,
                BaseId = command.ID.ToString(),
                Enabled = command.IsEnabled,
                SessionEnabled = command.IsEnabled,
                Id = command.ID.ToString(),

                //Standard stuff.
                ExecType = 3,
                ProcessOverrideActiveWindow = true,
                LostFocusBackCompat = true,
                OriginId = Guid.Empty.ToString(),
                SourceProfile = Guid.Empty.ToString(),
                lastEditedAction = Guid.Empty.ToString()
            };

            //Add the actions.
            List<ProfileCommandCommandAction> actions = new List<ProfileCommandCommandAction>();
            foreach (IVoiceAttackAction action in command.Actions)
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

            StringWriter stringWriter = new StringWriter();
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings() { Indent = true };
            XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);

            xmlVap.Serialize(xmlWriter, vap);
            File.WriteAllText($"{outputDirectory.FullName}\\{vap.Name}.vap", stringWriter.ToString());

            return this;
        }
    }
}
