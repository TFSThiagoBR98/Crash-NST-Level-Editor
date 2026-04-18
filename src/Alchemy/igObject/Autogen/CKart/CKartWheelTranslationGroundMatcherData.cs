namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CKartWheelTranslationGroundMatcherData : CKartWheelGroundMatcherData
    {
        [FieldAttr(ctr: 48)] public string? _translationBoneName;
        [FieldAttr(ctr: 56)] public igVec3fMetaField _translationDirection = new();
        [FieldAttr(ctr: 68)] public float _minDistance;
        [FieldAttr(ctr: 72)] public float _maxDistance;
    }
}
