namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiBehaviorPitstopContextualMessageBox : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _statusIcon;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _statusTextPlace;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _showStatusAnim;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _hideStatusAnim;
        [FieldAttr(ctr: 48)] public CMarketplaceSku? _marketplaceSku;
        [FieldAttr(ctr: 56)] public bool _statusIconVisible;
    }
}
