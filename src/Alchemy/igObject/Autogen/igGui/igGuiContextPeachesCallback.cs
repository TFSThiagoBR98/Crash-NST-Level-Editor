namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igGuiContextPeachesCallback : igPeachesBaseCallback
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiContext? _object;
        [FieldAttr(ctr: 24)] public uint _function;
    }
}
