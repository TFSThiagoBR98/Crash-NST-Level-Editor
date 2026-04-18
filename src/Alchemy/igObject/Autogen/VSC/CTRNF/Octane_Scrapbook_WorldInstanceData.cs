namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class Octane_Scrapbook_WorldInstanceData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Game_Sound_Music_Settings = new();
    }
}
