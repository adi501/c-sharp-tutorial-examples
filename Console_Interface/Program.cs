using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Interface
{
    interface IStore
    {
       void Read();
        void Write();
        //public void Name(); //error
         void Name();
    }

    interface ICompress
    {
        void Compress();
        void Decompress();
        void Name();
    }
    public class Document : IStore, ICompress
    {
        #region IStore

        //Implicit Implementation
        public void Read()
        {
            Console.WriteLine("Executing Document's Read Method for IStore");
        }

        public void Write()
        {
            Console.WriteLine("Executing Document's Write Method for IStore");
        }

        //error
        //public void IStore.Name()
        //{
        //    Console.WriteLine("Store Name");
        //}
        //Explicit Implementation
        void IStore.Name()
        {
            Console.WriteLine("Store Name");
        }


        #endregion // IStore

        #region ICompress

        //Implicit Implementation
        public void Compress()
        {
            Console.WriteLine("Executing Document's Compress Method for ICompress");
        }
        public void Decompress()
        {
            Console.WriteLine("Executing Document's Decompress Method for ICompress");
        }

        //Explicit Implementation
         void ICompress.Name()
        {
            Console.WriteLine("Compress Name");
        }
        #endregion // ICompress
    }






    class Program
    {
        static void Main(string[] args)
        {
            Document obj = new Document();
            obj.Read();
            obj.Write();
            obj.Compress();
            obj.Decompress();
           // obj.Name(); //error

            IStore obj1 = new Document();
            obj1.Name();
            ICompress obj2 = new Document();
            obj2.Name();
            Console.ReadLine();
        }
    }
}
