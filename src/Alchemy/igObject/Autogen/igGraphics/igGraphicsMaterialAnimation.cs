namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igGraphicsMaterialAnimation : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igAnimatedTransformSource? _transform;
        [FieldAttr(nst: 24, ctr: 24)] public EigGraphicsMaterialAnimationConstantType _constantType;
        [FieldAttr(nst: 32, ctr: 32)] public string? _constantName = null;
        [FieldAttr(nst: 40, ctr: 40)] public igSizeTypeMetaField _resource = new();
    }
}
