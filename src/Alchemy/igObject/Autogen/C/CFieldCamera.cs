namespace Alchemy
{
    [ObjectAttr(nst: 336, align: 16)]
    public class CFieldCamera : CCameraBase
    {
        [FieldAttr(nst: 288)] public CCameraBase? _A;
        [FieldAttr(nst: 296)] public CCameraBase? _B;
        [FieldAttr(nst: 304)] public float _progressCached;
        [FieldAttr(nst: 308)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 320)] public igVec3fMetaField _max = new();
        [FieldAttr(nst: 332)] public ECameraModelBlendType _blendType = ECameraModelBlendType.eCMBT_Linear;
    }
}
