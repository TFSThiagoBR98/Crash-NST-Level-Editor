namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CKartDriverComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CKartDriverData? _driverData;
    }
}
