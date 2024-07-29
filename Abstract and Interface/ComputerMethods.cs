using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface Computer
    {
        void Run();
        void Stop();
    }
    public interface Portable
    {
        void Carry();
    }
    public interface DVDRom
    {
        void Insert();
    }
    public abstract class Basecomputer:Computer
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Laptop: Basecomputer,Portable,DVDRom
    {
        public void Carry()
        { 
            throw new NotImplementedException(); 
        }
        public void Insert()
        { 
            throw new NotImplementedException(); 
        }
    }
    public class Desktop : Basecomputer,DVDRom
    {
          
        public void Insert()
        {
            throw new NotImplementedException(); 
        }
    }


        
    
}
