namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CButtonListenerInstance : igObject
    {
        [FieldAttr(ctr: 16)] public CTimer? _cooldownTimer;
        [FieldAttr(ctr: 24)] public bool _currentlyAttacking;
    }
}
