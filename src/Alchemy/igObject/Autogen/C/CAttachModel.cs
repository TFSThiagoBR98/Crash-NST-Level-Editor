namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CAttachModel : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _parent = new();
        [FieldAttr(ctr: 24)] public string? _modelName;
        [FieldAttr(ctr: 32)] public igVec3fMetaField _position = new();
        [FieldAttr(ctr: 44)] public igVec3fMetaField _rotation = new();
        [FieldAttr(ctr: 56)] public igVec3fMetaField _scale = new();
        [FieldAttr(ctr: 72)] public CModelInstance? _model;
        [FieldAttr(ctr: 80)] public CFxMaterialRedirectTable? _dynamicMaterialOverride;
        [FieldAttr(ctr: 88)] public CFxMaterialRedirectTable? _materialOverrides;
        [FieldAttr(ctr: 96)] public CBoltPoint? _bolt;
    }
}
