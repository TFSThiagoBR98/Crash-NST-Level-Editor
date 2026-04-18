namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 4)]
    public class CGuiListItemPopulatorCustomizationGrid : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 12)] public ECustomizationType _currentCustomizationType;
        [FieldAttr(ctr: 16)] public ECustomizationType _desiredCustomizationType;
        [FieldAttr(ctr: 20)] public int _currentFilterIndex;
        [FieldAttr(ctr: 24)] public int _desiredFilterIndex;
        [FieldAttr(ctr: 28)] public bool _enteredGridList;
    }
}
