using System;
using Common;
using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Core
{
    public class WorldObject
    {
        public WorldObject Owner { get; private set; }

        public Transform Transform { get; set; } = new Transform();

        public virtual void Awake()
        {
        }

        public static T Create<T>(WorldObject context, Vector3 position) where T : WorldObject
        {
            
            T obj = Activator.CreateInstance<T>();
            
            if (obj == null)
            {
                return null;
            }

            obj.Owner = context;
            obj.Transform.position = position;

            var owner = context;
            while (!(owner is World))
            {
                owner = owner.Owner;
            }
            var world = owner as World;
            world.Objects.Add(obj);
            obj.Awake();
            return obj;
        }

        public static WorldObject Create(Type type, WorldObject context, Vector3 position)
        {
            WorldObject obj = Activator.CreateInstance(type) as WorldObject;

            if (obj == null)
            {
                return null;
            }
            
            obj.Owner = context;
            obj.Transform.position = position;

            var owner = context;
            while (!(owner is World))
            {
                owner = owner.Owner;
            }
            var world = owner as World;
            world.Objects.Add(obj);
            obj.Awake();
            return obj;
        }

        public static WorldObject CreateByTypeName(string typeName, WorldObject context, Vector3 position)
        {
            var type = Type.GetType(typeName);
            Assert.Check<Exception>(type != null, "cannot find type " + typeName);
            WorldObject obj = Activator.CreateInstance(type) as WorldObject;
            
            if (obj == null)
            {
                return null;
            }

            obj.Owner = context;
            obj.Transform.position = position;

            var owner = context;
            while (!(owner is World))
            {
                owner = owner.Owner;
            }
            var world = owner as World;
            world.Objects.Add(obj);
            obj.Awake();
            return obj;
        }
        
    }
}
