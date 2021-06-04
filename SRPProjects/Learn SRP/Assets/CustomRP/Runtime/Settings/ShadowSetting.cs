using UnityEngine;

namespace CustomRP.Runtime.Settings
{
    [System.Serializable]
    public class ShadowSetting
    {
        
        
        [System.Serializable]
        public struct Directional {
            public ShadowData.TextureSize atlasSize;
        }
        
        [Min(0f)]
        public float maxDistance = 100f;
        public Directional directional = new Directional {
            atlasSize = ShadowData.TextureSize._1024
        };
    }
}