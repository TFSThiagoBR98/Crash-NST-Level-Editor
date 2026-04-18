namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CVehicleHornComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public string? _hornSoundStart = null;
        [FieldAttr(nst: 32)] public string? _hornSoundLoop = null;
        [FieldAttr(nst: 40)] public string? _hornSoundEnd = null;
        [FieldAttr(nst: 48)] public EXBUTTON _hornButton = EXBUTTON.L3;
        [FieldAttr(nst: 52)] public bool _isHornOverride;
    }
}
