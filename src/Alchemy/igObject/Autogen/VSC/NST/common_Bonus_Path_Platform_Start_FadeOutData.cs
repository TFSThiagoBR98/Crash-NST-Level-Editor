namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Bonus_Path_Platform_Start_FadeOutData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Spline_Event = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 64)] public float _Float;
        [FieldAttr(nst: 68)] public igVec3fMetaField _Vec_3F = new();
    }
}
