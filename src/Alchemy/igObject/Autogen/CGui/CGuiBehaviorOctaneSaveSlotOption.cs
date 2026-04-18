namespace Alchemy
{
    [ObjectAttr(ctr: 424, align: 8)]
    public class CGuiBehaviorOctaneSaveSlotOption : CGuiBehaviorSaveSlotOption
    {
        [FieldAttr(ctr: 264, refCount: false)] public igGuiAnimationTag? _emptyAnimation;
        [FieldAttr(ctr: 272, refCount: false)] public igGuiAnimationTag? _showDataAnimation;
        [FieldAttr(ctr: 280, refCount: false)] public igGuiPlaceable? _percentPlaceable;
        [FieldAttr(ctr: 288, refCount: false)] public igGuiPlaceable? _trophyCountPlaceable;
        [FieldAttr(ctr: 296, refCount: false)] public igGuiPlaceable? _ctrTokenCountPlaceable;
        [FieldAttr(ctr: 304, refCount: false)] public igGuiPlaceable? _keyCountPlaceable;
        [FieldAttr(ctr: 312, refCount: false)] public igGuiPlaceable? _relicCountPlaceable;
        [FieldAttr(ctr: 320, refCount: false)] public igGuiPlaceable? _portraitPlaceable;
        [FieldAttr(ctr: 328, refCount: false)] public igGuiPlaceable? _adventureTypePlaceable;
        [FieldAttr(ctr: 336, refCount: false)] public igGuiPlaceable? _adventureDifficultyPlaceable;
        [FieldAttr(ctr: 344)] public string? _classicText;
        [FieldAttr(ctr: 352)] public string? _nitroFueledText;
        [FieldAttr(ctr: 360, refCount: false)] public igGuiPlaceable? _invalidSaveTextPlaceable;
        [FieldAttr(ctr: 368)] public string? _emptySaveText;
        [FieldAttr(ctr: 376)] public string? _corruptSaveText;
        [FieldAttr(ctr: 384)] public string? _invalidOwnerSaveText;
        [FieldAttr(ctr: 392)] public igHandleMetaField _defaultLevelImage = new();
        [FieldAttr(ctr: 400)] public int _trophyCount;
        [FieldAttr(ctr: 404)] public int _keyCount;
        [FieldAttr(ctr: 408)] public int _ctrTokenCount;
        [FieldAttr(ctr: 412)] public int _relicCount;
        [FieldAttr(ctr: 416)] public int _progression;
        [FieldAttr(ctr: 420)] public int _relicGoldPlatinumProgression;
    }
}
