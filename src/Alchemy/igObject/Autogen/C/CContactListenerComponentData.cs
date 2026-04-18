namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CContactListenerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _disableCollisions;
    }
}
