namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CVehicleCollisionSpeedMassMod : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _speedRatio;
        [FieldAttr(nst: 20, ctr: 16)] public int _weightChange;
    }
}
