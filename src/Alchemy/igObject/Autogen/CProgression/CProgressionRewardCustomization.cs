namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CProgressionRewardCustomization : CProgressionReward
    {
        [FieldAttr(ctr: 12)] public EKartCustomizationType _customizationType;
        [FieldAttr(ctr: 16)] public int _customizationIndex;
        [FieldAttr(ctr: 24)] public string? _kartName;
    }
}
