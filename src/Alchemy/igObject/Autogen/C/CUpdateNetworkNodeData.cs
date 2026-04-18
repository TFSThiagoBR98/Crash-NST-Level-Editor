namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CUpdateNetworkNodeData : igObject
    {
        [FieldAttr(nst: 16)] public igVscDelegateMetaField _onUpdate = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 40)] public float _interval;
    }
}
