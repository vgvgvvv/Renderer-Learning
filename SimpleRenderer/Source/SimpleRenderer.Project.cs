using System;
using Common;
using AnotherBuildSystem.Project;

namespace GenerateInfo
{
    public class SimpleRendererProject : ProjectTargetInfo
    {

        public SimpleRendererProject(Project rootProject, string name, string projectPath) : base(rootProject, name, projectPath)
        {
        }

        protected override void Init()
        {
            Log.Info("Generate SimpleRenderer Project");
        }
    }
}
