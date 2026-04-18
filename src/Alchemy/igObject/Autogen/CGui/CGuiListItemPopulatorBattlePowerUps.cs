namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CGuiListItemPopulatorBattlePowerUps : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public CPowerUpTypeMaterialHandleHashTable? _powerUpMaterials;
    }
}
