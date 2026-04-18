namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CFadeSequenceData : igObject
    {
        [FieldAttr(nst: 16)] public float _holdDuration;
        [FieldAttr(nst: 20)] public float _fadeInDuration;
        [FieldAttr(nst: 24, refCount: false)] public CAudioFadeData? _fadeInAudioFadeData;
        [FieldAttr(nst: 32)] public igVscDelegateMetaField _holdComplete = new();
        [FieldAttr(nst: 48)] public igVscDelegateMetaField _fadeInComplete = new();
        [FieldAttr(nst: 64)] public CScopedScheduledFunction? _holdScheduledFunction;
    }
}
