namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CGuiKeyboardMenuList : igDataList
    {
        [FieldAttr(nst: 24)] public igMemoryRef<igEnumMetaField> _data = new();
    }
}
