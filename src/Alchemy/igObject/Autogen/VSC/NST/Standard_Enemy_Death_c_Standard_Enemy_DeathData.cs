namespace Alchemy
{
    [ObjectAttr(nst: 256, align: 4, metaType: typeof(CVscComponentData))]
    public class Standard_Enemy_Death_c_Standard_Enemy_DeathData : CVscComponentData
    {
        public enum ENewEnum3_id_4cdoc9cv
        {
            noOverride = 0,
            launchInCollisionDirection = 1,
            launchTowardsCamera = 2,
            launchTowardNearestEnemy = 3,
            LaunchTowardNearestCrate = 4,
            NoLaunchDeath = 5,
        }

        [FieldAttr(nst: 40)] public bool _LaunchDeathOnly;
        [FieldAttr(nst: 48)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DeathBySpinHandle_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _DeathByJumpHandle = new();
        [FieldAttr(nst: 72)] public string? _DeathByJumpString = null;
        [FieldAttr(nst: 80)] public string? _DeathBySpinString = null;
        [FieldAttr(nst: 88)] public string? _DeathDefault = null;
        [FieldAttr(nst: 96)] public string? _DeathJump = null;
        [FieldAttr(nst: 104)] public string? _DeathSpin = null;
        [FieldAttr(nst: 112)] public ENewEnum3_id_4cdoc9cv _NewEnum3_id_4cdoc9cv;
        [FieldAttr(nst: 116)] public bool _Bool_0x74;
        [FieldAttr(nst: 120)] public igHandleMetaField _Havok_Linear_Cast_Query_Parameters = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 136)] public string? _String = null;
        [FieldAttr(nst: 144)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 168)] public bool _Bool_0xa8;
        [FieldAttr(nst: 176)] public igHandleMetaField _Query_Filter_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Query_Filter_0xb8 = new();
        [FieldAttr(nst: 192)] public bool _Bool_0xc0;
        [FieldAttr(nst: 200)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _DeathBySpinHandle_0xd0 = new();
        [FieldAttr(nst: 216)] public float _Float;
        [FieldAttr(nst: 220)] public bool _Bool_0xdc;
        [FieldAttr(nst: 224)] public igHandleMetaField _Game_Int_Variable_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Game_Int_Variable_0xe8 = new();
        [FieldAttr(nst: 240)] public igHandleMetaField _Game_Int_Variable_0xf0 = new();
        [FieldAttr(nst: 248)] public igHandleMetaField _Game_Int_Variable_0xf8 = new();
    }
}
