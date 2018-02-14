using System.Diagnostics;

namespace DF2PlayerEditor.Classes
{
    public static class Common
    {
        public static void GoToNovaHq()
        {
            Process.Start(Config.NoavHqUrlApp);
        }

    }

}