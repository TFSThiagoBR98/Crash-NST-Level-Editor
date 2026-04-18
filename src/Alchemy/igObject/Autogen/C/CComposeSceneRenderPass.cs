namespace Alchemy
{
    [ObjectAttr(nst: 496, ctr: 496, align: 16)]
    public class CComposeSceneRenderPass : igSceneRenderPass
    {
        [FieldAttr(nst: 464, ctr: 460)] public float _viewportRelativeX;
        [FieldAttr(nst: 468, ctr: 464)] public float _viewportRelativeWidth = 1.0f;
        [FieldAttr(nst: 472, ctr: 468)] public float _viewportRelativeY;
        [FieldAttr(nst: 476, ctr: 472)] public float _viewportRelativeHeight = 1.0f;
        [FieldAttr(ctr: 476)] public bool _ignoreMirrorMode;
        [FieldAttr(nst: 480, ctr: 480)] public igSizeTypeMetaField _textureMatrixResource = new();
    }
}
