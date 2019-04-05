using System;
using System.Windows.Forms;

namespace Code2Profile.VoiceAttack
{
    public interface IAction
    {
        Guid ID { get; }
        bool Enabled { get; }
        string ActionType { get; }

        ProfileCommandCommandAction GetAction();
    }

    public class ActionKeyPress : IAction
    {
        public ActionKeyPress(Keys key)
        {
            KeyCode = key;
        }

        public ActionKeyPress(char key)
        {
            KeyCode = (Keys)key;
        }

        public ActionKeyPress(byte key)
        {
            KeyCode = (Keys)key;
        }

        public ActionKeyPress SetDuraction(decimal duration)
        {
            Duration = Math.Round(duration, 3);
            return this;
        }

        public decimal Duration { get; internal set; }
        public Guid ID { get; internal set; } = Guid.NewGuid();
        public bool Enabled { get; internal set; } = true;
        public string ActionType => "PressKey";
        public Keys KeyCode { get; internal set; }

        public ProfileCommandCommandAction GetAction()
        {
            return new ProfileCommandCommandAction
            {
                Duration = Duration,
                Id = ID.ToString(),
                Disabled = !Enabled,
                ActionType = ActionType,
                KeyCodes = new ProfileCommandCommandActionKeyCodes() { unsignedShort = (byte)KeyCode }
            };
        }
    }

    public class ActionKeyDown : IAction
    {
        public ActionKeyDown(Keys key)
        {
            KeyCode = key;
        }

        public ActionKeyDown(char key)
        {
            KeyCode = (Keys)key;
        }

        public ActionKeyDown(byte key)
        {
            KeyCode = (Keys)key;
        }

        public Guid ID { get; internal set; } = Guid.NewGuid();
        public bool Enabled { get; internal set; } = true;
        public string ActionType => "KeyDown";
        public Keys KeyCode { get; internal set; }

        public ProfileCommandCommandAction GetAction()
        {
            return new ProfileCommandCommandAction
            {
                Id = ID.ToString(),
                Disabled = !Enabled,
                ActionType = ActionType,
                KeyCodes = new ProfileCommandCommandActionKeyCodes() { unsignedShort = (byte)KeyCode }
            };
        }
    }

    public class ActionKeyUp : IAction
    {
        public ActionKeyUp(Keys key)
        {
            KeyCode = key;
        }

        public ActionKeyUp(char key)
        {
            KeyCode = (Keys)key;
        }

        public ActionKeyUp(byte key)
        {
            KeyCode = (Keys)key;
        }

        public Guid ID { get; internal set; } = Guid.NewGuid();
        public bool Enabled { get; internal set; } = true;
        public string ActionType => "KeyUp";
        public Keys KeyCode { get; internal set; }

        public ProfileCommandCommandAction GetAction()
        {
            return new ProfileCommandCommandAction
            {
                Id = ID.ToString(),
                Disabled = !Enabled,
                ActionType = ActionType,
                KeyCodes = new ProfileCommandCommandActionKeyCodes() { unsignedShort = (byte)KeyCode }
            };
        }
    }

    public class ActionPause : IAction
    {
        public ActionPause(decimal duration)
        {
            Duration = duration;
        }

        public Guid ID { get; internal set; } = Guid.NewGuid();
        public bool Enabled { get; internal set; } = true;
        public decimal Duration { get; internal set; }
        public string ActionType => "Pause";
        public ProfileCommandCommandAction GetAction()
        {
            return new ProfileCommandCommandAction
            {
                Id = ID.ToString(),
                Disabled = !Enabled,
                Duration = Duration,
                ActionType = ActionType
            };
        }
    }
}