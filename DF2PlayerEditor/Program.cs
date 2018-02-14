using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

using DF2PlayerEditor.Forms;

namespace DF2PlayerEditor
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    public static class Config
    {
        public static bool ProgramDebug;

        public static string ProgramName = "DF2 Player Editor";

        public static string ProgramVersion = Assembly.GetCallingAssembly().GetName().Version.Major + "." + Assembly.GetCallingAssembly().GetName().Version.Minor;

        public static string NoavHqUrl = "http://novahq.net/";
        public static string NoavHqUrlApp = NoavHqUrl + "?app=DF2PlayerEditor" + ProgramVersion;

        public static string FacebookUrl = "https://www.facebook.com/groups/df2reunion/";

        public static int PlayerStartOffset = 0xc;
        public static int PlayerNextOffset = 0x6e8;
        public static int PlayerNameMaxLength = 15;
        public static int PlayerMaxCount = 5;
        public static int PlayerMacroOffset = 0xe4; // from player name
        public static int PlayerMacroNextOffset = 0x28;
        public static int PlayerMacroMaxCount = 10;
        public static int PlayerMacroMaxLength = 39;

        public static string DefaultGamePath1 = @"C:\Program Files\NovaLogic\Delta Force 2\";
        public static string DefaultGamePath2 = @"C:\Program Files (x86)\NovaLogic\Delta Force 2\";
        public static string ConfigFile = "df2.cfg";
        public static string PlayerFile = "df2plyrs.sav";

        public static Dictionary<string, string> EmoteDict = new Dictionary<string, string>
        {
            {"btnA", "\x01"}, //Mag            => CTRL + A
            {"btnB", "\x02"}, //ArrowLeft      => CTRL + B 
            {"btnC", "\x03"}, //ArrowUp        => CTRL + C
            {"btnD", "\x04"}, //ArrowDown      => CTRL + D
            {"btnE", "\x05"}, //ArrowRight     => CTRL + E
            {"btnF", "\x06"}, //Happy          => CTRL + F
            {"btnG", "\x07"}, //Sad            => CTRL + G
            {"btnH", "\x08"}, //Castle/Invalid => CTRL + H
            {"btnI", "\x09"}, //Angry          => CTRL + I
            {"btnJ", "\x0A"}, //Shocked        => CTRL + J
            {"btnK", "\x0B"}, //Neutral        => CTRL + K
            {"btnL", "\x0C"}, //Wink           => CTRL + L
            {"btnM", "\x0D"}, //Castle/Invalid => CTRl + M
            {"btnN", "\x0E"}, //Crying         => CTRL + N
            {"btnO", "\x0F"}, //Cool           => CTRL + O
            {"btnP", "\x10"}, //Evil           => CTRL + P
            {"btnQ", "\x11"}, //Phone          => CTRL + Q
            {"btnR", "\x12"}, //Heart          => CTRL + R
            {"btnS", "\x13"}, //HeartBroken    => CTRL + S 
            {"btnT", "\x14"}, //Reserved (r)   => CTRL + T
            {"btnU", "\x15"}, //Check          => CTRL + U
            {"btnV", "\x16"}, //Bomb           => CTRL + V
            {"btnW", "\x17"}, //Flag           => CTRL + W
            {"btnX", "\x18"}, //Warning        => CTRL + X
            {"btnY", "\x19"}, //Music          => CTRL + Y
            {"btnZ", "\x1A"}, //Knife          => CTRL + Z
            {"btnAA", "\x1B"}, //+3             => CTRL + [
            {"btnAB", "\x1D"}, //Boobs          => CTRL + ]
            {"btnAC", "\x1C"}, //Butt          => CTRL + \
            {"btnAD", "\x1E"}, //Scope          => CTRL + Shift + ^
            {"btnAE", "\x1F"}, //DickButt      => CTRL + Shift + _
        };

    }

}