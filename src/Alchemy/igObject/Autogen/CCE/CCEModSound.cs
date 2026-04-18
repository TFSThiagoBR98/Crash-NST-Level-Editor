namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CCEModSound : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public CModSoundEventData? mSoundData;
    }
}
