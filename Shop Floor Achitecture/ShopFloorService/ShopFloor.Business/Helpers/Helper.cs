using System;
using System.Collections.Generic;
using System.Text;

namespace ShopFloor.Business.Helpers
{
    public class Helper<T>
    {        
        public T GetObject()
        {
            T _object = (T)Activator.CreateInstance(typeof(T));
            return _object;
        }
    }
}
