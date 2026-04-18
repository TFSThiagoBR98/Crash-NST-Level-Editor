namespace Alchemy
{
    [ObjectAttr(nst: 256, ctr: 272, align: 8)]
    public class CSkinnedModelInstance : CModelInstance
    {
        [FieldAttr(nst: 72, ctr: 68)] public CEntityIDMetaField _entityID = new();
        [FieldAttr(nst: 80, ctr: 72, refCount: false)] public CSkinAsset? _skinAsset;
        [FieldAttr(nst: 88, ctr: 80)] public string? mSkinAnimName = null;
        [FieldAttr(nst: 96, ctr: 88)] public igVec3fMetaField mSkinBoundsMin = new();
        [FieldAttr(nst: 108, ctr: 100)] public igVec3fMetaField mSkinBoundsMax = new();
        [FieldAttr(nst: 120, ctr: 112)] public CHavokAnimationCombiner? mCombiner;
        [FieldAttr(nst: 128, ctr: 120)] public igRawRefMetaField mAnimatedSkeleton = new();
        [FieldAttr(nst: 136, ctr: 128)] public igRawRefMetaField mAnim = new();
        [FieldAttr(nst: 144, ctr: 136)] public bool _automaticUpdate;
        [FieldAttr(nst: 145, ctr: 137)] public bool _updateAnimation;
        [FieldAttr(nst: 146, ctr: 138)] public bool _physicsOutOfSync;
        [FieldAttr(nst: 147, ctr: 139)] public bool _paused;
        [FieldAttr(nst: 148, ctr: 140)] public bool _animationUpdateSkipped;
        [FieldAttr(nst: 152, ctr: 144)] public igRawRefMetaField _animationEventListener = new();
        [FieldAttr(nst: 160, ctr: 152)] public igRawRefMetaField mDefaultAnimMotion = new();
        [FieldAttr(nst: 168)] public igVectorMetaField<CBoltedModelMetaField> mBoltedModels_1 = new();
        [FieldAttr(ctr: 160)] public igVectorMetaField<CBoltedModelMetaField> mBoltedModels2 = new();
        [FieldAttr(nst: 192, ctr: 184)] public CGraphicsSkinInfo? _skinInfo;
        [FieldAttr(nst: 200, ctr: 192)] public CHavokSkeleton? mSkeleton;
        [FieldAttr(nst: 208, ctr: 200)] public igRawRefMetaField _pendingAnimationControl = new();
        [FieldAttr(nst: 216, ctr: 208)] public float _pendingBlendTime;
        [FieldAttr(nst: 224, ctr: 216, refCount: false)] public CPhysicsSystemSkeletonBinding? _physicsSystemSkeletonBinding;
        [FieldAttr(nst: 232, ctr: 224)] public int mRequestUpdateId;
        [FieldAttr(nst: 236, ctr: 228)] public uint _asyncActive;
        [FieldAttr(ctr: 232)] public string? _modelClass;
        [FieldAttr(ctr: 240)] public string? _modelClassForFading;
        [FieldAttr(nst: 240, ctr: 248)] public uint _extractedMotionMemento;
    }
}
