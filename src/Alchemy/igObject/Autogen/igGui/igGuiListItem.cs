namespace Alchemy
{
    [ObjectAttr(nst: 136, ctr: 128, align: 8)]
    public class igGuiListItem : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _templateItem = new();
        [FieldAttr(nst: 24)] public bool _newlyAdded = true;
        [FieldAttr(nst: 25)] public bool _newPlaceable;
        [FieldAttr(nst: 26)] public bool _visible;
        [FieldAttr(ctr: 24)] public uint _bitfieldStorage;
        [FieldAttr(nst: 32, ctr: 32)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 40, ctr: 40)] public igVec2fMetaField _min = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec2fMetaField _max = new();
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igGuiListItem? _previous;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igGuiListItem? _next;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igGuiListItem? _rowPrevious;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igGuiListItem? _rowNext;
        [FieldAttr(nst: 88)] public int _focusCount;
        [FieldAttr(nst: 96, ctr: 88)] public string? _label = null;
        [FieldAttr(nst: 104, ctr: 96)] public igGuiListItemVscDelegateMetaField _itemDelegate = new();
        [FieldAttr(nst: 120, ctr: 112)] public igVscDelegateMetaField _spawnedDelegate = new();
    }
}
