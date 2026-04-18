namespace Alchemy
{
    [ObjectAttr(nst: 296, align: 8)]
    public class CGuiBehaviorCrashSaveSlotOption : CGuiBehaviorSaveSlotOption
    {
        [FieldAttr(nst: 184, refCount: false)] public igGuiAnimationTag? _emptyAnimation;
        [FieldAttr(nst: 192, refCount: false)] public igGuiPlaceable? _percentPlaceable;
        [FieldAttr(nst: 200, refCount: false)] public igGuiPlaceable? _levelNamePlaceable;
        [FieldAttr(nst: 208, refCount: false)] public igGuiPlaceable? _levelImagePlaceable;
        [FieldAttr(nst: 216, refCount: false)] public igGuiPlaceable? _lifeCountPlaceable;
        [FieldAttr(nst: 224, refCount: false)] public igGuiPlaceable? _gemCountPlaceable;
        [FieldAttr(nst: 232, refCount: false)] public igGuiPlaceable? _keyCountPlaceable;
        [FieldAttr(nst: 240, refCount: false)] public igGuiPlaceable? _crystalCountPlaceable;
        [FieldAttr(nst: 248, refCount: false)] public igGuiPlaceable? _relicCountPlaceable;
        [FieldAttr(nst: 256, refCount: false)] public igGuiPlaceable? _invalidSaveTextPlaceable;
        [FieldAttr(nst: 264)] public string? _emptySaveText = "EMPTY";
        [FieldAttr(nst: 272)] public string? _corruptSaveText = "CORRUPT SAVE";
        [FieldAttr(nst: 280)] public string? _invalidOwnerSaveText = "ACCESS DENIED";
        [FieldAttr(nst: 288)] public igHandleMetaField _defaultLevelImage = new();
    }
}
