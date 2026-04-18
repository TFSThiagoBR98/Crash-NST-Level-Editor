namespace Alchemy
{
    [ObjectAttr(ctr: 400, align: 8)]
    public class CGuiBehaviorOctaneSaveMenu : CGuiBehaviorSaveMenu
    {
        [FieldAttr(ctr: 320, refCount: false)] public igGuiAnimationTag? _OctaneMainMenuIntroAnimation;
        [FieldAttr(ctr: 328, refCount: false)] public igGuiAnimationTag? _OctaneMainMenuIdleAnimation;
        [FieldAttr(ctr: 336, refCount: false)] public igGuiAnimationTag? _OctaneMainMenuOutroAnimation;
        [FieldAttr(ctr: 344, refCount: false)] public igGuiAnimationTag? _OctaneMainMenuPreDialogAnimation;
        [FieldAttr(ctr: 352, refCount: false)] public igGuiAnimationTag? _OctaneMainMenuPostDialogAnimation;
        [FieldAttr(ctr: 360, refCount: false)] public igGuiAnimationTag? _OctaneInGameIntroAnimation;
        [FieldAttr(ctr: 368, refCount: false)] public igGuiAnimationTag? _OctaneInGameIdleAnimation;
        [FieldAttr(ctr: 376, refCount: false)] public igGuiAnimationTag? _OctaneInGameOutroAnimation;
        [FieldAttr(ctr: 384, refCount: false)] public igGuiAnimationTag? _OctaneInGamePreDialogAnimation;
        [FieldAttr(ctr: 392, refCount: false)] public igGuiAnimationTag? _OctaneInGamePostDialogAnimation;
    }
}
