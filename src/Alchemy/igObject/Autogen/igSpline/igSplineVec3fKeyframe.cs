namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igSplineVec3fKeyframe : igSplineData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVec3fMetaField _value = new();
        [FieldAttr(nst: 36, ctr: 28)] public float _tension;
    }
}
