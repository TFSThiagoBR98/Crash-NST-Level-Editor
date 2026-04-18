namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CModeRGpiComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _unscaledAssetRadius;
        [FieldAttr(ctr: 24)] public CModeRRingDataList? _ringSteps;
    }
}
