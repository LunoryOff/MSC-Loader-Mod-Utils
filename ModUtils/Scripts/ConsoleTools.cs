using System.Collections.Generic;
using System.Text;
using UnityEngine;
using MSCLoader;
using Object = UnityEngine.Object;
using System.Linq;

namespace ModUtils
{
    public static class ConsoleTools
    {
        public static void TestMessage() 
        {
            const string text = "This is a Test Message!";
            var rawMessage = new StringBuilder();

            for (var i = 0; i < 22; i++)
            {
                var color = ((Color)i).ToString();
                rawMessage.Append($"<color={color}>{text} <{color}></color>\n");
            }

            rawMessage.Append($"<b>{text}</b> <boldface>\n");
            rawMessage.Append($"<i>{text}</i> <italics>\n");

            for (var i = 1; i < 21; i++)
            {
                rawMessage.Append($"<size={i}>{text} size:{i}</size>\n");
            }

            ModConsole.Print(rawMessage.ToString());
        }

        public static void Log(string message, int size = 12, Color color = Color.silver, bool boldface = false, Object target = null)
        {
            string formattedMessage = boldface
                ? $"<b><size={GetMaxSize(size)}><color={color.ToString()}>{message}</color></size></b>"
                : $"<size={GetMaxSize(size)}><color={color.ToString()}>{message}</color></size>";

            ModConsole.Print(formattedMessage);
        }

        public static void LogSuccess(string prompt, Object target = null)
        {
            Log(prompt, 12, Color.lime, false, target);
        }

        public static void LogInfo(string prompt, Object target = null)
        {
            Log(prompt, 12, Color.orange, false, target);
        }

        public static void LogError(string prompt, Object target = null)
        {
            Log(prompt, 12, Color.red, true, target);
        }

        public static string PrintCollection<T>(IEnumerable<T> collection)
        {
            var text = string.Join(", ", collection.Select(item => item.ToString()).ToArray());
            return $"[{text}]";
        }

        private static int GetMaxSize(int size) => Mathf.Min(size, 20);
    }

    public enum Color
    {
        red,
        orange,
        yellow,
        lime,
        green,
        teal,
        cyan,
        aqua,
        lightblue,
        blue,
        darkblue,
        navy,
        purple,
        magenta,
        fuchsia,
        brown,
        maroon,
        olive,
        white,
        silver,
        grey,
        black
    }
}