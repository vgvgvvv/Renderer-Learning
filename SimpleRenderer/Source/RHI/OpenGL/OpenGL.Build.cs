using System;
using Common;
using AnotherBuildSystem.Project;

namespace GenerateInfo
{
    public class OpenGLModule : ModuleInfo
    {

        public OpenGLModule(Project rootProject, string name, string projectPath) : base(rootProject, name, projectPath)
        {
        }

        protected override void Init()
        {
            Log.Info("Generate Runtime Module~");
        }

    }
}
