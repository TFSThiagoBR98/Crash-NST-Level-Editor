namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class igSplineRotationKeyframe : igSplineData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVec3fMetaField _value = new();
        [FieldAttr(nst: 36, ctr: 28)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 48, ctr: 40)] public float _tension;
        [FieldAttr(nst: 52, ctr: 44)] public bool _useSplinePitch;
        [FieldAttr(nst: 53, ctr: 45)] public bool _useSplineRoll;
        [FieldAttr(nst: 54, ctr: 46)] public bool _useSplineYaw;
    }
}
