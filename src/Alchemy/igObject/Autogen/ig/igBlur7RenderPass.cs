namespace Alchemy
{
    [ObjectAttr(ctr: 608, align: 16)]
    public class igBlur7RenderPass : igFullScreenRenderPass
    {
        [FieldAttr(ctr: 580)] public float _blurRadius;
        [FieldAttr(ctr: 584)] public igVec4fList? _texcoordOffsets;
        [FieldAttr(ctr: 592)] public igSizeTypeMetaField _texcoordOffsetResource = new();
    }
}
