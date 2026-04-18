namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 40, align: 8)]
    public class CLocalizedLine : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _string = null;
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _sound = new();
        [FieldAttr(ctr: 32)] public bool _forced;
        [FieldAttr(ctr: 33)] public bool _skipInEnglish;
    }
}
