using System;
using Interfaces;

namespace oop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface
            
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();


            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}