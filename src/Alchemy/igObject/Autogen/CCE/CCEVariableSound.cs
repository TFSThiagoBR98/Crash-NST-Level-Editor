namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CCEVariableSound : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public CWeightedSoundList? _weightedSoundList;
        [FieldAttr(nst: 88)] public bool _findSoundsOnThisVehicleDriver;
    }
}
