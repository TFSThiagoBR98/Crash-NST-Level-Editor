namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class igGuiEventEffectSpawned : igGuiEvent
    {
        [FieldAttr(nst: 24, ctr: 24)] public igVfxSpawnedEffect? _spawnedEffect;
    }
}
