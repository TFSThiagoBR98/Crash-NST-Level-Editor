namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CCameraScreenSafeArea : igObject
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public CCamera? _owner;
        [FieldAttr(nst: 24, ctr: 24)] public igVec2fMetaField _min = new();
        [FieldAttr(nst: 32, ctr: 32)] public igVec2fMetaField _max = new();
        [FieldAttr(nst: 40, ctr: 40)] public CConstraintMetaField _azimuthAngleConstraint = new();
        [FieldAttr(nst: 48, ctr: 48)] public CConstraintMetaField _zenithAngleConstraint = new();
    }
}
