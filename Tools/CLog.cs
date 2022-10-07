using System;
using System.IO;

namespace Tools
{
    public sealed class CLog
    {
        private static CLog _instance = null;

        private string _path;

        private static object _protect = new object();

        public static CLog GetInstance(string path)
        {
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new CLog(path);
                }
            }

            return _instance;
        }

        private CLog(string path)
        {
            this._path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
