namespace Alchemy
{
    [ObjectAttr(nst: 200, ctr: 224, align: 8)]
    public class igRenderTarget : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _parentTarget = new();
        [FieldAttr(nst: 32, ctr: 24)] public string? _formatName = null;
        [FieldAttr(ctr: 32)] public string? _formatNameHdr;
        [FieldAttr(nst: 48, ctr: 40)] public string? _textureFormatName = null;
        [FieldAttr(nst: 56, ctr: 48)] public int _width = -1;
        [FieldAttr(nst: 60, ctr: 52)] public int _height = -1;
        [FieldAttr(nst: 64, ctr: 56)] public float _widthScale = 1.0f;
        [FieldAttr(nst: 68, ctr: 60)] public float _heightScale = 1.0f;
        [FieldAttr(nst: 72, ctr: 64)] public float _highResolutionScale = 1.0f;
        [FieldAttr(nst: 76, ctr: 68)] public EIG_GFX_MULTISAMPLE_TYPE _msaaType;
        [FieldAttr(nst: 80, ctr: 72)] public int _levelCount = 1;
        [FieldAttr(nst: 84, ctr: 76)] public uint _wiiClearOnResolve;
        [FieldAttr(nst: 88, ctr: 80)] public bool _wiiDownsample2x2;
        [FieldAttr(nst: 89, ctr: 81)] public bool _ps4UseHtile = true;
        [FieldAttr(nst: 90, ctr: 82)] public bool _ps4UseCompression = true;
        [FieldAttr(nst: 91, ctr: 83)] public bool _ps4UseCheckerboard;
        [FieldAttr(nst: 92, ctr: 84)] public bool _mobileClearToAnyValue;
        [FieldAttr(nst: 93, ctr: 85)] public bool _mobileDiscardAfterUse;
        [FieldAttr(nst: 94, ctr: 86)] public bool _active;
        [FieldAttr(nst: 96, ctr: 88)] public int _computedWidth;
        [FieldAttr(nst: 100, ctr: 92)] public int _computedHeight;
        [FieldAttr(nst: 104, ctr: 96)] public string? _computedFormatName = null;
        [FieldAttr(nst: 112, ctr: 104)] public string? _computedTextureFormatName = null;
        [FieldAttr(nst: 120, ctr: 112)] public int _firstWrite = -1;
        [FieldAttr(nst: 124, ctr: 116)] public int _lastWrite = -1;
        [FieldAttr(nst: 128, ctr: 120)] public int _firstRead = -1;
        [FieldAttr(nst: 132, ctr: 124)] public int _lastRead = -1;
        [FieldAttr(nst: 136, ctr: 128)] public int _firstUse = -1;
        [FieldAttr(nst: 140, ctr: 132)] public int _lastUse = -1;
        [FieldAttr(ctr: 136)] public uint _readWriteAfterFirstWriteCount;
        [FieldAttr(nst: 144, ctr: 140)] public bool _global;
        [FieldAttr(nst: 152, ctr: 144)] public igRawRefMetaField _textureBuffer = new();
        [FieldAttr(nst: 160, ctr: 152)] public int _wiiEfbX;
        [FieldAttr(nst: 164, ctr: 156)] public int _wiiEfbY;
        [FieldAttr(nst: 168, ctr: 160)] public igSizeTypeMetaField _texture = new();
        [FieldAttr(nst: 176, ctr: 168)] public igSizeTypeMetaField _renderTargetView = new();
        [FieldAttr(nst: 184, ctr: 176)] public bool _durangoInEsram;
        [FieldAttr(ctr: 180)] public uint _durangoEsramOffsetBytes;
        [FieldAttr(ctr: 184)] public uint _durangoEsramUsageBytes;
        [FieldAttr(ctr: 192)] public igRawRefMetaField _durangoEsramConfig = new();
        [FieldAttr(nst: 192, ctr: 200)] public igRenderTarget? _resolveTarget;
        [FieldAttr(nst: 28, ctr: 208)] public int _renderToParentTextureLevel;
        [FieldAttr(nst: 24, ctr: 212)] public bool _renderToParentTexture;
        [FieldAttr(nst: 40, ctr: 213)] public bool _createTexture = true;
        [FieldAttr(ctr: 214)] public bool _createTextureView;
        [FieldAttr(ctr: 215)] public bool _surfaceOwner;
        [FieldAttr(nst: 41, ctr: 216)] public bool _isColorSurface = true;
        [FieldAttr(nst: 42, ctr: 217)] public bool _forceExpandInPlace;
        [FieldAttr(nst: 188)] public uint _durangoEsramOffset;
    }
}
