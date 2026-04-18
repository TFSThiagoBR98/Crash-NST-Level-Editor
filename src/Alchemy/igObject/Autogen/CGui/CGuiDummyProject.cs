namespace Alchemy
{
    [ObjectAttr(ctr: 264, align: 8)]
    public class CGuiDummyProject : igGuiProject
    {
        [FieldAttr(ctr: 232)] public igHandleMetaField _openedProject = new();
        [FieldAttr(ctr: 240)] public igVscDelegateMetaField _openedCallback = new();
        [FieldAttr(ctr: 256)] public igGuiEventList? _queuedEvents;
    }
}
