namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 272, align: 8)]
    public class igSprite : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec2fMetaField[] _positions = new igVec2fMetaField[4];
        [FieldAttr(nst: 48, ctr: 44)] public igVec2fMetaField[] _transformedPositions = new igVec2fMetaField[4];
        [FieldAttr(nst: 80, ctr: 76)] public igVec2fMetaField[] _uvs = new igVec2fMetaField[4];
        [FieldAttr(nst: 112, ctr: 108)] public igVec4ucMetaField[] _colors = new igVec4ucMetaField[4];
        [FieldAttr(nst: 128, ctr: 124)] public igVec2fMetaField _scale = new();
        [FieldAttr(nst: 136, ctr: 132)] public float _rotation;
        [FieldAttr(nst: 140, ctr: 136)] public float _depth;
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igSpriteManager? _manager;
        [FieldAttr(nst: 152, ctr: 152)] public string? _modelClass = null;
        [FieldAttr(nst: 160, ctr: 160, refCount: false)] public igSpriteDrawCallModifier? _modifier;
        [FieldAttr(nst: 168, ctr: 168)] public igHandleMetaField _renderTarget = new();
        [FieldAttr(nst: 176, ctr: 176)] public igHandleMetaField _image = new();
        [FieldAttr(nst: 184, ctr: 184)] public bool _blendState;
        [FieldAttr(nst: 185, ctr: 185)] public bool _hidden;
        [FieldAttr(nst: 186, ctr: 186)] public bool _visible;
        [FieldAttr(nst: 192, ctr: 192)] public igAttrList? _renderAttrs;
        [FieldAttr(nst: 200, ctr: 200)] public igGroup? _renderNode;
        [FieldAttr(nst: 208, ctr: 208)] public igRawRefMetaField _renderMatrix = new();
        [FieldAttr(nst: 216, ctr: 216)] public igRawRefMetaField _userData = new();
        [FieldAttr(nst: 224, ctr: 224)] public bool _positionsDirty = true;
        [FieldAttr(nst: 225, ctr: 225)] public bool _visibilityDirty = true;
        [FieldAttr(nst: 226, ctr: 226)] public bool _skipTransformation;
        [FieldAttr(nst: 232, ctr: 232)] public igRawRefMetaField _extraUvs = new();
        [FieldAttr(nst: 240, ctr: 240, refCount: false)] public igSpriteBucket? _previousBucket;
        [FieldAttr(nst: 248, ctr: 248, refCount: false)] public igSprite? _nextInBucket;
        [FieldAttr(nst: 256, ctr: 256)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 264, ctr: 264)] public uint _bucketHash;
    }
}
