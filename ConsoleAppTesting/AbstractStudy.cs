using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleAppTesting
{
    public abstract class AnnaUniv
    {
        public string GetSyllabusForFirstCseYearStudant()
        {
            return "Maths,physics,etc.,";
        }

        public abstract string FirstYearStudantList();
    }

    public class Clg1 : AnnaUniv
    {
        public override string FirstYearStudantList()
        {
            throw new NotImplementedException();
        }

    }


    public class GTCollection : ICollection<string>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(string item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(string item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
