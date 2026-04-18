namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CWaterDetectorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CSourceData? _sourceData;
    }
}
