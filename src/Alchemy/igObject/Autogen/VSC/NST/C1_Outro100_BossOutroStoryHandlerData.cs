namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class C1_Outro100_BossOutroStoryHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 52)] public EigEaseType _Ease_Type;
        [FieldAttr(nst: 56)] public EigEaseMode _Ease_Mode;
        [FieldAttr(nst: 64)] public igHandleMetaField _Localized_String = new();
    }
}
