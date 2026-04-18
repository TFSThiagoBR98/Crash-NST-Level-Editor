namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class kart_velocity_to_fx_parameter : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _rnd_double_bolted_fx_from_listDatas = new();
    }
}
