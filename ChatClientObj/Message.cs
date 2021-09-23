using System;

namespace ChatClientObj
{
    public class Message
    {
        public string Body{get; set;}
        public DateTimeOffset TimeStamp; 

        public Message(string body)
        {
            Body = body;
            TimeStamp= DateTimeOffset.Now;
        }

        public override string ToString()
        {
            return "Message: " + Body +" ,  Time: "+ TimeStamp;
        }
    }
}