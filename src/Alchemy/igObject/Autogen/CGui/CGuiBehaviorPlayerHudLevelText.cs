namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CGuiBehaviorPlayerHudLevelText : igGuiBehavior
    {
        [FieldAttr(nst: 16)] public EPlayerId _player = EPlayerId.EPLAYERID_NONE;
        [FieldAttr(nst: 24, refCount: false)] public igGuiPlaceable? _topLevel;
        [FieldAttr(nst: 32, refCount: false)] public igGuiPlaceable? _placeable;
    }
}
