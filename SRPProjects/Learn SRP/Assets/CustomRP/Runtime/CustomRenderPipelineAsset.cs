using CustomRP.Runtime;
using CustomRP.Runtime.Settings;
using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(menuName = "Rendering/Custom Render Pipeline")]
public class CustomRenderPipelineAsset : RenderPipelineAsset
{

    [SerializeField]
    public PipelineSetting PipelineSetting;
    
    protected override RenderPipeline CreatePipeline()
    {
        return new CustomRenderPipeline(PipelineSetting);
    }
}
