namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CLensFlareData : igObject
    {
        [FieldAttr(ctr: 16)] public CLensFlareComponentData? _lensFlareComponentData;
    }
}
