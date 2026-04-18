namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Egypt_Enemy_WhiteMonkey_Vase_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 48)] public string? _String = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect = new();
    }
}
