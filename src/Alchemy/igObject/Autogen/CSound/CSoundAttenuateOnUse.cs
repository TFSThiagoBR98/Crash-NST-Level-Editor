namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CSoundAttenuateOnUse : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _staticIntroTime = 2.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _attenuateTime = 2.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _resetTime = 6.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _targetVolume = 0.5f;
        [FieldAttr(nst: 32, ctr: 28)] public igTimeMetaField _startTime = new();
        [FieldAttr(nst: 36, ctr: 32)] public igTimeMetaField _nextResetTime = new();
    }
}
