namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class CGuiBehaviorPlayerWidget : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiPlaceable? _rankPlaceable;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiPlaceable? _rankText;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiPlaceable? _profilePicture;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiPlaceable? _profileCrop;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igGuiPlaceable? _loadingIcon;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igGuiAnimationTag? _loadingAnimation;
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _defaultMaterial = new();
        [FieldAttr(nst: 72, ctr: 72)] public igImage2? _image;
        [FieldAttr(nst: 80, ctr: 80)] public igGraphicsMaterial? _gamerMaterial;
        [FieldAttr(nst: 88, ctr: 88)] public igHandleMetaField _friendInfo = new();
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igGuiPlaceable? _behaviorPlace;
        [FieldAttr(nst: 104, ctr: 104, refCount: false)] public igNetTask? _getPictureTask;
    }
}
