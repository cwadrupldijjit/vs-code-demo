﻿using System;

namespace VsCodePrep.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "This is my message to the front-end";
        }
    }
}
