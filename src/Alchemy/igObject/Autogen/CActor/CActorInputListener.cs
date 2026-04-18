namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8)]
    public class CActorInputListener : CInputListener
    {
        [FieldAttr(nst: 136)] public igHandleMetaField _actor = new();
        [FieldAttr(nst: 144)] public CEntityVscDelegateMetaField _activatorDataOut = new();
    }
}
