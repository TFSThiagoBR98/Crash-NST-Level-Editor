namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CStackCameraBehaviorStates : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igStringStringHashTable? _activators;
        [FieldAttr(nst: 24, ctr: 24)] public igStringStringHashTable? _excludeActivators;
    }
}
