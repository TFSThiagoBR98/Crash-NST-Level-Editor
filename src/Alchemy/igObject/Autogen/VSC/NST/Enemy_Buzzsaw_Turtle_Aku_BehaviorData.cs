namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Buzzsaw_Turtle_Aku_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 48)] public string? _AkuDeath = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Count = new();
    }
}
