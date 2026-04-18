namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiBehaviorOctaneAdventureCharacterSelect : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _animStartMoving;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _animStopMoving;
        [FieldAttr(ctr: 32)] public int _currentDriverIndex;
        [FieldAttr(ctr: 36)] public bool _isTransitioning;
    }
}
