namespace Alchemy
{
    [ObjectAttr(nst: 4312, align: 8)]
    public class CController : igObject
    {
        public enum EInputDeviceType
        {
            IDT_GAMEPAD = 0,
            IDT_KEYBOARD = 1,
            IDT_POINTER = 2,
            IDT_VIRTUAL = 3,
            IDT_COUNT = 4,
        }

        [FieldAttr(nst: 3984, refCount: false)] public igBaseInputDevice? _inputDevice;
        [FieldAttr(nst: 3992, refCount: false)] public igKeyboardInputDevice? _keyboardDevice;
        [FieldAttr(nst: 4000, refCount: false)] public igMouseInputDevice? _mouseDevice;
        [FieldAttr(nst: 4008)] public EControllerType _controllerType;
        [FieldAttr(nst: 4016)] public u64 _buttonState;
        [FieldAttr(nst: 4024)] public u64 _previousButtonState;
        [FieldAttr(nst: 4032)] public u64 _forcedButtonState;
        [FieldAttr(nst: 4040)] public float[] _deflections = new float[62];
        [FieldAttr(nst: 4288)] public igTimeMetaField[] _motorTimeOff = new igTimeMetaField[2];
        [FieldAttr(nst: 4296)] public bool[] _motorOn = new bool[2];
        [FieldAttr(nst: 4300)] public igTimeMetaField _lastActivity = new();
        [FieldAttr(nst: 4304)] public bool _remoteDevice;
        [FieldAttr(nst: 4308)] public EInputDeviceType _activeDeviceType;
    }
}
