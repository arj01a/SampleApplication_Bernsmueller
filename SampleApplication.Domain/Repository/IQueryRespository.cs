using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Domain.Repository
{
    public interface IQueryRespository<out T> : IDisposable where T : IEntity
    {
    }
}
