namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 240, align: 16)]
    public class igVfxBolt : igVfxRuntimeObject
    {
        public enum ECullType
        {
            kCullNone = 0,
            kCullDefault = 1,
            kCullSoft = 2,
            kCullHard = 4,
            kCullPause = 8,
            kCullAll = 14,
        }

        [ObjectAttr(size: 4)]
        public class BoltFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _flip;
            [FieldAttr(offset: 1, size: 1)] public bool _hasUpdated;
            [FieldAttr(offset: 2, size: 1)] public bool _teleported;
            [FieldAttr(offset: 3, size: 1)] public bool _isValid = false;
            [FieldAttr(offset: 4, size: 1)] public bool _isVisible = false;
            [FieldAttr(offset: 5, size: 1)] public bool _keepScale = false;
            [FieldAttr(offset: 6, size: 1)] public bool _lateUpdate = false;
        }

        [FieldAttr(ctr: 12)] public float _boltUpdateTime;
        [FieldAttr(nst: 16, ctr: 16)] public igMatrix44fMetaField _matrix = new();
        [FieldAttr(nst: 80, ctr: 80)] public igQuaternionFramefMetaField _frame = new();
        [FieldAttr(nst: 112, ctr: 112)] public igQuaternionFramefMetaField _inverseFrame = new();
        [FieldAttr(nst: 144, ctr: 144)] public igVec3fAlignedMetaField _velocity = new();
        [FieldAttr(nst: 160, ctr: 160)] public igVec3fAlignedMetaField _spin = new();
        [FieldAttr(nst: 176, ctr: 176)] public igVec3fMetaField _size = new();
        [FieldAttr(nst: 188, ctr: 188)] public float _scale = 1.0f;
        [FieldAttr(nst: 192, ctr: 192)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 208, ctr: 208)] public igVec4fMetaField _parameters = new();
        [FieldAttr(nst: 224, ctr: 224)] public igVfxBaseVariable? _variables;
        [FieldAttr(nst: 232, ctr: 232)] public BoltFlags _boltFlags = new();
    }
}
