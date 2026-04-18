namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CLodModeSet : igObject
    {
        [FieldAttr(ctr: 12)] public EDeviceClass _deviceClass;
        [FieldAttr(ctr: 16)] public uint _lodModes;
    }
}
