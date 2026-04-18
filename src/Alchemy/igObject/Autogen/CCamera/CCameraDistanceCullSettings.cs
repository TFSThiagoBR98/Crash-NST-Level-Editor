namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CCameraDistanceCullSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _cullDistanceVeryLow = 4000.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _cullDistanceLow = 8000.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _cullDistanceMedium = 16000.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _cullDistanceHigh = 24000.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _distanceCullFadeRange = 500.0f;
    }
}
