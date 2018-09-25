using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using NLog.Common;
using System.Data.SqlClient;

namespace Shahmat.Common
{
    public static class Logger
    {
        #region Fields and Properties
        private static string m_DatabaseAddress = string.Empty;
        private static string m_DatabaseName = string.Empty;
        private static string m_DatabaseUserName = string.Empty;
        private static string m_DatabasePassword = string.Empty;
        private static string m_DatabaseCommand = "insert into Log.TblLogs(MessageCode, ApplicationId, SubSystemId, MessageTypeId, TroubleshootingCode, TimeStamp, LoggerName, LogTopicId, LogLevel, LogMessage) values(@MessageCode, @ApplicationId, @SubSystemId, @MessageTypeId, @TroubleshootingCode, @TimeStamp, @LoggerName, @LogTopicId, @LogLevel, @LogMessage);";
        private static string m_LogFilePath = string.Empty;
        private static string m_LogLayout = string.Empty;

        private static NLog.Targets.DatabaseTarget m_TargetDB;
        private static NLog.Targets.FileTarget m_TargetGenFile;
        private static NLog.Targets.DatabaseParameterInfo m_ParamDB;
        private static NLog.Config.LoggingConfiguration m_Config;
        private static NLog.Logger m_Logger;
        private static bool m_HasBeenInit = false;

        private static bool m_InternalLogging = false;
        public static bool InternalLogging
        {
            get
            {
                return m_InternalLogging;
            }
            set
            {
                if (value != m_InternalLogging)
                {
                    m_InternalLogging = value;
                    ReConfig(value);
                }
            }
        }

        private static byte m_LoggingActiveLevel = 6;
        public static byte LoggingActiveLevel
        {
            get
            {
                return m_LoggingActiveLevel;
            }
            set
            {
                if (value != m_LoggingActiveLevel) m_LoggingActiveLevel = value;
            }
        }

        public static bool IsInitilized
        {
            get
            {
                return m_HasBeenInit;
            }
        }
        #endregion //End Fields and Properties

        #region Methods

        #region Private
        private static void TryAutoConfig()
        {
            //TODO: the logging properties should get from config file or policy manager
            //TODO: result should update the m_HasBeenInit too    
            SqlConnectionStringBuilder decoder = new SqlConnectionStringBuilder();// ITS.Policy.PolicyReader.GetStringPropertyValue("ApplicationConnectionString"));
            string UserID = decoder.UserID;
            string Password = decoder.Password;
            string LogDbAddress = decoder.DataSource;// System.Configuration.ConfigurationSettings.AppSettings["LogDbAddress"].ToString();
            string LogDbName = decoder.InitialCatalog;//System.Configuration.ConfigurationSettings.AppSettings["LogDbName"].ToString();
            string LogDbUserName = decoder.UserID;//System.Configuration.ConfigurationSettings.AppSettings["LogDbUserName"].ToString();
            string LogDbPassword = decoder.Password;//System.Configuration.ConfigurationSettings.AppSettings["LogDbPassword"].ToString();
            LogLevel logLevel = LogLevel.Error;
            if (!m_HasBeenInit)
                Initialize(@"${basedir}/Logs/Log${date:format=yyyy\-MM\-dd}.txt", @"${date:format=yyyy\-MM\-dd HH\:mm\:ss.FFF} | ${logger} | ${event-context:item=LogLevel} | ${message}", LogDbAddress, LogDbName, LogDbUserName, LogDbPassword, logLevel);
        }

        private static void ReConfig(bool InternalLogging)
        {
            if (m_HasBeenInit)
            {
                if (InternalLogging)
                {
                    InternalLogger.LogToConsole = true;
                    InternalLogger.LogFile = "c:\\NLog.log";
                    InternalLogger.LogLevel = NLog.LogLevel.Trace;
                }
                else
                {
                    InternalLogger.LogToConsole = false;
                    InternalLogger.LogFile = string.Empty;
                    InternalLogger.LogLevel = NLog.LogLevel.Off;
                }
                NLog.LogManager.ReconfigExistingLoggers();
            }
        }

