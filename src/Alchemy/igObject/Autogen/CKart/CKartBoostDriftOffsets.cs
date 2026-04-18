namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartBoostDriftOffsets : igObject
    {
        [FieldAttr(ctr: 12)] public igVec3fMetaField _driftRotationOffsets = new();
        [FieldAttr(ctr: 24)] public float _driftRotationOffsetsInDuration;
        [FieldAttr(ctr: 28)] public float _driftRotationOffsetsSustainDuration;
        [FieldAttr(ctr: 32)] public float _driftRotationOffsetsOutDuration;
    }
}
