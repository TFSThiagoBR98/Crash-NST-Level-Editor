namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CGlobalWindData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _windStrength = 0.25f;
        [FieldAttr(nst: 20, ctr: 16)] public igVec3fMetaField _windDirection = new();
        [FieldAttr(nst: 32, ctr: 28)] public float _gustFrequency = 0.1f;
        [FieldAttr(nst: 36, ctr: 32)] public float _gustPrimaryDistance = 24.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _gustScale = 5.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _gustStrengthMin;
        [FieldAttr(nst: 48, ctr: 44)] public float _gustStrengthMax = 0.6f;
        [FieldAttr(nst: 52, ctr: 48)] public float _gustDurationMin = 1.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _gustDurationMax = 3.0f;
        [FieldAttr(nst: 60, ctr: 56)] public float _gustDirectionAdjustment;
        [FieldAttr(nst: 64, ctr: 60)] public float _gustUnison = 0.85f;
    }
}
