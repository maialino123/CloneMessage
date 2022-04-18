using System;
using System.Collections.Generic;
using System.Text;

namespace CloneMessage.Services.IService
{
    public interface IDataService<T> where T : class
    {
        List<T> GetAll();
    }
}
