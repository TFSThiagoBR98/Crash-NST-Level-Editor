namespace Alchemy
{
    [ObjectAttr(40, 8)]
    public class igObjectList : igObjectList<igObject> { }

    public abstract class igObjectList<T> : igDataList where T : igObject
    {
        [FieldAttr(24)] public igMemoryRef<T> _data = new();
    }

    public abstract class igDataList : igContainer
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _count;
        [FieldAttr(nst: 20, ctr: 16)] public int _capacity;

        public override void Write(IgzWriter writer)
        {
            CachedFieldAttr? dataField = AttributeUtils.GetAttributes(GetType()).GetField("_data");

            if (dataField?.GetValue(this) is IMemoryRef mem)
            {
                _count = _capacity = mem.Count;
            }

            base.Write(writer);
        }
    }
}
