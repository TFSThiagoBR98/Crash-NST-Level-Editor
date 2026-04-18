namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class L311_DinoMight_Gem_Intro_CameraFixData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Camera_Box_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Camera_Box_0x38 = new();
    }
}
