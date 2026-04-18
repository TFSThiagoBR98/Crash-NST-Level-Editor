namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CNetworkAnimationReplicaComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public CAnimationSubStatesDataTable? _synchronizedStates;
        [FieldAttr(nst: 32)] public bool _forceNotify;
        [FieldAttr(nst: 33)] public bool _disableOnDeath;
    }
}
