namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8, metaType: typeof(CEntityMessage))]
    public class Scripts_MaterialOverrideComponentApplyMaterialMessage : CEntityMessage
    {
        public enum EAction
        {
            Apply = 0,
            Remove = 1,
        }

        [FieldAttr(nst: 56)] public string? MaterialIdentifier = null;
        [FieldAttr(nst: 64)] public EAction ApplyOrRemove;
    }
}
