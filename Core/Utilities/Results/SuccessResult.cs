using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message): base (true, message) 
        { 
            
        }
        public SuccessResult (): base(true)  //Burada mesaj vermek istemeyen kişi sadece true döndürmüş olur. default vermiş olduk
        { 
        
        }
    }
}
