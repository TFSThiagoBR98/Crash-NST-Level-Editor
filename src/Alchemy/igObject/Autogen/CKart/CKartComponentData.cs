namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CKartComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CKartDriverComponentData? _driverComponent;
    }
}
