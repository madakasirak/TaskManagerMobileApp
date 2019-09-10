using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Enums;

namespace TaskManager.Models
{
    public class LoginResponseArgs
    {
        ResponseCode _responseCode;

        public ResponseCode ResponseCode => _responseCode;

        string _message;
        public string Message => _message;

        public LoginResponseArgs(ResponseCode responseCode, string message)
        {
            this._responseCode = responseCode;
            this._message = message;
        }
    }
}
