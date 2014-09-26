using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using boolean = System.Boolean;
//using Set = System.Collections.Generic.HashSet;
//using ArrayList = System.Collections.Generic.List;
//using Map = System.Collections.Generic.Dictionary;

namespace CppNet
{
    static class JavaCompat
    {
        public static StringBuilder append(this StringBuilder bld, object value)
        {
            return bld.Append(value);
        }

        public static int length(this string str)
        {
            return str.Length;
        }

        public static char charAt(this string str, int i)
        {
            return str[i];
        }

        public static T get<T>(this List<T> list, int i)
        {
            return list[i];
        }

        public static Iterator<T> iterator<T>(this List<T> list)
        {
            return new ListIterator<T>(list);
        }

        public static string toString(this object o)
        {
            return o.ToString();
        }
    }

    class ListIterator<T> : Iterator<T>
    {
        List<T> _list;
        int _index;

        public ListIterator(List<T> list)
        {
            _list = list;
        }

        public boolean hasNext()
        {
            return _index < _list.Count;
        }

        public T next()
        {
            return _list[_index++];
        }

        public void remove()
        {
            throw new NotImplementedException();
        }
    }

    public interface Closeable
    {
        void close();
    }

    public interface Iterable<T>
    {
        Iterator<T> iterator();
    }

    public interface Iterator<T>
    {
        boolean hasNext();
        T next();
        void remove();
    }

    public class IllegalStateException : Exception
    {
        public IllegalStateException(Exception ex) : base("Illegal State", ex) { }
    }


}
