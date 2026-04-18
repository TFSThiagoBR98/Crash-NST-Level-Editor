namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CBaseVehicleSetting : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _stat;
        [FieldAttr(nst: 20, ctr: 16)] public bool _dirty;
    }
}
