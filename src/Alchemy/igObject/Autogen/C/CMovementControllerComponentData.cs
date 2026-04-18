namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CMovementControllerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public CBaseMovementControllerList? _controllerList;
        [FieldAttr(nst: 32, ctr: 24)] public bool _autoChangeHavokType = true;
        [FieldAttr(nst: 33, ctr: 25)] public bool _forcePositionReplication;
        [FieldAttr(nst: 36, ctr: 28)] public float _maxVelocity = 1000.0f;
    }
}
