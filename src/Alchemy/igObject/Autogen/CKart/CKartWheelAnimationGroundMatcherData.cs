namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CKartWheelAnimationGroundMatcherData : CKartWheelGroundMatcherData
    {
        [FieldAttr(ctr: 48)] public string? _suspensionStartBoneName;
        [FieldAttr(ctr: 56)] public string? _suspensionEndBoneName;
        [FieldAttr(ctr: 64)] public string? _suspensionAnimName;
        [FieldAttr(ctr: 72)] public int _preSampleCount;
    }
}
