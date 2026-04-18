namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CBehaviorSyncComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public bool _enableNetworkReplication = true;
        [FieldAttr(nst: 32)] public string? _layerName = null;
    }
}
