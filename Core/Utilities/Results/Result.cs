using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //DRY
        public Result(bool success, string message):this(success)
        {
            
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
            
        }

        //Read-only field'lar ctor da set edilebilir.
        public bool Success { get; }

        public string Message { get; }
    }
}
