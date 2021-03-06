using UnityEngine;
using UnityEngine.Serialization;

namespace CustomRP.Runtime.Settings
{
    [System.Serializable]
    public class ShadowSetting
    {
        
        
        [System.Serializable]
        public class Directional {
            /// <summary>
            /// 图集大小
            /// </summary>
            public ShadowData.TextureSize atlasSize;

            /// <summary>
            /// 阴影 filter
            /// </summary>
            public ShadowData.FilterMode filter;

            /// <summary>
            /// cascade混合模式
            /// </summary>
            public ShadowData.CascadeBlendMode cascadeBlend;
            
            [Range(1, 4)]
            public int cascadeCount;

            [Range(0, 1)]
            public float cascadeRatio1;
            
            [Range(0, 1)]
            public float cascadeRatio2;
            
            [Range(0, 1)]
            public float cascadeRatio3;
        }
        
        [Min(0.001f)]
        public float maxDistance = 100f;

        [Range(0.001f, 1f)]
        public float distanceFade = 0.1f;
        
        
        public Directional directional = new Directional {
            atlasSize = ShadowData.TextureSize._1024,
            filter = ShadowData.FilterMode.PCF2x2,
            cascadeBlend = ShadowData.CascadeBlendMode.Hard,
            cascadeCount = 4,
            cascadeRatio1 = 0.1f,
            cascadeRatio2 = 0.25f,
            cascadeRatio3 = 0.5f,
        };
    }
}