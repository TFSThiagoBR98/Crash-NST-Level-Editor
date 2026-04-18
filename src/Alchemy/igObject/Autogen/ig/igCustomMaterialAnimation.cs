namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igCustomMaterialAnimation : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igTransformSource3? _transform;
        [FieldAttr(nst: 24, ctr: 24)] public string? _fieldName = null;
        [FieldAttr(nst: 32, ctr: 32)] public EigCustomMaterialAnimationTarget _animationTarget;
        [FieldAttr(nst: 36, ctr: 36)] public int _unitID = -1;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igCustomMaterial? _owner;
    }
}
