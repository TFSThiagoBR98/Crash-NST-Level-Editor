namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CBossLapTTRData : igObject
    {
        [FieldAttr(ctr: 12)] public igVec3fMetaField _best = new();
        [FieldAttr(ctr: 24)] public igVec3fMetaField _rubberBand = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _worst = new();
    }
}
