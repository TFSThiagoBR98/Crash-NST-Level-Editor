namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CutsceneVFXAction : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _boltOwner = new();
        [FieldAttr(nst: 32, ctr: 32)] public string? _spawnedEffectName = null;
    }
}
