namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class common_MultiVolume_BoostData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Kart_Boost_Data = new();
    }
}
