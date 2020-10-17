using System;
using Common;
using AnotherBuildSystem.Project;

namespace GenerateInfo
{
    public class GLEWModule : ModuleInfo
    {

        public GLEWModule(Project rootProject, string name, string projectPath) : base(rootProject, name, projectPath)
        {
        }

        protected override void Init()
        {
            Log.Info("Generate glew Module~");
        }

    }
}
