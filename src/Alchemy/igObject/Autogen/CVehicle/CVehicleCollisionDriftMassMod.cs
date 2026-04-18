namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CVehicleCollisionDriftMassMod : igObject
    {
        [FieldAttr(ctr: 12)] public int _weightChange;
        [FieldAttr(ctr: 16)] public float _driftDot;
    }
}
