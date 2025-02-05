using System;
using System.Reflection;
using System.Windows.Forms;

namespace MDIPaint
{
    public static class CursorLoad
    {
        public static Cursor LoadCursorFromResource(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Загружаем поток ресурса
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new ArgumentException("Resource not found: " + resourceName);
                }

                // Создаем курсор из потока
                return new Cursor(stream);
            }
        }
    }
}
