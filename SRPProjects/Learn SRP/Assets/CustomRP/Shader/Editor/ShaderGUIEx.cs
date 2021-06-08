using System;
using UnityEditor;
using UnityEngine;

namespace CustomRP.Shader.Editor
{
    public class ShaderGUIEx : ShaderGUI
    {
        protected MaterialEditor editor;
        protected object[] materials;
        protected MaterialProperty[] properties;

        public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
        {
            base.OnGUI(materialEditor, properties);
            editor = materialEditor;
            materials = materialEditor.targets;
            this.properties = properties;
        }
        
        public bool HasProperty (string name) =>
            FindProperty(name, properties, false) != null;

        public void SetProperty (string name, string keyword, bool value) {
            if (SetProperty(name, value ? 1f : 0f)) {
                SetKeyword(keyword, value);
            }
        }

        public bool SetProperty (string name, float value) {
            MaterialProperty property = FindProperty(name, properties, false);
            if (property != null) {
                property.floatValue = value;
                return true;
            }
            return false;
        }
        
        public void SetKeyword (string keyword, bool enabled) {
            if (enabled) {
                foreach (Material m in materials) {
                    m.EnableKeyword(keyword);
                }
            }
            else {
                foreach (Material m in materials) {
                    m.DisableKeyword(keyword);
                }
            }
        }
    }
}