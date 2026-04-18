namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CStringKartCustomizationDecalListTable : igHashTable<string, CKartCustomizationDecalList>
    {
        [FieldAttr(ctr: 64)] public CKartCustomizationDecal? _noDecal;
    }
}
