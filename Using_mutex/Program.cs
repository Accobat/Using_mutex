using System;
using System.Threading;
namespace Using_mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex oneMutex = null;
            const String MutexName = "RUNMEONLYONCE";
            try
            {
                oneMutex = Mutex.OpenExisting(MutexName);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                oneMutex = new Mutex(true, MutexName);

            }
    
       
                    oneMutex.Close();
                    return;
      
            
            Console.WriteLine("Our Application");
            Console.Read();
}
    }
}
    

