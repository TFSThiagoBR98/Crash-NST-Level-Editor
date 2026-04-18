namespace Alchemy
{
    [ObjectAttr(nst: 480, ctr: 480, align: 16)]
    public class CGuiRenderPass : igSceneRenderPass
    {
        [FieldAttr(nst: 464, ctr: 464)] public string? _vfxCameraName = "main";
        [FieldAttr(ctr: 472)] public igSizeTypeMetaField _additiveBlendConstantResource = new();
    }
}
