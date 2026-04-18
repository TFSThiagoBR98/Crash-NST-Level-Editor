namespace Alchemy
{
    [ObjectAttr(nst: 184, align: 4, metaType: typeof(CVscComponentData))]
    public class Factory_Bear_Barrel_ManagerData : CVscComponentData
    {
        public enum EBarrelSupplyBehavior
        {
            LeftSideOnly = 0,
            RightSideOnly = 1,
            AlternateLeftAndRight = 2,
            AlternateRightAndLeft = 3,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _BoltPointVariable_id_aq7ccbz6_variable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _LeftLoadSpawner = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _RightLoadSpawner = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _BarrelList = new();
        [FieldAttr(nst: 72)] public EBarrelSupplyBehavior _BarrelSupplyBehavior;
        [FieldAttr(nst: 80)] public igHandleMetaField _SplineAttachBehaviorVariable_id_quzbqi2g_variable = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _SplineRotationMoverVariable_id_iczamq7i_variable = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _SplineVelocityMoverVariable_id_fk4l1hdk_variable = new();
        [FieldAttr(nst: 104)] public string? _LeftLift = null;
        [FieldAttr(nst: 112)] public string? _Reset = null;
        [FieldAttr(nst: 120)] public string? _RightGrab = null;
        [FieldAttr(nst: 128)] public string? _LeftGrab = null;
        [FieldAttr(nst: 136)] public string? _RightLift = null;
        [FieldAttr(nst: 144)] public float _Float_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 160)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 168)] public bool _Bool_0xa8;
        [FieldAttr(nst: 172)] public float _Float_0xac;
        [FieldAttr(nst: 176)] public bool _Bool_0xb0;
        [FieldAttr(nst: 177)] public bool _Bool_0xb1;
    }
}
