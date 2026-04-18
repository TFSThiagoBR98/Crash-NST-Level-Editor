namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class igMouseInputDevice : igBaseInputDevice
    {
        [FieldAttr(nst: 40)] public bool _mouseInClientArea;
        [FieldAttr(nst: 41)] public bool _firesEvents;
        [FieldAttr(nst: 48)] public igMouseInputEventHandler? _capture;
        [FieldAttr(nst: 56)] public igVec2fMetaField _previousPosition = new();
        [FieldAttr(nst: 64)] public igVec2fMetaField _aimSensitivity = new();
        [FieldAttr(nst: 72)] public bool _cursorLocked;
    }
}
