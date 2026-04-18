namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_AddRemovableComponentComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_AddRemovableComponentComponent_
    {
        [FieldAttr(nst: 40)] public CEntityComponentData? ComponentToAttach;
        [FieldAttr(nst: 48)] public float ComponentDuration;
        [FieldAttr(nst: 56)] public CEntityMessage? RemovalMessage;
    }
}