        private static bool CheckDatabaseParameters()
        {
            if (!string.IsNullOrWhiteSpace(m_DatabaseAddress) & !string.IsNullOrWhiteSpace(m_DatabaseName) &
                !string.IsNullOrWhiteSpace(m_DatabaseUserName) /*& !string.IsNullOrWhiteSpace(m_DatabasePassword) */& !string.IsNullOrWhiteSpace(m_DatabaseCommand))
                return true;
            else
                return false;
        }

        private static bool CheckFileParameters()
        {
            if (!string.IsNullOrWhiteSpace(m_LogFilePath) & !string.IsNullOrWhiteSpace(m_LogLayout))
                return true;
            else
                return false;
        }

        private static NLog.LogEventInfo PrepareLogInfo(string messageCode, long applicationId, long subSystemId, long messageTypeId, long troubleshootingCode, string loggerName, long logTopicId, LogLevel logLevel, string logMessage)
        {
            NLog.LogEventInfo theEvent = new NLog.LogEventInfo(logLevel, loggerName, logMessage);

            theEvent.Properties["MessageCode"] = messageCode;
            theEvent.Properties["ApplicationId"] = applicationId;
            theEvent.Properties["SubSystemId"] = subSystemId;
            theEvent.Properties["MessageTypeId"] = messageTypeId;
            theEvent.Properties["TroubleshootingCode"] = troubleshootingCode;
            theEvent.Properties["LogTopicId"] = logTopicId;
            theEvent.Properties["LogLevel"] = logLevel;
            theEvent.Properties["LogMessage"] = logMessage;
            theEvent.Properties["LoggerName"] = loggerName;
            return theEvent;
        }

        #endregion //End Private

        #region Public
        //public static void Initialize()
        //{
        //    if (!m_HasBeenInit)
        //    {
        //        Initialize("databaseAddress", "databaseName", "databaseUserName", "databasePassword", LogLevel.Trace);
        //    }
        //}

        public static void Initialize(string logFilePath, string logLayout, LogLevel logLevel)
        {
            Initialize(logFilePath, logLayout, string.Empty, string.Empty, string.Empty, string.Empty, logLevel);
        }

        public static void Initialize(string databaseAddress, string databaseName, string databaseUserName, string databasePassword, LogLevel logLevel)
        {
            Initialize(string.Empty, string.Empty, databaseAddress, databaseName, databaseUserName, databasePassword, logLevel);
        }

