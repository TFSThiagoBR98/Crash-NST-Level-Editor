namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CCameraKeyframeAnimation : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igFloatList? _times;
        [FieldAttr(nst: 24, ctr: 24)] public igVec3fList? _positions;
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fList? _rotations;
        [FieldAttr(nst: 40, ctr: 40)] public igFloatList? _fovs;
    }
}
