namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CFootIKHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public bool _lockFeetAdvancedControl = true;
        [FieldAttr(nst: 84)] public float _lockFeetStationaryDelay = 0.25f;
    }
}
