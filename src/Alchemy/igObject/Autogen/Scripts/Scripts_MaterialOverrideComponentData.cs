namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_MaterialOverrideComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_MaterialOverrideComponent_
    {
        [FieldAttr(nst: 40)] public List_1? Materials;
        [FieldAttr(nst: 48)] public bool ApplyMaterialsOnStart = true;
        [FieldAttr(nst: 56)] public string? MaterialIdentifier = null;
    }
}
