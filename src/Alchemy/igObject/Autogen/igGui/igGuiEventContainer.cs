namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class igGuiEventContainer : igObject
    {
        [FieldAttr(ctr: 16)] public igGuiEventDelegate? _received;
    }
}
