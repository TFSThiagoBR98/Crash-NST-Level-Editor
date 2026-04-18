namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 16)]
    public class igGuiEffect : igGuiAsset
    {
        [FieldAttr(nst: 32, ctr: 32)] public igGuiEventEffectSpawned? _spawnedEffectEvent;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 48, ctr: 48)] public float _distanceFromCamera = 50.0f;
        [FieldAttr(nst: 52, ctr: 52)] public u16 _layer = 65535;
        [FieldAttr(nst: 56, ctr: 56)] public igVfxManager.EffectKillType _killType;
        [FieldAttr(nst: 60, ctr: 60)] public igVfxManager.ESpawnGroup _spawnGroup = igVfxManager.ESpawnGroup.kSpawnGroup1;
        [FieldAttr(nst: 64, ctr: 64)] public bool _setBoltParametersFromTexCoords;
        [FieldAttr(nst: 72, ctr: 72)] public igHandleMetaField _spawnedEffect = new();
        [FieldAttr(nst: 80, ctr: 80)] public igGuiPlaceableBolt? _bolt;
    }
}
