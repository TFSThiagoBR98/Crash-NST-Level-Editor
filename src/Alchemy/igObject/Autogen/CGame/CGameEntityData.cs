namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 8)]
    public class CGameEntityData : CEntityData
    {
        [FieldAttr(nst: 56, ctr: 56)] public uint _gameEntityFlags = 512;
        [FieldAttr(nst: 60, ctr: 60)] public EDistanceCullImportance _distanceCullImportance = EDistanceCullImportance.kMedium;
        [FieldAttr(nst: 64, ctr: 64)] public ETeamFilterLayers _collisionLayer = ETeamFilterLayers.eTFL_Entity;
        [FieldAttr(nst: 68, ctr: 68)] public ECharacterCollisionPriority _collisionPriority = ECharacterCollisionPriority.eCCP_None;
        [FieldAttr(nst: 72, ctr: 72)] public string? _modelName = null;
        [FieldAttr(nst: 80, ctr: 80)] public string? _skinName = null;
        [FieldAttr(nst: 88, ctr: 88)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(nst: 96, ctr: 96)] public igHandleMetaField _collisionMaterial = new();
        [FieldAttr(nst: 104, ctr: 104)] public bool _castsShadows = true;
        [FieldAttr(nst: 108, ctr: 108)] public EMobileShadowState _mobileShadowState;
        [FieldAttr(nst: 112, ctr: 112)] public float _lifetime;
        [FieldAttr(nst: 116, ctr: 116)] public float _lifetimeModifier;
        [FieldAttr(nst: 120, ctr: 120)] public EMemoryPoolID _cachedAssetPool = EMemoryPoolID.MP_MAX_POOL;
    }
}
