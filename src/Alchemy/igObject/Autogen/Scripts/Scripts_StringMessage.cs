namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8, metaType: typeof(CPlayerMessage))]
    public class Scripts_StringMessage : CPlayerMessage
    {
        [FieldAttr(nst: 64)] public string? MessageString = "";
    }
}
