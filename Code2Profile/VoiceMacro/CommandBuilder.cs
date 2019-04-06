using System;
using System.Collections.Generic;

namespace Code2Profile.VoiceMacro
{
    public class CommandBuilder
    {
        private readonly Command command;

        /// <summary>
        /// Create a new CommandBuilder.
        /// </summary>
        public CommandBuilder()
        {
            command = new Command();
        }

        /// <summary>
        /// Continue building a command.
        /// </summary>
        /// <param name="command">The command.</param>
        public CommandBuilder(Command command)
        {
            this.command = command;
        }

        /// <summary>
        /// Build the command.
        /// </summary>
        /// <returns></returns>
        public Command BuildCommand()
        {
            command.ID = Guid.NewGuid();

            return command;
        }

        /// <summary>
        /// Set the spoken phrase that triggers the command.
        /// </summary>
        /// <param name="phrase">Sentence.</param>
        /// <returns></returns>
        public CommandBuilder UsePhrase(string phrase)
        {
            command.Phrase = phrase;
            command.UseRecognition = true;
            return this;
        }

        /// <summary>
        /// Whether the phrase is enabled.
        /// </summary>
        /// <param name="usePhrase"></param>
        /// <returns></returns>
        public CommandBuilder UsePhrase(bool usePhrase)
        {
            command.UseRecognition = usePhrase;
            return this;
        }
    }
}
