namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CVehicleCollisionExtraResponseBase : igObject
    {
        public enum EDamageScalingMethod
        {
            eDSM_None = 0,
            eDSM_ScaleByWeight = 1,
            eDSM_ScaleByModifiedWeight = 2,
        }

        [FieldAttr(nst: 16, ctr: 16)] public CDamageData? _damage;
        [FieldAttr(nst: 24, ctr: 24)] public EDamageScalingMethod _damageScaling;
    }
}
