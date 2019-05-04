using System;
using System.Linq;

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

        /// <summary>
        /// Add an action to the command.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        public CommandBuilder AddAction(IVoiceMacroAction action)
        {
            string actionType = action.GetType().Name.Replace("Action", string.Empty);

            MacroAction a = new MacroAction();

            if (actionType == "Pause") { a.Pause = ((PauseAction)action).Miliseconds; }
            else if (actionType == "FindWindowAndActivate") { a.FindWindowAndActivate = ((FindWindowAndActivateAction)action).Windowname; }
            else if (actionType == "StartStopListen") { a.StartStopListen = (short?)((StartStopListenAction)action).WantedAction; }
            else if (actionType == "StartStopExecute") { a.StartStopExecute = (short?)((StartStopExecuteAction)action).WantedAction; }
            else if (actionType == "StartStopAutoProfile") { a.StartStopAutoProfile = (short?)((StartStopAutoProfileAction)action).WantedAction; }
            else if (actionType == "StartStopShortCuts") { a.StartStopShortCuts = (short?)((StartStopShortCutsAction)action).WantedAction; }
            else if (actionType == "MinRestToggleVM") { a.MinRestToggleVM = (short?)((MinRestToggleVMAction)action).WantedAction; }
            else if (actionType == "StartStopScheduler") { a.StartStopScheduler = (short?)((StartStopSchedulerAction)action).WantedAction; }
            else if (actionType == "StartStopIgnoreCommands") { a.StartStopIgnoreCommands = (short?)((StartStopIgnoreCommandsAction)action).WantedAction; }
            else if (actionType == "ChangeEngine") { a.ChangeEngine = ((ChangeEngineAction)action).WantedEngine; }
            else if (actionType == "BlockInput") { a.BlockInput = ((BlockInputAction)action).DoBlocking; }
            else if (actionType == "Clipboard") { a.Clipboard = (short?)((ClipboardAction)action).WantedAction; }
            else if (actionType == "HideOSD") { a.HideOSD = ((HideOSDAction)action).WantedOSD; }
            else if (actionType == "Comment") { a.Comment = ((CommentAction)action).WantedComment; }
            else if (actionType == "Label") { a.Label = ((LabelAction)action).WantedLabel; }
            else if (actionType == "GotoLabel") { a.GotoLabel = ((GotoLabelAction)action).WantedLabel; }
            else if (actionType == "Condition")
            {
                //Custom code to add in conditions.
                ConditionAction ac = (ConditionAction)action;

                IfElseIfAction openingAction = new IfElseIfAction
                {
                    IfOrElseIf = true,
                    Condition = ac.Condition
                };

                //Add the opening of the statement.
                AddAction(openingAction);

                //Add all the actions for when the statement is true.
                if (ac.ActionsIfTrue.Count != 0)
                {
                    ac.ActionsIfTrue.ForEach(x => AddAction(x));
                }

                //If the user has set actions for when the statement is false, add them.
                if (ac.ActionsIfFalse.Count != 0)
                {
                    command.MacroActions.Add(new MacroAction() { MacroType = 121 });
                    ac.ActionsIfFalse.ForEach(x => AddAction(x));
                }

                //Add the ending of the statement.
                command.MacroActions.Add(new MacroAction() { MacroType = 122 });

                return this;
            }
            else { a.GetType().GetFields().FirstOrDefault(x => x.Name == actionType).SetValue(a, action); }

            a.MacroType = a.GetMacroType();
            command.MacroActions.Add(a);
            return this;
        }
    }
}
