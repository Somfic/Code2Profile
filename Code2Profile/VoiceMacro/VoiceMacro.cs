using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Code2Profile.VoiceMacro
{
    public class VoiceMacroBuilder
    {
        private VoiceMacroProfile vmp;

        public VoiceMacroBuilder CreateProfile(string name)
        {
            vmp = new VoiceMacroProfile
            {
                ProfileName = name,
                TargetWindow = "[Active Window]",
                GUID = Guid.NewGuid().ToString(),
                Commands = new List<VoiceMacroProfileCommands>().ToArray()
            };

            return this;
        }

        public VoiceMacroBuilder AddCommand(Command command)
        {
            VoiceMacroProfileCommands c = new VoiceMacroProfileCommands
            {

                //Setup from object.
                GUID = command.ID.ToString(),
                RecocnitionText = command.Phrase,
                ShortCut = command.Shortcut,
                UseRecognitionSpecified = true,
                UseRecognition = command.UseRecognition,

                //Add the actions.
                MacroActions = command.MacroActions.ToArray()
            };

            //Add the command.
            List<VoiceMacroProfileCommands> commands = vmp.Commands.ToList();
            commands.Add(c);
            vmp.Commands = commands.ToArray();

            return this;
        }


        public VoiceMacroBuilder AddCommand(CommandBuilder builder)
        {
            return AddCommand(builder.BuildCommand());
        }


        /// <summary>
        /// Export the profile as a .xml file.
        /// </summary>
        /// <param name="outputDirectory">The output directory.</param>
        /// <returns></returns>
        public VoiceMacroBuilder BuildProfile(DirectoryInfo outputDirectory)
        {
            XmlSerializer xmlVap = new XmlSerializer(typeof(VoiceMacroProfile));
            string xml = string.Empty;

            StringWriter stringWriter = new StringWriter();
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings() { Indent = true };
            XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);

            xmlVap.Serialize(xmlWriter, vmp);
            File.WriteAllText($"{outputDirectory.FullName}\\{vmp.ProfileName}.xml", stringWriter.ToString());

            return this;
        }
    }
}
