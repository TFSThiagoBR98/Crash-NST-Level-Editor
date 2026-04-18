namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class play_anim_simpleData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public string? _String = null;
        [FieldAttr(ctr: 40)] public bool _Bool;
    }
}
