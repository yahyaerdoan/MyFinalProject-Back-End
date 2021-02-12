using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message) : this(success) // This diğer metoduda çalıştır demektir. 
        {
            Message = message;            
        }
        public Result(bool success ) // mesaj vermek istemediğimizde yaptığımız işlem 
                                    // bu duruma overloding deniyor aşırı yükleme 
        {
           Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
