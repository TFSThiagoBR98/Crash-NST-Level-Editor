namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CPlayerTriggerRadiusComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _radius = 1.0f;
        [FieldAttr(nst: 28)] public bool _allPlayersMustEnter;
        [FieldAttr(nst: 29)] public bool _allPlayersMustExit;
    }
}
