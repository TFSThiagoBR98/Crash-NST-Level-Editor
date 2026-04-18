namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CDeviceClassSet : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _deviceClasses = 31;
        [FieldAttr(nst: 20, ctr: 16)] public bool _nintendoLayer;
    }
}
