namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8, metaType: typeof(CEntityMessage))]
    public class Scripts_ChangeSkinMessage : CEntityMessage
    {
        [FieldAttr(nst: 56)] public bool ActivateBaseSkin = true;
    }
}
