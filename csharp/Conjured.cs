namespace csharp
{
    class Conjured :InheritItem
    {
        public override void UpdateQuality()
        {
            Quality = Quality > 1 ? Quality - 2 : 0;
        }
    }
}
