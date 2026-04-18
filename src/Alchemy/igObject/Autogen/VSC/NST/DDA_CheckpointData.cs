namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class DDA_CheckpointData : CVscComponentData
    {
        public enum ENewEnum12_id_kxje8bmu
        {
            Checkpoint = 0,
            AkuAku = 1,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Bool_Variable_0x28 = new();
        [FieldAttr(nst: 48)] public ENewEnum12_id_kxje8bmu _NewEnum12_id_kxje8bmu;
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Game_Bool_Variable_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_Handle_List = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _IsIlluminatedGameVar = new();
        [FieldAttr(nst: 112)] public int _Int;
    }
}
