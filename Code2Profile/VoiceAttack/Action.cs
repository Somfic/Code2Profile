using System;
using System.Windows.Forms;

namespace Code2Profile.VoiceAttack
{
    public interface IVoiceAttackAction
    {
        Guid ID { get; }
        bool Enabled { get; }
        string ActionType { get; }

        ProfileCommandCommandAction GetAction();
    }

    public class KeyPressAction : IVoiceAttackAction
    {
        public KeyPressAction(Keys key)
        {
            KeyCode = key;
        }

        public KeyPressAction(char key)
        {
            KeyCode = (Keys)key;
        }

        public KeyPressAction(int key)
        {
            KeyCode = (Keys)key;
        }

        public KeyPressAction SetDuration(decimal duration)
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

    public class KeyDownAction : IVoiceAttackAction
    {
        public KeyDownAction(Keys key)
        {
            KeyCode = key;
        }

        public KeyDownAction(char key)
        {
            KeyCode = (Keys)key;
        }

        public KeyDownAction(int key)
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

    public class KeyUpAction : IVoiceAttackAction
    {
        public KeyUpAction(Keys key)
        {
            KeyCode = key;
        }

        public KeyUpAction(char key)
        {
            KeyCode = (Keys)key;
        }

        public KeyUpAction(int key)
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

    public class PauseAction : IVoiceAttackAction
    {
        public PauseAction(decimal duration)
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

    public class SayAction : IVoiceAttackAction
    {
        public SayAction(string sentence)
        {
            Sentence = sentence;
        }

        public SayAction SetVoice(string voice)
        {
            Voice = voice;
            return this;
        }

        public SayAction SetVolume(int volume)
        {
            Volume = volume;
            return this;
        }

        public SayAction SetSpeed(int speed)
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