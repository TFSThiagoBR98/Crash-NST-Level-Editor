namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class CTakeHitData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _pushBackDistance = 75.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _pushBackTime = 0.25f;
        [FieldAttr(nst: 24, ctr: 20)] public float _throwAngleRange = 90.0f;
    }
}
