namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CRaceNetworkedTriggerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CEntity? _listener;
        [FieldAttr(ctr: 24)] public bool _globalTrigger;
    }
}
