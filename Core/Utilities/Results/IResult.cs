using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç
    //son kullanıcıyı doğru bilgilendirmek için 
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
