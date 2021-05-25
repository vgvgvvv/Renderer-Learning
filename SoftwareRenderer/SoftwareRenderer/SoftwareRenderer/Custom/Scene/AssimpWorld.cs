using System;
using System.IO;
using Common;
using Common.ConsoleApp;
using Common.Persistence;
using MathLib;
using SoftwareRenderer.Component;
using SoftwareRenderer.Core;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Scene
{
    public class AssimpWorld : World
    {
        public override void Awake()
        {
            base.Awake();
            var dataFileManager = DataFileManager.FindConfig(Flag.GetFlag("config").GetValue<string>());
            Assert.Check<Exception>(dataFileManager != null, "cannot find config " + Flag.GetFlag("config").GetValue<string>());
            var resourceDirName = dataFileManager.LoadData<string>("ResourcesDir", "Resourecs");
            var resourcesDir = Path.Combine(dataFileManager.FileDirectory, resourceDirName);
            
            var camera = WorldObject.Create<Camera>(this, new Vector3(0, 0, -10));

            var objmesh = Create<ObjMeshRenderer>(this, new Vector3(0, 0, 1));
            objmesh.LoadMesh(Path.Combine(resourcesDir, "duck.dae"));
        }
    }
}