using System;

namespace CAManager
{
    class ConstractorMessage
    {
        string text;
        string command;
        int count;
        public ConstractorMessage()
        {
            Clear();
        }
        public void AddData(string str)
        {
            if (text.Trim() == "")
                text = str;
            else
                text = text + " " + str;
            count++;
        }
        public void AddCommand(string command)
        {
            this.command = command;
        }
        public string GetEncriptMessage(string pubKey, string prvKey, string _command = "", string guid = "")
        {
            string _text = text;
            _text = DateTime.Now.ToString() + ((text == "") ? "" : " " + _text);
            if (command.Trim() != "" && _command.Trim() == "")
                _command = command;
            string message = "";
            int rCount = count;
            if (_command != "")
                rCount++;
            if (guid.Trim() != "")
            {
                message = guid + " " + ++rCount;
            }
            else
                message = rCount.ToString();

            message = message + " " + (_command.Trim() != "" ? _command + " " + _text : _text);

            message = message + " " + Cryptography.Cryptography.GetHash(message);
            message = message + " " + Cryptography.Cryptography.Sign(message, prvKey);
            message = Cryptography.Cryptography.Encrypt(message, pubKey);
            return message;
        }
        public void Clear()
        {
            text = "";
            command = "";
            count = 4;
        }
    }
}
