namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 304, align: 16)]
    public class CCameraBase : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 28, ctr: 24)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 40, ctr: 40)] public string? _nameCache = null;
        [FieldAttr(nst: 48, ctr: 48)] public CCameraModelMetaField _cameraModel = new();
        [FieldAttr(nst: 256, ctr: 256)] public CTransformMetaField _transform = new();
        [FieldAttr(nst: 284, ctr: 284)] public bool _ignoreTransformWhenBlending;
        [FieldAttr(nst: 285, ctr: 285)] public bool _resetOnNextUpdate;
        [FieldAttr(nst: 286, ctr: 286)] public bool _isActivated;
        [FieldAttr(nst: 287, ctr: 287)] public bool _hasListener = true;
        [FieldAttr(ctr: 288)] public EPlayerId _basePlayerId;
    }
}
