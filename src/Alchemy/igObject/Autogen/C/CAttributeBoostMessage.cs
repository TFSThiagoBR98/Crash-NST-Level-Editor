namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class CAttributeBoostMessage : CEntityMessage
    {
        public enum EAddRemoveOperation
        {
            eARO_Add = 0,
            eARO_Remove = 1,
        }

        [FieldAttr(nst: 56)] public CCharacterAttributeList? _attributeBoosts;
        [FieldAttr(nst: 64)] public EAddRemoveOperation _addRemoveOperation;
    }
}
