﻿namespace Chat_AnwendungLib
{
    public class Message
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public Message(string text)
        {
            Date = DateTime.Now;
            Text = text;
        }
    }
}
