namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4)]
    public class CRacerLODSettings : igObject
    {
        [FieldAttr(ctr: 12)] public int _highestLOD;
        [FieldAttr(ctr: 16)] public int _minimumLODFocused;
        [FieldAttr(ctr: 20)] public int _maximumLODFocused;
        [FieldAttr(ctr: 24)] public int _minimumLODUnfocused;
        [FieldAttr(ctr: 28)] public int _maximumLODUnfocused;
        [FieldAttr(ctr: 32)] public float _minimumLODDistanceFromCamera;
    }
}
