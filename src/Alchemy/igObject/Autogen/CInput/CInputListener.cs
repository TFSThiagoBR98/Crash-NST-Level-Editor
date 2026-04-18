namespace Alchemy
{
    [ObjectAttr(nst: 136, align: 8)]
    public class CInputListener : igObject
    {
        public enum EInputState
        {
            kUnknown = 0,
            kPressed = 1,
            kHolding = 2,
            kReleased = 3,
        }

        [ObjectAttr(size: 2)]
        public class Flags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _stopped;
            [FieldAttr(offset: 1, size: 1)] public bool _stopOnPressed;
            [FieldAttr(offset: 2, size: 1)] public bool _stopOnHold;
            [FieldAttr(offset: 3, size: 1)] public bool _stopOnReleased;
        }

        [FieldAttr(nst: 16)] public EXBUTTON _button;
        [FieldAttr(nst: 20)] public Flags _flags = new();
        [FieldAttr(nst: 24)] public EPlayerId _player = EPlayerId.EPLAYERID_NONE;
        [FieldAttr(nst: 32)] public igVscFloatDelegateMetaField _deflectionDataOut = new();
        [FieldAttr(nst: 48)] public igVscVec2fDelegateMetaField _stickDeflectionDataOut = new();
        [FieldAttr(nst: 64)] public igVscVec3fDelegateMetaField _relativeStickDeflectionDataOut = new();
        [FieldAttr(nst: 80)] public igVscDelegateMetaField _pressedCallback = new();
        [FieldAttr(nst: 96)] public igVscDelegateMetaField _holdingCallback = new();
        [FieldAttr(nst: 112)] public igVscDelegateMetaField _releasedCallback = new();
        [FieldAttr(nst: 128)] public EInputState _state;
    }
}
