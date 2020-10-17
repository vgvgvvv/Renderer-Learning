using System;
using Common;
using AnotherBuildSystem.Project;

namespace GenerateInfo
{
    public class RuntimeModule : ModuleInfo
    {

        public RuntimeModule(Project rootProject, string name, string projectPath) : base(rootProject, name, projectPath)
        {
        }

        protected override void Init()
        {
            Log.Info("Generate Runtime Module~");
        }

    }
}
