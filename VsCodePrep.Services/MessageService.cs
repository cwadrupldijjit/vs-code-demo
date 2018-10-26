using System;

namespace VsCodePrep.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "This is my first message from the back-end";
        }

        public string GetSecondMessage()
        {
            return "This is another message to the front-end";
        }
    }
}
