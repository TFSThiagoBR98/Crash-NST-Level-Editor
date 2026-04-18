namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 8)]
    public class CPhysicalEntityData : CGameEntityData
    {
        [FieldAttr(nst: 128, ctr: 124)] public uint _physicalEntityFlags = 128;
        [FieldAttr(nst: 132, ctr: 128)] public int _health = 100;
        [FieldAttr(nst: 136, ctr: 132)] public int _healthMax = 100;
        [FieldAttr(nst: 140, ctr: 136)] public EVulnerability _vulnerability = EVulnerability.eV_Invulnerable;
    }
}
