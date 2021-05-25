using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Assimp;
using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Component
{
    public class ObjMeshRenderer : Renderer
    {

        public Assimp.Scene Model { get; private set; }

        private Render.Mesh Mesh;

        public ObjMeshRenderer()
        {
            Mesh = new Render.Mesh();
        }
        
         public ObjMeshRenderer(string fileName, PostProcessSteps? presets = null) : this()
         {
             LoadMesh(fileName, presets);
         }

         public void LoadMesh(string fileName, PostProcessSteps? presets = null)
         { 
             presets ??= PostProcessPreset.TargetRealTimeMaximumQuality;
             Model = AssimpLib.Instance.AssimpContext.ImportFile(fileName, presets.Value);

             if (Model.HasMeshes)
             {
                 var RawMesh = Model.Meshes[0];
             }
             
         }

         private void RecursiveRender(Assimp.Scene scene, Node node, ref List<Vertex> result)
         {
             if (node.HasMeshes)
             {
                 foreach (int index in node.MeshIndices)
                 {
                     var mesh = scene.Meshes[index];

                     List<Vertex> vertices = new List<Vertex>();
                     foreach (var meshFace in mesh.Faces)
                     {
                         foreach (var face in mesh.Faces)
                         {
                             
                         }
                     }
                 }
             }
             
             foreach (var nodeChild in node.Children)
             {
                 RecursiveRender(scene, nodeChild, ref result);
             }
         }

         public override List<DrawCommand> GatherCommand()
         {
             return new List<DrawCommand>(){};
         }
    }
}