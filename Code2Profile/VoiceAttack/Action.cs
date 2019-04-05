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

        public ActionKeyPress(int key)
        {
            KeyCode = (Keys)key;
        }

        public ActionKeyPress SetDuration(decimal duration)
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

        public ActionKeyDown(int key)
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

        public ActionKeyUp(int key)
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

    public class ActionSay : IAction
    {
        public ActionSay(string sentence)
        {
            Sentence = sentence;
        }

        public ActionSay SetVoice(string voice)
        {
            Voice = voice;
            return this;
        }

        public ActionSay SetVolume(int volume)
        {
            Volume = volume;
            return this;
        }

        public ActionSay SetSpeed(int speed)
        {
            Speed = speed;
            return this;
        }

        public string Voice { get; internal set; } = "Default";

        public int Volume { get; internal set; } = 100;

        public int Speed { get; internal set; } = 0;

        public Guid ID { get; internal set; } = Guid.NewGuid();

        public bool Enabled { get; internal set; } = true;

        public string ActionType => "Say";

        public string Sentence { get; internal set; }

        public ProfileCommandCommandAction GetAction()
        {
            return new ProfileCommandCommandAction()
            {
                Id = ID.ToString(),
                Disabled = !Enabled,
                ActionType = ActionType,
                Context = Sentence,
                Context3 = Guid.Empty.ToString(),
                Context4 = Voice,
                X = Volume,
                Y = Speed
            };
        }
    }
}