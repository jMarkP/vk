using System.Collections;
using System.Collections.Generic;

namespace vk.registry.model
{
    public class WrappedEnumerable<T> : IEnumerable<T>
    {
        protected T[] _elements;


        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_elements).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _elements.GetEnumerator();
        }
    }
}
