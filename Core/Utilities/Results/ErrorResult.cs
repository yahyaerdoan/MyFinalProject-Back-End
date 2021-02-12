using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }
        public ErrorResult() : base(false)  //Burada mesaj vermek istemeyen kişi sadece false döndürmüş olur. default vermiş olduk
        {

        }
    }
}
