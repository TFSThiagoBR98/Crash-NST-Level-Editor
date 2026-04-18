namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CKartWheelGroundMatcherData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _wheelReferenceBoneName;
        [FieldAttr(ctr: 24)] public igVec3fMetaField _wheelOffset = new();
        [FieldAttr(ctr: 36)] public int _numSearchSamples;
        [FieldAttr(ctr: 40)] public int _dirtyCount;
    }
}
