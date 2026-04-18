namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CStaticVfxComponentData : igComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 32, ctr: 24)] public bool _startSpawned = true;
        [FieldAttr(ctr: 25)] public bool _spawnPerCamera;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _boltPoint2 = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _boltObject2 = new();
    }
}
