namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class A155_Nitro_Court_RainRipplesData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Water_Simulation_Settings = new();
    }
}
