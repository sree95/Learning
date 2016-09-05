using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StandardCatalog : ISavable, IPersistable
    {

        public void Load()
        {
            throw new NotImplementedException();
        }


        public string Save() => "Catalog Save";
        
    }

    public class ExplicitCatelog : ISavable,IPersistable
    {
        //public string Save() => "Catalog Save";

        string ISavable.Save() => "ISavable save";

        string IPersistable.Save() => "IPersistable save method";
        
    }


    public class Catalog : ISavable, IVoidSavable
    {        
        public string Save()
        {
            throw new NotImplementedException();
        }

        void IVoidSavable.Save()
        {
            throw new NotImplementedException();
        }
    }


    public class EnumerableCatalog : IEnumerable<string>
    {


        public void MyMethod()
        {
            Console.WriteLine("EnumerableCatalog MyMethod");
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class AbsClass
    {
        public abstract void MyMethod();        
    }
}
