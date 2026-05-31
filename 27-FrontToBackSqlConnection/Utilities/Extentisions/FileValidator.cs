using _27_FrontToBackSqlConnection.Utilities.Enums;

namespace _27_FrontToBackSqlConnection.Utilities.Extentisions
{
    public static class FileValidator
    {
        public static bool CheckFileType(this IFormFile file, string type)
        {
            if (file.ContentType.Contains(type))
            {
                return true;
            }
            return false;
        }

        public static bool CheckFileSize(this IFormFile file, FileSize fileSize, decimal size)
        {
            switch (fileSize)
            {
                case FileSize.KB:
                    return file.Length <= size * 1024;
                case FileSize.MB:
                    return file.Length <= size * 1024 * 1024;
                case FileSize.GB:
                    return file.Length <= size * 1024 * (1024 * 1024);
            }
            return false;
        }

        //public static Task<string> CreateFile(this IFormFile file, params string[] roots)
        //{ 

        //}
    }
}
