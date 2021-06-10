using System;
using UnityEngine;

namespace CustomRP.Test
{
    [DisallowMultipleComponent]
    public class PreObjectMaterial : MonoBehaviour
    {
        private static int baseColorId = Shader.PropertyToID("_BaseColor");
        private static int emissionColorId = Shader.PropertyToID("_EmissionColor");
        private static int cutoffId = Shader.PropertyToID("_Cutoff");
        private static int metallicId = Shader.PropertyToID("_Metallic");
        private static int smoothnessId = Shader.PropertyToID("_Smoothness");

        private static MaterialPropertyBlock block;
        
        [SerializeField]
        private Color baseColor = Color.white;
        
        [SerializeField]
        private Color emissionColor = Color.black;

        [SerializeField]
        [Range(0f, 1f)]
        private float cutoff = 0.5f;

        [SerializeField]
        [Range(0f, 1f)]
        private float metallic = 0.5f;

        [SerializeField]
        [Range(0f, 1f)]
        private float smoothness = 0.5f;
        
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
            block.SetColor(emissionColorId, emissionColor);
            block.SetFloat(cutoffId, cutoff);
            block.SetFloat(metallicId, metallic);
            block.SetFloat(smoothnessId, smoothness);
            GetComponent<Renderer>().SetPropertyBlock(block);
        }
    }
}