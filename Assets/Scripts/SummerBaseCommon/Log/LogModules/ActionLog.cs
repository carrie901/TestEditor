﻿
namespace Summer
{
    public class ActionLog
    {
        [System.Diagnostics.Conditional("LOG")]
        public static void Log(string message)
        {
            if (!LogManager._opneEntityAction) return;
            LogManager.Log(message);
        }
        [System.Diagnostics.Conditional("LOG")]
        public static void Log(string message, params object[] args)
        {
            if (!LogManager._opneEntityAction) return;
            LogManager.Log(message, args);
        }
        [System.Diagnostics.Conditional("LOG")]
        public static void Assert(bool condition, string message)
        {
            if (!LogManager._opneEntityAction) return;
            LogManager.Assert(condition, message);
        }
        [System.Diagnostics.Conditional("LOG")]
        public static void Assert(bool condition, string message, params object[] args)
        {
            if (!LogManager._opneEntityAction) return;
            LogManager.Assert(condition, message, args);
        }
        [System.Diagnostics.Conditional("LOG")]
        public static void Error(string message)
        {
            if (!LogManager._opneEntityAction) return;
            LogManager.Error(message);
        }
        [System.Diagnostics.Conditional("LOG")]
        public static void Error(string message, params object[] args)
        {
            if (!LogManager._opneEntityAction) return;
            LogManager.Error(message, args);
        }
    }
}
