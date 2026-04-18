namespace Alchemy
{
    [ObjectAttr(ctr: 248, align: 8)]
    public class CGuiBehaviorSoundVolumeOptionSlider : CGuiBehaviorSoundVolumeOption
    {
        [FieldAttr(ctr: 232, refCount: false)] public igGuiPlaceable? _sliderBar;
        [FieldAttr(ctr: 240)] public float _maximumExtent;
    }
}
