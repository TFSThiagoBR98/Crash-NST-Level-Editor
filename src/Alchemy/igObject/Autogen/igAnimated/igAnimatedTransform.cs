namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 16)]
    public class igAnimatedTransform : igNamedObject
    {
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _matrix = new();
        [FieldAttr(nst: 96, ctr: 96)] public igAnimatedTransformSource? _source;
    }
}
