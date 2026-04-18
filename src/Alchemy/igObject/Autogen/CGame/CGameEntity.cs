namespace Alchemy
{
    [ObjectAttr(nst: 224, ctr: 224, align: 8)]
    public class CGameEntity : CEntity
    {
        public enum ECastsShadows
        {
            ECS_Archetype = 0,
            ECS_CastsShadows = 1,
            ECS_DoesNotCastShadows = 2,
        }

        public enum EMobileShadowStateOverride
        {
            eMSSO_Archetype = 0,
            eMSSO_CastsShadows = 1,
            eMSSO_ReceivesShadows = 2,
            eMSSO_DoesNotCastOrReceiveShadows = 3,
        }

        [ObjectAttr(size: 4)]
        public class GameEntityPersistentProperties : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 2)] public CGameEntity.ECastsShadows _castsShadows;
            [FieldAttr(offset: 2, size: 2)] public CGameEntity.EMobileShadowStateOverride _mobileShadowStateOverride;
        }

        [ObjectAttr(size: 4)]
        public class GameEntityProperties : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 8)] public u8 _viewportForceDisableFlags;
            [FieldAttr(offset: 8, size: 1)] public bool _animActive;
            [FieldAttr(offset: 9, size: 1)] public bool _animInReverse;
            [FieldAttr(offset: 10, size: 1)] public bool _noKillZ;
            [FieldAttr(offset: 11, size: 1)] public bool _hasDestination;
            [FieldAttr(offset: 12, size: 1)] public bool _scaleMovementSpeed;
        }

        [FieldAttr(nst: 144, ctr: 144)] public GameEntityPersistentProperties _gameEntityPersistentProperties = new();
        [FieldAttr(nst: 148, ctr: 148)] public bool _ignoreOcclusionBoxes;
        [FieldAttr(nst: 152, ctr: 152)] public GameEntityProperties _gameEntityProperties = new();
        [FieldAttr(nst: 156, ctr: 156)] public float _lifetimeCache;
        [FieldAttr(nst: 160, ctr: 160)] public CAttachModelList? _attachModelList;
        [FieldAttr(nst: 168, ctr: 168)] public igHandleMetaField _overrideRenderMatrixComponent = new();
        [FieldAttr(nst: 176, ctr: 176)] public CModelInstance? mModel;
        [FieldAttr(nst: 184, ctr: 184)] public bool mBelowKillZ;
        [FieldAttr(nst: 185, ctr: 185)] public bool _IsValidModel;
        [FieldAttr(nst: 192, ctr: 192)] public CFxMaterialRedirectTable? _dynamicModelMaterialOverrides;
        [FieldAttr(nst: 200, ctr: 200)] public igHandleMetaField _spawnedRenderVfx = new();
        [FieldAttr(nst: 208, ctr: 208)] public CCloudBundle? _cloudBundle;
        [FieldAttr(nst: 216, ctr: 216)] public igTimeMetaField _lastNetUpdateTime = new();
    }
}
