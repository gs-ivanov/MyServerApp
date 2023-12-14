﻿namespace MyServer.Responses
{
    using System;

    public class TextResponse:ContentResponse
    {
        public TextResponse(string text)
            :base(text,"text/plain; charset=UTF-8")
        {
        }
    }
}
