using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.EntityFramework
{
    public interface IEntityValidator
    {
        Dictionary<string, string> Validate<T>(T entity) where T : class;
    }
}
