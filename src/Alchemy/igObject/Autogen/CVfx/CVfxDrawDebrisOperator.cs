namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 104, align: 8)]
    public class CVfxDrawDebrisOperator : igVfxDrawOperator
    {
        [FieldAttr(nst: 32, ctr: 24)] public string? _modelName = null;
        [FieldAttr(nst: 40, ctr: 32)] public igStringRefList? _modelNameList;
        [FieldAttr(nst: 48, ctr: 40)] public uint _collisionFlags = 287;
        [FieldAttr(nst: 52, ctr: 44)] public bool _useDebrisLayer = true;
        [FieldAttr(nst: 56, ctr: 48)] public uint _instance;
        [FieldAttr(nst: 64, ctr: 56)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(nst: 72, ctr: 64)] public igVectorMetaField<CHavokPhysicsSystemDataMetaField> _rigidBodyCache = new();
        [FieldAttr(nst: 96, ctr: 88)] public igHandleList? _modelCacheHandles;
        [FieldAttr(nst: 104, ctr: 96)] public float _physicsTimeScale = 1.0f;
        [FieldAttr(nst: 108, ctr: 100)] public bool _castsShadows = true;
    }
}
