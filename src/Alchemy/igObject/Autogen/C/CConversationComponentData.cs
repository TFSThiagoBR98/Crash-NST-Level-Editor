namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CConversationComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igLocalizedString? _title;
    }
}