        public static void Initialize(string logFilePath, string logLayout, string databaseAddress, string databaseName, string databaseUserName, string databasePassword, LogLevel logLevel)
        {
            if (!m_HasBeenInit)
            {
                if (InternalLogging)
                {
                    InternalLogger.LogToConsole = true;
                    InternalLogger.LogFile = "c:\\NLog.log";
                    InternalLogger.LogLevel = NLog.LogLevel.Error;
                }

                m_DatabaseAddress = databaseAddress;
                m_DatabaseName = databaseName;
                m_DatabaseUserName = databaseUserName;
                m_DatabasePassword = databasePassword;
                m_LogFilePath = logFilePath;
                m_LogLayout = logLayout;
                if (m_Config == null)
                {
                    m_Config = new NLog.Config.LoggingConfiguration();
                }

                if (CheckDatabaseParameters())
                {
                    m_TargetDB = new NLog.Targets.DatabaseTarget();
                    m_TargetDB.DBProvider = "mssql";
                    m_TargetDB.Name = m_DatabaseName;
                    m_TargetDB.DBHost = m_DatabaseAddress;
                    m_TargetDB.DBDatabase = m_DatabaseName;
                    m_TargetDB.DBUserName = m_DatabaseUserName;
                    m_TargetDB.DBPassword = m_DatabasePassword;
                    m_TargetDB.CommandText = m_DatabaseCommand;

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@TimeStamp";
                    m_ParamDB.Layout = @"${date:format=yyyy\-MM\-dd HH\:mm\:ss}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@LogMessage";
                    m_ParamDB.Layout = "${message}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@MessageCode";
                    m_ParamDB.Layout = "${event-context:item=MessageCode}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@ApplicationId";
                    m_ParamDB.Layout = "${event-context:item=ApplicationId}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@SubSystemId";
                    m_ParamDB.Layout = "${event-context:item=SubSystemId}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@MessageTypeId";
                    m_ParamDB.Layout = "${event-context:item=MessageTypeId}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@TroubleshootingCode";
                    m_ParamDB.Layout = "${event-context:item=TroubleshootingCode}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@LogLevel";
                    m_ParamDB.Layout = "${event-context:item=LogLevel}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@LogTopicId";
                    m_ParamDB.Layout = "${event-context:item=LogTopicId}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_ParamDB = new NLog.Targets.DatabaseParameterInfo();
                    m_ParamDB.Name = "@LoggerName";
                    m_ParamDB.Layout = "${event-context:item=LoggerName}";
                    m_TargetDB.Parameters.Add(m_ParamDB);

                    m_Config.AddTarget(m_TargetDB.Name, m_TargetDB);
                    m_Config.LoggingRules.Add(new NLog.Config.LoggingRule("*", NLog.LogLevel.Trace, m_TargetDB));
                }
                if (CheckFileParameters())
                {
                    m_TargetGenFile = new NLog.Targets.FileTarget();
                    m_TargetGenFile.Name = "LogFile";
                    m_TargetGenFile.FileName = m_LogFilePath;
                    m_TargetGenFile.Layout = m_LogLayout;
                    m_Config.AddTarget(m_TargetGenFile.Name, m_TargetGenFile);
                    m_Config.LoggingRules.Add(new NLog.Config.LoggingRule("*", NLog.LogLevel.Trace, m_TargetGenFile));
                }

                NLog.LogManager.Configuration = m_Config;
                m_Logger = NLog.LogManager.GetCurrentClassLogger();
                m_HasBeenInit = true;
            }
        }

        public static void Log(LogLevel level, string logMessage)
        {
            try
            {
                Log(level, string.Empty, string.Empty, 0, 0, 0, 0, 0, logMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void Log(LogLevel level, string loggerName, string logMessage)
        {
            try
            {
                Log(level, string.Empty, loggerName, 0, 0, 0, 0, 0, logMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Log(LogLevel level, string loggerName, string messageCode, string logMessage)
        {
            try
            {
                Log(level, loggerName, messageCode, 0, 0, 0, 0, 0, logMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Log(LogLevel level, string loggerName, string messageCode, long applicationId, long subSystemId, long messageTypeId, long troubleshootingCode, long logTopicId, string logMessage)
        {
            try
            {
                TryAutoConfig();
                //if (LoggingActiveLevel >= (byte)level)
                m_Logger.Log(PrepareLogInfo(messageCode, applicationId, subSystemId, messageTypeId, troubleshootingCode, loggerName, logTopicId, level, logMessage));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static LogLevel ToLogLevel(string level)
        {
            if (LogLevel.Off.ToString().ToLower() == "Off".ToLower())
                return LogLevel.Off;
            else
                if (LogLevel.Trace.ToString().ToLower() == "Trace".ToLower())
                    return LogLevel.Trace;
                else
                    if (LogLevel.Debug.ToString().ToLower() == "Debug".ToLower())
                        return LogLevel.Debug;
                    else
                        if (LogLevel.Info.ToString().ToLower() == "Info".ToLower())
                            return LogLevel.Info;
                        else
                            if (LogLevel.Warn.ToString().ToLower() == "Warn".ToLower())
                                return LogLevel.Warn;
                            else
                                if (LogLevel.Error.ToString().ToLower() == "Error".ToLower())
                                    return LogLevel.Error;
                                else
                                    if (LogLevel.Fatal.ToString().ToLower() == "Fatal".ToLower())
                                        return LogLevel.Fatal;
            return LogLevel.Info;
        }
        #endregion //End Public

        #endregion //End Methods
    }
}


