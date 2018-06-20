using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        readonly IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void DecreaseSellDate(Item item)
        {
            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        public void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                if (item.Name == "Conjured Mana Cake")
                {
                    item.Quality = item.Quality - 2;
                }
                else if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality--;
                }
            }
        }

        public void IncreaseQuality(Item item)
        {
            item.Quality++;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecreaseQuality(Items[i]);
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        IncreaseQuality(Items[i]);

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    IncreaseQuality(Items[i]);
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    IncreaseQuality(Items[i]);
                                }
                            }
                        }
                    }
                }

                DecreaseSellDate(Items[i]);

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    DecreaseQuality(Items[i]);
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            IncreaseQuality(Items[i]);
                        }
                    }
                }
            }
        }
    }
}
