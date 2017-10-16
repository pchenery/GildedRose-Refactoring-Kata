using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void Add_Item_to_Inventory()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual("foo", items[0].Name);
        }

        [Test]
        public void Quality_Degrades_Before_SellbyDate()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 9);
        }

        [Test]
        public void Quality_Degrades_Twice_as_Fast_After_SellbyDate()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 8);
        }

        [Test]
        public void Quality_Can_Never_Be_Negative()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 0);
        }

        [Test]
        public void Quality_Can_Never_Be_Greater_than_50()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 50);
        }

        [Test]
        public void Aged_Brie_Increases_In_Quality_As_it_Ages()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 11);
        }

        [Test]
        public void Sulfuras_Never_Decreases_In_Quality()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 10);
        }

        [Test]
        public void Sulfuras_Never_Has_To_Be_Sold()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].SellIn, 10);
        }

        [Test]
        public void BackstagePasses_Increase_Quality_1x_If_Sellin_Greater_Than_10()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 11);
        }

        [Test]
        public void BackstagePasses_Increase_Quality_2x_If_Sellin_Between_5_And_10()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 12);
        }

        [Test]
        public void BackstagePasses_Increase_Quality_3x_If_Sellin_Between_0_And_5()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 13);
        }

        [Test]
        public void BackstagePasses_Decrease_Quality_To_0_If_Sellin_Equals_0()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(items[0].Quality, 0);
        }
    }
}
