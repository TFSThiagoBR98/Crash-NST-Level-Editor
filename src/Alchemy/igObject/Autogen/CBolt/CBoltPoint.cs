namespace Alchemy
{
    [ObjectAttr(nst: 192, ctr: 192, align: 16)]
    public class CBoltPoint : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 28, ctr: 24)] public bool _flipX;
        [FieldAttr(nst: 29, ctr: 25)] public bool _flipY;
        [FieldAttr(nst: 30, ctr: 26)] public bool _flipZ;
        [FieldAttr(nst: 31, ctr: 27)] public bool _verticalAlign;
        [FieldAttr(nst: 32, ctr: 28)] public bool _worldAlign;
        [FieldAttr(nst: 33, ctr: 29)] public bool _cameraAlign;
        [FieldAttr(nst: 34, ctr: 30)] public bool _keepScale = true;
        [FieldAttr(nst: 35, ctr: 31)] public bool _keepConstantSize;
        [FieldAttr(nst: 36, ctr: 32)] public float _scale = 1.0f;
        [FieldAttr(nst: 40, ctr: 36)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 52, ctr: 48)] public igVec3fMetaField _postOffset = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _vfxColor = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _vfxParameters = new();
        [FieldAttr(nst: 96, ctr: 96)] public string? _boltName = "";
        [FieldAttr(nst: 104, ctr: 104)] public string? _preserveBoltName = "";
        [FieldAttr(nst: 112, ctr: 112)] public igMatrix44fMetaField _adjustmentMatrix = new();
        [FieldAttr(nst: 176, ctr: 176)] public bool _useAdjustmentMatrix;
    }
}
