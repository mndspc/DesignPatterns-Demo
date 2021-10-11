using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns
{
   public class ExceptionHandler
    {
        private static ExceptionHandler _instance = null;

        private static StreamWriter _streamWriter;

        private static object _lock = new object();
        private ExceptionHandler()
        {
            _streamWriter = new StreamWriter("Error.txt");
        }

        public static ExceptionHandler Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ExceptionHandler();
                    }
                    return _instance;
                }
                
            }
            
        }

        public void WriteLog(string message)
        {
            _streamWriter.WriteLine(message);
            _streamWriter.Flush();
        }

    }
}
