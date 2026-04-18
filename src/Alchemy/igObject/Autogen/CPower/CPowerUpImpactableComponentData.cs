namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CPowerUpImpactableComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public i16 _powerUpImpactsAllowed;
        [FieldAttr(ctr: 18)] public i16 _shouldDestroyPowerUpOnImpact;
    }
}
