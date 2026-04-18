namespace Alchemy
{
    [ObjectAttr(nst: 248, ctr: 248, align: 8)]
    public class igText : igObject
    {
        public enum EColorMode
        {
            kFlatColor = 0,
            kLinearVerticalAToB = 1,
        }

        [FieldAttr(nst: 16, ctr: 16)] public string? _string = null;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igTextManager? _manager;
        [FieldAttr(nst: 32, ctr: 32)] public igFont? _font;
        [FieldAttr(nst: 40, ctr: 40)] public igRawRefMetaField _rasterizer = new();
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _shadowMaterial = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec2fMetaField _position = new();
        [FieldAttr(nst: 72, ctr: 72)] public igVec2fMetaField _center = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec2fMetaField _scale = new();
        [FieldAttr(nst: 88, ctr: 88)] public float _rotation;
        [FieldAttr(nst: 92, ctr: 92)] public igVec4ucMetaField _color = new();
        [FieldAttr(nst: 96, ctr: 96)] public EColorMode _colorMode;
        [FieldAttr(nst: 100, ctr: 100)] public igVec4ucMetaField _colorA = new();
        [FieldAttr(nst: 104, ctr: 104)] public igVec4ucMetaField _colorB = new();
        [FieldAttr(nst: 108, ctr: 108)] public float _width;
        [FieldAttr(nst: 112, ctr: 112)] public float _height = 1.0f;
        [FieldAttr(nst: 116, ctr: 116)] public float _unscaledWidth;
        [FieldAttr(nst: 120, ctr: 120)] public float _unscaledHeight;
        [FieldAttr(nst: 124, ctr: 124)] public igFont.EHorizontalAlignment _horizontalAlignment;
        [FieldAttr(nst: 128, ctr: 128)] public igFont.EVerticalAlignment _verticalAlignment;
        [FieldAttr(nst: 132, ctr: 132)] public bool _wordWrap;
        [FieldAttr(nst: 136, ctr: 136)] public float _leading;
        [FieldAttr(nst: 140, ctr: 140)] public float _tracking;
        [FieldAttr(nst: 144, ctr: 144)] public bool _clip;
        [FieldAttr(nst: 148, ctr: 148)] public igVec2fMetaField _clipMin = new();
        [FieldAttr(nst: 156, ctr: 156)] public igVec2fMetaField _clipMax = new();
        [FieldAttr(nst: 164, ctr: 164)] public float _depth;
        [FieldAttr(nst: 168, ctr: 168)] public string? _modelClass = null;
        [FieldAttr(nst: 176, ctr: 176)] public igAttrList? _renderAttrs;
        [FieldAttr(nst: 184, ctr: 184)] public igGroup? _renderNode;
        [FieldAttr(nst: 192, ctr: 192)] public igRawRefMetaField _renderMatrix = new();
        [FieldAttr(nst: 200, ctr: 200)] public bool _hidden;
        [FieldAttr(nst: 201, ctr: 201)] public bool _shadow;
        [FieldAttr(nst: 204, ctr: 204)] public igVec2fMetaField _shadowOffset = new();
        [FieldAttr(nst: 212, ctr: 212)] public igVec4ucMetaField _shadowColor = new();
        [FieldAttr(nst: 216, ctr: 216)] public float _shadowDepthOffset;
        [FieldAttr(nst: 224, ctr: 224, refCount: false)] public igTextBucket? _previousBucket;
        [FieldAttr(nst: 232, ctr: 232, refCount: false)] public igText? _nextInBucket;
        [FieldAttr(nst: 240, ctr: 240)] public int _vertexCount;
    }
}
