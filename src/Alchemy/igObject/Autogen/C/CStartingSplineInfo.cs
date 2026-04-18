namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CStartingSplineInfo : igObject
    {
        [FieldAttr(ctr: 12)] public uint _splineHash;
        [FieldAttr(ctr: 16)] public string? _splineName;
        [FieldAttr(ctr: 24)] public float _expectedTime;
    }
}
