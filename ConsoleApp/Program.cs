﻿using ConsoleApp.Logger;

namespace ConsoleApp

{
    public class Program
    {
        public static void Main()
        {
            ILogger[] loggers = new ILogger[]
            {
                new ConsoleLogger(),
                new FileLogger("log.txt"),
                new SocketLogger(host:"google.com",port:80)
            };

            using (ILogger logger = new CommonLogger(loggers))
            {
                logger.Log("Example message 1 ...");
                logger.Log("Example message 2 ...");
                logger.Log("Example message 3 ...", "value 1", "value 2", "value 3");
            }
        }
    }
  
}