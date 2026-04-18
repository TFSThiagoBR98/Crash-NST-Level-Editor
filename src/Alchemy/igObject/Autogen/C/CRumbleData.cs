namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 4)]
    public class CRumbleData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _rumbleStrength = 0.2f;
        [FieldAttr(nst: 20, ctr: 16)] public float _rumbleDuration = 0.5f;
        [FieldAttr(nst: 24, ctr: 20)] public float _vibrationStrength;
        [FieldAttr(nst: 28, ctr: 24)] public float _vibrationDuration = 0.5f;
    }
}
