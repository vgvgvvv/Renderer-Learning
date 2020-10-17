using System;
using Common;
using AnotherBuildSystem.Project;

namespace GenerateInfo
{
    public class GLMModule : ModuleInfo
    {

        public GLMModule(Project rootProject, string name, string projectPath) : base(rootProject, name, projectPath)
        {
        }

        protected override void Init()
        {
            Log.Info("Generate GLM Module~");
        }

    }
}
