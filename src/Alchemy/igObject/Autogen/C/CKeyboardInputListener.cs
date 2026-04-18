namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 8)]
    public class CKeyboardInputListener : CInputListener
    {
        [FieldAttr(nst: 136)] public igKeyboardInputDevice.ESignal _key;
        [FieldAttr(nst: 140)] public bool _requireShift;
    }
}
