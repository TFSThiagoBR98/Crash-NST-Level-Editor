namespace Alchemy
{
    [ObjectAttr(ctr: 448, align: 16)]
    public class CBoxLight : igRenderLight
    {
        [FieldAttr(ctr: 68)] public igVec3fMetaField _rotation = new();
        [FieldAttr(ctr: 80)] public igVec3fMetaField _min = new();
        [FieldAttr(ctr: 92)] public igVec3fMetaField _max = new();
        [FieldAttr(ctr: 104)] public float _nearAttenuation;
        [FieldAttr(ctr: 108)] public float _attenuation;
        [FieldAttr(ctr: 112)] public float _xFalloff;
        [FieldAttr(ctr: 116)] public float _yFalloff;
        [FieldAttr(ctr: 120)] public float _wrap;
        [FieldAttr(ctr: 128)] public string? _cookieTextureName;
        [FieldAttr(ctr: 136)] public bool _overrideUVs;
        [FieldAttr(ctr: 140)] public igVec2fMetaField[] _UVs = new igVec2fMetaField[4];
        [FieldAttr(ctr: 176)] public igVfxAnimatedFrame? _uvAnimation;
        [FieldAttr(ctr: 184)] public bool _distanceCull;
        [FieldAttr(ctr: 185)] public u8 _forceViewportDisableFlags;
        [FieldAttr(ctr: 188)] public uint _uvAnimationInstance;
        [FieldAttr(ctr: 196)] public igRandomMetaField _rng = new();
        [FieldAttr(ctr: 208)] public igMatrix44fMetaField _worldToLocalMatrix = new();
        [FieldAttr(ctr: 272)] public igVec4fMetaField _direction = new();
        [FieldAttr(ctr: 288)] public igVec4fMetaField[] _corners = new igVec4fMetaField[8];
        [FieldAttr(ctr: 416)] public igObjectDirectory? _imageDirectory;
        [FieldAttr(ctr: 424)] public igHandleMetaField _imageHandle = new();
        [FieldAttr(ctr: 432)] public CBoxLightPeachesCallback? _peachesCallback;
    }
}
