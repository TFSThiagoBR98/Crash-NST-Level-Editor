namespace Alchemy
{
    [ObjectAttr(nst: 624, ctr: 608, align: 16)]
    public class CMobileComposeSceneRenderPass : igFullScreenRenderPass
    {
        [FieldAttr(nst: 592, ctr: 580)] public float _viewportRelativeX;
        [FieldAttr(nst: 596, ctr: 584)] public float _viewportRelativeWidth = 1.0f;
        [FieldAttr(nst: 600, ctr: 588)] public float _viewportRelativeY;
        [FieldAttr(nst: 604, ctr: 592)] public float _viewportRelativeHeight = 1.0f;
        [FieldAttr(nst: 608, ctr: 600)] public igSizeTypeMetaField _textureMatrixResource = new();
    }
}
