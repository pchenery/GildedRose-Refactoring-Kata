namespace csharp
{
    class Cheese : InheritItem
    {
        public override void UpdateQuality()
        {
            if (Quality < 50)
            {
                Quality++;
            }
        }
    }
}
