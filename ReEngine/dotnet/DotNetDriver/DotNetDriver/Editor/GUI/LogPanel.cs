
using System.Collections.Generic;
using Common;
using MathLib;
using TestOpenGLd;
using TestOpenGLd.ImGui;

namespace DotNetDriver.Editor
{
    internal enum LogLevel
    {
        Info,
        Debug,
        Warn,
        Error
    }

    internal struct LogInfo
    {
        public static Color InfoColor = Color.gray;
        public static Color DebugColor = Color.white;
        public static Color WarnColor = Color.yellow;
        public static Color ErrorColor = Color.red;

        public LogLevel logLevel;
        public string message;

    }

    public class LogPanel : IEditorPanel
    {
        public bool IsShow { get; set; } = true;
        public string Title => "Log";

        private readonly List<LogInfo> logInfos = new List<LogInfo>();

        public void OnInit()
        {
            Log.AppendLogger(new DynamicLogger(info =>
            {
                logInfos.Add(new LogInfo(){logLevel = LogLevel.Info, message = info});
            }, info =>
            {
                logInfos.Add(new LogInfo() { logLevel = LogLevel.Debug, message = info });
            }, info =>
            {
                logInfos.Add(new LogInfo() { logLevel = LogLevel.Warn, message = info });
            }, info =>
            {
                logInfos.Add(new LogInfo() { logLevel = LogLevel.Error, message = info });
            }, exception =>
            {
                logInfos.Add(new LogInfo() { logLevel = LogLevel.Error, message = exception.ToString() });
            }));
        }

        public void OnGUI()
        {
            if (imgui.Button("Clear", new ImVec2(50, 20)))
            {
                Clear();
            }
            foreach (var logInfo in logInfos)
            {
                switch (logInfo.logLevel)
                {
                    case LogLevel.Info:
                        {
                            var infoColor = LogInfo.InfoColor;
                            imgui.TextColored(
                                new ImVec4(infoColor.r, infoColor.g, infoColor.b, 1),
                                logInfo.message);
                        }
                    break;
                    case LogLevel.Debug:
                        {
                            var infoColor = LogInfo.DebugColor;
                            imgui.TextColored(
                                new ImVec4(infoColor.r, infoColor.g, infoColor.b, 1),
                                logInfo.message);
                        }
                        break;
                    case LogLevel.Warn:
                        {
                            var infoColor = LogInfo.WarnColor;
                            imgui.TextColored(
                                new ImVec4(infoColor.r, infoColor.g, infoColor.b, 1),
                                logInfo.message);
                        }
                        break;
                    case LogLevel.Error:
                        {
                            var infoColor = LogInfo.ErrorColor;
                            imgui.TextColored(
                                new ImVec4(infoColor.r, infoColor.g, infoColor.b, 1),
                                logInfo.message);
                        }
                        break;
                }
            }
        }

        private void Clear()
        {
            logInfos.Clear();
        }
    }
}