namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_BounceManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _EntityTagVariable_id_cyap1b80_variable = new();
        [FieldAttr(nst: 48)] public float _pitchIncrement;
        [FieldAttr(nst: 52)] public float _startingPitch;
        [FieldAttr(nst: 56)] public float _maximumPitch;
        [FieldAttr(nst: 64)] public igHandleMetaField _DefaultJumpSound = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _BounceSound = new();
        [FieldAttr(nst: 80)] public igVec2fMetaField _BaseXYVelocity = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Count = new();
    }
}
