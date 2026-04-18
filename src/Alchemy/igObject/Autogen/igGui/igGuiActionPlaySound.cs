namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class igGuiActionPlaySound : igGuiAction
    {
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _sound = new();
    }
}
