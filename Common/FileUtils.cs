using System;
using System.IO;
using System.Runtime.InteropServices;

namespace MSCD.Common
{
    public class FileUtils
    {
        private const int OfReadwrite = 2;
        private const int OfShareDenyNone = 0X40;
        private static readonly IntPtr HfileError = new IntPtr(-1);

        [DllImport("kernel32.dll")]
        private static extern IntPtr _lopen(string lpPathName, int iReadWrite);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr handle);

        /// <summary>
        /// 判断文件是否被占用
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsOccupy(string fileName)
        {
            if (!File.Exists(fileName)) return false;
            var handle = _lopen(fileName, OfReadwrite | OfShareDenyNone);
            if (handle == HfileError) return true;
            CloseHandle(handle);
            return false;
        }

        public static void ClearDirectory(string dir)
        {
            foreach (var d in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    var fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    {
                        fi.Attributes = FileAttributes.Normal;
                    }
                    File.Delete(d);
                }
            }
        }
    }
}
