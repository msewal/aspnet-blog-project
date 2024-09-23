using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloggerMewl.Shared.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult // T=Type
    {
        public T Data { get; }
    }
}
