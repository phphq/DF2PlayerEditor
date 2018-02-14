using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace DF2PlayerEditor.Classes
{
    internal static class FileFunctions
    {
        public static bool TestPath(string path)
        {
            return File.Exists(Path.Combine(path, Config.ConfigFile)) && File.Exists(Path.Combine(path, Config.PlayerFile));
        }

        public static Dictionary<string, string> LoadConfigData(string path)
        {
            var config = new Dictionary<string, string>
            {
                {"game_res",  GetValueOfKey(Path.Combine(path, Config.ConfigFile), "game_res") },
                {"gamma",  GetValueOfKey(Path.Combine(path, Config.ConfigFile), "gamma") }
            };

            return config;
        }

        public static Dictionary<int, Player> LoadPlayerData(string path)
        {
            var playerList = new Dictionary<int, Player>();
    
            var fileBytes = File.ReadAllBytes(Path.Combine(path, Config.PlayerFile));

            for (var i = 0; i < Config.PlayerMaxCount; i++)
            {
                var playerOffset = Config.PlayerStartOffset + (Config.PlayerNextOffset * i);

                var playerName = Encoding.GetEncoding(1252).GetString(fileBytes, playerOffset, Config.PlayerNameMaxLength);

                if (playerName.IndexOf('\0') == 0)
                    playerName = "*New Operative";

                var playerMacros = new List<string>();

                for (var j = 0; j < Config.PlayerMacroMaxCount; j++)
                {

                    var macroOffset = playerOffset + Config.PlayerMacroOffset + (Config.PlayerMacroNextOffset * j);
                    var macro = Encoding.GetEncoding(1252).GetString(fileBytes, macroOffset, Config.PlayerMacroMaxLength);

                    playerMacros.Add(macro);
                }

                playerList.Add(i, new Player
                {
                    Index = i,
                    Name = playerName,
                    Macros = playerMacros,
                });

            }

            return playerList;
        }

        public static Result WriteConfigLine(string file, string key, string value)
        {
            var result = new Result();

            if (!File.Exists(file))
            {
                result.ErrorMsg = file + " not found";
                return result;
            }

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value))
            {
                result.ErrorMsg = "Key or value to write is empty.";
                return result;
            }

            var lineNo = GetLineNo(file, key);

            if (lineNo == 0)
            {
                result.ErrorMsg = "Could not find line in config file for " + key;
                return result;
            }

            try
            {
                var lines = File.ReadAllLines(file);
                lines[lineNo - 1] = key.PadRight(16) + " = " + value;
                File.WriteAllLines(file, lines);

            }
            catch (Exception ex)
            {
                result.ErrorMsg = "Error reading/writing " + file + ":" + Environment.NewLine + ex.Message;
                return result;
            }

            result.Success = true;
            return result;

        }

        public static Result WriteToSaveFile(string file, List<PlayerSaveFile> writeData)
        {

            var result = new Result();

            if (!File.Exists(file))
            {
                result.ErrorMsg = file + " not found";
                return result;
            }

            try
            {
                using (var bw = new BinaryWriter(File.Open(file, FileMode.Open, FileAccess.ReadWrite)))
                {
                    foreach(var data in writeData)
                    {
                        var writeString = StringToByte(data.String.PadRight(data.Length, '\0'), data.Length);
                        bw.BaseStream.Seek(data.Offset, SeekOrigin.Begin);
                        bw.Write(writeString);
                        
                    }
                    bw.Close();
                }
  
            } catch(Exception ex)
            {
                result.ErrorMsg = "Error reading/writing "+ file + ":" + Environment.NewLine + ex.Message;
                return result;
            }

            result.Success = true;
            return result;
        }

        private static byte[] StringToByte(string str, int length)
        {
            return Encoding.GetEncoding(1252).GetBytes(str.PadRight(length, '\0'));
        }

        private static string GetValueOfKey(string file, string key)
        {
            if (!File.Exists(file) || string.IsNullOrEmpty(key))
                return "";

            foreach (var lineData in File.ReadAllLines(file))
            {
                if (!lineData.Contains(key) || !lineData.Contains("="))
                    continue;

                var keyValue = lineData.Split(new[] { "=" }, StringSplitOptions.None);

                return keyValue[1].Trim();
            }

            return "";
        }

        private static int GetLineNo(string file, string key)
        {
            var lineNo = 1;
            foreach (var lineData in File.ReadAllLines(file))
            {
                if (lineData.Contains(key))
                    return lineNo;

                lineNo++;
            }

            return 0;
        }

    }

}