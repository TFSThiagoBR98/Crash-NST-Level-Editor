namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_GenerateRipplesComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_GenerateRipplesComponent_
    {
        [FieldAttr(nst: 40)] public float RippleRadius = 10.0f;
        [FieldAttr(nst: 44)] public float RippleIntesity = 1.0f;
        [FieldAttr(nst: 48)] public Vector3? Offset;
        [FieldAttr(nst: 56)] public float SpawnRadius;
        [FieldAttr(nst: 60)] public bool Hideable;
    }
}
