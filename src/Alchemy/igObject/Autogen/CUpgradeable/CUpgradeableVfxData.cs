namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CUpgradeableVfxData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 24, ctr: 24)] public CVfxSpawnLayers? _spawnLayers;
    }
}
