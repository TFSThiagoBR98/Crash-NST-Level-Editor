namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CSmokeActionBase : igObject
    {
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public bool _allowSplitscreen;
        [FieldAttr(ctr: 25)] public bool _allowBinocular;
        [FieldAttr(ctr: 28)] public igTimeMetaField _waitTimeDone = new();
        [FieldAttr(ctr: 32)] public bool _endedExternally;
    }
}
