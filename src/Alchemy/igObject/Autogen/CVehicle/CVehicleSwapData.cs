namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CVehicleSwapData : igObject
    {
        [FieldAttr(nst: 16)] public EXBUTTON _swapButton = EXBUTTON.L1;
        [FieldAttr(nst: 20)] public float _swapCooldown = 2.5f;
        [FieldAttr(nst: 24)] public float _swapRequestDuration = 2.0f;
        [FieldAttr(nst: 32)] public igHandleMetaField _playerSwapEffect = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _swapSound = new();
    }
}
