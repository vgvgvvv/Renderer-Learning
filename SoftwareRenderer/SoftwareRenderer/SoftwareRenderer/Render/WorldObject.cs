using System;
using System.Collections.Generic;
using System.Text;
using MathLib;
using SoftwareRenderer.Core;

namespace SoftwareRenderer.Render
{
    public class WorldObject
    {
        public Transform Transform { get; set; }

        public static T Create<T>(Vector3 position) where T : WorldObject
        {
            var obj = Activator.CreateInstance<T>();
            Application.GetInstance().world.Objects.Add(obj);
            obj.Transform.position = position;
            return obj;
        }
        
    }
}
