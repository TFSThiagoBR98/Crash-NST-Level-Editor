namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 88, align: 8)]
    public class CWorldData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _canSwapHeroes = true;
        [FieldAttr(nst: 17, ctr: 13)] public bool _createHeroes = true;
        [FieldAttr(nst: 20, ctr: 16)] public float _lightVisibilityDistance = 3700.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _lightVisibilityRange = 300.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _cullDistanceVeryLow = 4000.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _cullDistanceLow = 8000.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _cullDistanceMedium = 16000.0f;
        [FieldAttr(nst: 40, ctr: 36)] public float _cullDistanceHigh = 24000.0f;
        [FieldAttr(nst: 44, ctr: 40)] public float _distanceCullFadeRange = 500.0f;
        [FieldAttr(ctr: 44)] public float _distanceCull8th2PFactor;
        [FieldAttr(ctr: 48)] public float _distanceCull8th4PFactor;
        [FieldAttr(ctr: 52)] public float _distanceCullXbone1PFactor;
        [FieldAttr(ctr: 56)] public float _distanceCullXbone2PFactor;
        [FieldAttr(ctr: 60)] public float _distanceCullXbone4PFactor;
        [FieldAttr(ctr: 64)] public float _distanceCull7th1PFactor;
        [FieldAttr(ctr: 68)] public float _distanceCull7th2PFactor;
        [FieldAttr(ctr: 72)] public float _distanceCull7th4PFactor;
        [FieldAttr(nst: 48, ctr: 80)] public CWorldCollectibleModifierTable? _worldCollectibleModifiers;
    }
}
