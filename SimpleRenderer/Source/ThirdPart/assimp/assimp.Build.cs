using System;
using Common;
using AnotherBuildSystem.Project;

namespace GenerateInfo
{
    public class AssimpModule : ModuleInfo
    {

        public AssimpModule(Project rootProject, string name, string projectPath) : base(rootProject, name, projectPath)
        {
        }

        protected override void Init()
        {
            Log.Info("Generate Assimp Module~");
        }

    }
}
