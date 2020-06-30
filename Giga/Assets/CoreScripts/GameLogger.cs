using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoreScripts
{
	public static class GameLogger
	{
        private static bool _debugEnabled = true;
        private static bool _warnEnabled = true;
        private static bool _errorEnabled = true;

        #region Debug
        public static void debug(string message)
        {
            if (!_debugEnabled) { return; }
            Debug.Log(message);
        }

        public static void debug(string message, Object context)
        {
            if (!_debugEnabled) { return; }
            Debug.Log(message, context);
        }

        public static void setDebugEnabled(bool param)
        {
            _debugEnabled = param;
        }

        public static bool getDebugEnabled()
        {
            return _debugEnabled;
        }
        #endregion

        #region Warn
        public static void warn(string message)
        {
            if (!_warnEnabled) { return; }
            Debug.LogWarning(message);
        }

        public static void warn(string message, Object context)
        {
            if (!_warnEnabled) { return; }
            Debug.LogWarning(message, context);
        }

        public static void setWarnEnabled(bool param)
        {
            _warnEnabled = param;
        }

        public static bool getWarnEnabled()
        {
            return _warnEnabled;
        }
        #endregion

        #region Error
        public static void error(string message)
        {
            if (!_errorEnabled) { return; }
            Debug.LogError(message);
        }

        public static void error(string message, Object context)
        {
            if (!_errorEnabled) { return; }
            Debug.LogError(message, context);
        }
        
        public static void setErrorEnabled(bool param)
        {
            _errorEnabled = param;
        }

        public static bool getErrorEnabled()
        {
            return _errorEnabled;
        }
        #endregion
    }
}

