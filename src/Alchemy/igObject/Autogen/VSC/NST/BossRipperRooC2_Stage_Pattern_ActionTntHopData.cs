namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class BossRipperRooC2_Stage_Pattern_ActionTntHopData : CVscComponentData
    {
        public enum ENewEnum14_id_r08p8mb8
        {
            TurnToDestination = 0,
            TurnToPlayer = 1,
            MadTwirlToPlayer = 2,
        }

        public enum ENewEnum15_id_i77zfglu
        {
            CleverJumpVariant1 = 0,
            CleverJumpVariant2 = 1,
            CleverJumpVariantLeanLeft = 2,
            CleverJumpVariantLeanRight = 3,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _Waypoint = new();
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 76)] public bool _Bool;
        [FieldAttr(nst: 80)] public ENewEnum14_id_r08p8mb8 _NewEnum14_id_r08p8mb8;
        [FieldAttr(nst: 84)] public ENewEnum15_id_i77zfglu _NewEnum15_id_i77zfglu;
    }
}
