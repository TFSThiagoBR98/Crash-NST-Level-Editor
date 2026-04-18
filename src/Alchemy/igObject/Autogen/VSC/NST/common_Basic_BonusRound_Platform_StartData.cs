namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Basic_BonusRound_Platform_StartData : CVscComponentData
    {
        public enum ENewEnum5_id_b8ggnmc2
        {
            MoveFinished = 0,
            EnterTrigger = 1,
            None = 2,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _EntityTagVariable_id_4dvdsghy_variable = new();
        [FieldAttr(nst: 48)] public ENewEnum5_id_b8ggnmc2 _NewEnum5_id_b8ggnmc2;
        [FieldAttr(nst: 52)] public bool _Bool;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _EntityTagVariable_id_dc99te9h_variable = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Game_Bool_Variable = new();
    }
}
