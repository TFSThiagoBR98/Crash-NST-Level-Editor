namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CDriftData : igObject
    {
        [FieldAttr(nst: 16)] public float _turningLookAheadTime = 0.05f;
        [FieldAttr(nst: 24)] public CVehicleBoostData? _driftBoostLevel2;
        [FieldAttr(nst: 32)] public CVehicleBoostData? _driftBoostLevel3;
        [FieldAttr(nst: 40)] public igHandleMetaField _vfxToSpawn = new();
        [FieldAttr(nst: 48)] public CBoltPoint? _boltPoint1;
        [FieldAttr(nst: 56)] public CBoltPoint? _boltPoint2;
        [FieldAttr(nst: 64)] public bool _dirty;
    }
}
