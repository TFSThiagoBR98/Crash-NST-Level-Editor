namespace Alchemy
{
    [ObjectAttr(nst: 416, align: 4, metaType: typeof(CVscComponentData))]
    public class common_CrateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _AddToStreak;
        [FieldAttr(nst: 41)] public bool _CanBeDestroyed;
        [FieldAttr(nst: 42)] public bool _CameraFollow;
        [FieldAttr(nst: 43)] public bool _IsAkuAkuCrate;
        [FieldAttr(nst: 44)] public bool _AkuAku_Bounces;
        [FieldAttr(nst: 45)] public bool _BouncesPlayer;
        [FieldAttr(nst: 48)] public igHandleMetaField _BounceDamage = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Crate = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Special = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Chaser = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _IronCrate = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _AwarenessEntity = new();
        [FieldAttr(nst: 96)] public float _AkuAkuDamageDelay;
        [FieldAttr(nst: 104)] public igHandleMetaField _AkuAkuIlluminated = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _IsTouching = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _HavokConstraint = new();
        [FieldAttr(nst: 136)] public int _BounceCount;
        [FieldAttr(nst: 140)] public igVec3fMetaField _IronArrowHighHeight = new();
        [FieldAttr(nst: 152)] public igVec3fMetaField _ArrowHeight = new();
        [FieldAttr(nst: 164)] public igVec3fMetaField _IronArrowHeight = new();
        [FieldAttr(nst: 176)] public bool _Bool_0xb0;
        [FieldAttr(nst: 184)] public igHandleMetaField _Game_Bool_Variable_0xb8 = new();
        [FieldAttr(nst: 192)] public bool _Bool_0xc0;
        [FieldAttr(nst: 200)] public igHandleMetaField _Entity_Tag_0xc8 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _Entity_0xd0 = new();
        [FieldAttr(nst: 216)] public bool _Bool_0xd8;
        [FieldAttr(nst: 224)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xe8 = new();
        [FieldAttr(nst: 240)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xf0 = new();
        [FieldAttr(nst: 248)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xf8 = new();
        [FieldAttr(nst: 256)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x100 = new();
        [FieldAttr(nst: 264)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x108 = new();
        [FieldAttr(nst: 272)] public igHandleMetaField _Sound_0x110 = new();
        [FieldAttr(nst: 280)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 296)] public igHandleMetaField _Sound_0x128 = new();
        [FieldAttr(nst: 304)] public igHandleMetaField _Entity_Tag_0x130 = new();
        [FieldAttr(nst: 312)] public bool _Bool_0x138;
        [FieldAttr(nst: 313)] public bool _Bool_0x139;
        [FieldAttr(nst: 320)] public igHandleMetaField _Entity_Tag_0x140 = new();
        [FieldAttr(nst: 328)] public igHandleMetaField _Entity_Tag_0x148 = new();
        [FieldAttr(nst: 336)] public igHandleMetaField _Entity_Tag_0x150 = new();
        [FieldAttr(nst: 344)] public igHandleMetaField _Entity_0x158 = new();
        [FieldAttr(nst: 352)] public igHandleMetaField _DebugUpdateChannelVariable_id_wkhn8tmd_variable = new();
        [FieldAttr(nst: 360)] public bool _Bool_0x168;
        [FieldAttr(nst: 368)] public igHandleMetaField _Game_Bool_Variable_0x170 = new();
        [FieldAttr(nst: 376)] public bool _Bool_0x178;
        [FieldAttr(nst: 384)] public igHandleMetaField _Entity_Tag_0x180 = new();
        [FieldAttr(nst: 392)] public igHandleMetaField _Entity_Tag_0x188 = new();
        [FieldAttr(nst: 400)] public igHandleMetaField _Sound_0x190 = new();
        [FieldAttr(nst: 408)] public igHandleMetaField _Entity_Tag_0x198 = new();
    }
}
