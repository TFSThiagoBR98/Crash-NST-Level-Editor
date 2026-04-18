namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CGuiScriptTimerData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _timer = new();
        [FieldAttr(nst: 24, ctr: 24)] public bool _countDown;
        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVec3fMetaField _offset = new();
    }
}
