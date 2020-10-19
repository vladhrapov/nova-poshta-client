using System;
using System.Collections.Generic;
using System.Text;

namespace NovaPoshta.Client.Models
{
    public sealed class ErrorModel
    {
        public ErrorModel(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; private set; }
        public string Message { get; private set; }
    }
}
