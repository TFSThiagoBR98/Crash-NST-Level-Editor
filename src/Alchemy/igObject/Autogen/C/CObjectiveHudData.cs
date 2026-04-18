namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CObjectiveHudData : igObject
    {
        [FieldAttr(ctr: 12)] public uint _flagsBitfield;
        [FieldAttr(ctr: 16)] public string? _title;
        [FieldAttr(ctr: 24)] public string? _description;
        [FieldAttr(ctr: 32)] public igHandleMetaField _icon = new();
        [FieldAttr(ctr: 40)] public int _progress;
        [FieldAttr(ctr: 44)] public int _targetProgress;
        [FieldAttr(ctr: 48)] public int _displayProgress;
    }
}
