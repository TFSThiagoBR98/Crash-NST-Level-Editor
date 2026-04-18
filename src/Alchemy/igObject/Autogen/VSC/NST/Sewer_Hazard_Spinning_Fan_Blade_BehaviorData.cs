namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Sewer_Hazard_Spinning_Fan_Blade_BehaviorData : CVscComponentData
    {
        public enum ENewEnum9_id_hdw1dx3p
        {
            NoFade = 0,
            Small = 1,
            Large = 2,
            Medium = 3,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _AkuAkuInvinciblityActive_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _AkuAkuInvinciblityActive_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 96)] public ENewEnum9_id_hdw1dx3p _NewEnum9_id_hdw1dx3p;
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Vfx_Effect_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Vfx_Effect_0x78 = new();
    }
}
