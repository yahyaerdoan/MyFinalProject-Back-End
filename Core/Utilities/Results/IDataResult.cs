using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; } // ürünler vb data döndürecek (generic ) yapmış olduk
                        // interfaceler bu şekilde implement ediliyor
    }
}
