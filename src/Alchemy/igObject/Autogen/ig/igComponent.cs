namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igComponent : igObject
    {
        [ObjectAttr(size: 4)]
        public class Bitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isStarted;
            [FieldAttr(offset: 1, size: 1)] public bool _hasEverStarted;
            [FieldAttr(offset: 2, size: 1)] public bool _isThreadSafe;
            [FieldAttr(offset: 3, size: 1)] public bool _isCrashed;
            [FieldAttr(offset: 4, size: 1)] public bool _isPendingRemove;
            [FieldAttr(offset: 5, size: 1)] public bool _hasReceivedCreateMessage;
            [FieldAttr(offset: 6, size: 1)] public bool _enabled;
            [FieldAttr(offset: 7, size: 8)] public uint _disableStack;
            [FieldAttr(offset: 15, size: 1)] public bool _enabledByVisualScript = false;
            [FieldAttr(offset: 16, size: 1)] public bool _baseFunctionCalled;
            [FieldAttr(offset: 17, size: 15)] public int _userFlags;
        }

        [FieldAttr(nst: 16, ctr: 16)] public igComponentData? _data;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igEntity? _entity;
        [FieldAttr(nst: 32, ctr: 32)] public Bitfield _bitfield = new();
    }
}
