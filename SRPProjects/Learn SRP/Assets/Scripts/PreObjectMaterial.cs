using System;
using UnityEngine;

namespace CustomRP.Test
{
    [DisallowMultipleComponent]
    public class PreObjectMaterial : MonoBehaviour
    {
        private static int baseColorId = Shader.PropertyToID("_BaseColor");

        private static MaterialPropertyBlock block;
        
        [SerializeField]
        private Color baseColor = Color.white;

        private void Awake()
        {
            OnValidate();
        }

        private void OnValidate()
        {
            if (block == null)
            {
                block = new MaterialPropertyBlock();
            }
            block.SetColor(baseColorId, baseColor);
            GetComponent<Renderer>().SetPropertyBlock(block);
        }
    }
}