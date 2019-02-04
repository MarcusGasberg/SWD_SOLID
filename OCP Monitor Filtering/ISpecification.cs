using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
