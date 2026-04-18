namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igLocalizedStringData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _string = null;
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _object = new();
        [FieldAttr(nst: 32, ctr: 32)] public igStringMetaFieldInstance? _field;
    }
}
