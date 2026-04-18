namespace Alchemy
{
    [ObjectAttr(nst: 232, align: 8)]
    public class CGuiBehaviorInitialsEntryDialog : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiList? _characterList0;
        [FieldAttr(nst: 152, refCount: false)] public igGuiList? _characterList1;
        [FieldAttr(nst: 160, refCount: false)] public igGuiList? _characterList2;
        [FieldAttr(nst: 168, refCount: false)] public igGuiPlaceable? _upArrow;
        [FieldAttr(nst: 176, refCount: false)] public igGuiPlaceable? _downArrow;
        [FieldAttr(nst: 184)] public int _focusedListIndex;
        [FieldAttr(nst: 192)] public igObject[] _characterLists = new igObject[3];
        [FieldAttr(nst: 216)] public int[] _lastFocusedListItemIndices = new int[3];
        [FieldAttr(nst: 228)] public bool _hasFocusedInitialList;
    }
}
