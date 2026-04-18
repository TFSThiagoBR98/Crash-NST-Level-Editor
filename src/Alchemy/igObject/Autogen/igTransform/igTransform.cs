namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 160, align: 16)]
    public class igTransform : igGroup
    {
        [FieldAttr(nst: 64, ctr: 64)] public igMatrix44fMetaField _m = new();
        [FieldAttr(nst: 128, ctr: 128)] public int _target;
        [FieldAttr(nst: 136, ctr: 136)] public igTransformSource? _transformInput;
        [FieldAttr(nst: 144, ctr: 144)] public igTransformSource3? _transformInput3;
    }
}
