namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Update_Material_Override_On_AttackData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Fx_Material_Redirect_Table_0x28 = new();
        [FieldAttr(nst: 48)] public bool _Bool_0x30;
        [FieldAttr(nst: 49)] public bool _Bool_0x31;
        [FieldAttr(nst: 56)] public igHandleMetaField _SpawnedEntity = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Fx_Material_Redirect_Table_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Fx_Material_Redirect_Table_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Fx_Material_Redirect_Table_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect = new();
    }
}
