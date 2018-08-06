using NUnit.Framework;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        //[Test]
        //public void Add_Item_to_Inventory()  
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual("+5 Dexterity Vest", items[0].Name);
        //}

        //[Test]
        //public void Quality_Degrades_Before_SellbyDate()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 9);
        //}

        //[Test]
        //public void Quality_Degrades_Twice_as_Fast_After_SellbyDate()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = -10, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 8);
        //}

        //[Test]
        //public void Quality_Can_Never_Be_Negative()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 0 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 0);
        //}

        //[Test]
        //public void Quality_Can_Never_Be_Greater_than_50()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 50);
        //}

        //[Test]
        //public void Aged_Brie_Increases_In_Quality_As_it_Ages()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 11);
        //}

        //[Test]
        //public void Sulfuras_Never_Decreases_In_Quality()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 10);
        //}

        //[Test]
        //public void Sulfuras_Never_Has_To_Be_Sold()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].SellIn, 10);
        //}

        //[Test]
        //public void BackstagePasses_Increase_Quality_1x_If_Sellin_Greater_Than_10()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 11);
        //}

        //[Test]
        //public void BackstagePasses_Increase_Quality_2x_If_Sellin_Between_5_And_10()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 12);
        //}

        //[Test]
        //public void BackstagePasses_Increase_Quality_3x_If_Sellin_Between_0_And_5()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 13);
        //}

        //[Test]
        //public void BackstagePasses_Decrease_Quality_To_0_If_Sellin_Equals_0()
        //{
        //    IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 0);
        //}

        //[Test]
        //public void Conjured_Decrease_Quality_Twice_As_Fast_As_Normal()
        //{
        //    IList<Item> items = new List<Item> { new Item() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
        //    GildedRose app = new GildedRose(items);
        //    app.UpdateQuality();
        //    Assert.AreEqual(items[0].Quality, 4);
        //}

        [Test]
        public void Add_Item_to_Inventory() 
        {
            IList<InheritItem> items = new List<InheritItem> { new StandardItem { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual("+5 Dexterity Vest", items[0].Name);
        }

        [Test]
        public void Quality_Degrades_Before_SellbyDate()
        {
            IList<InheritItem> items = new List<InheritItem> { new StandardItem { Name = "Elixir of the Mongoose", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 9);
        }

        [Test]
        public void Quality_Degrades_Twice_as_Fast_After_SellbyDate()
        {
            IList<InheritItem> items = new List<InheritItem> { new StandardItem { Name = "foo", SellIn = -10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 8);
        }

        [Test]
        public void Quality_Can_Never_Be_Negative()
        {
            IList<InheritItem> items = new List<InheritItem> { new StandardItem { Name = "foo", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 0);
        }

        [Test]
        public void Quality_Can_Never_Be_Greater_than_50()
        {
            IList<InheritItem> items = new List<InheritItem> { new MaturingItem { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 50);
        }

        [Test]
        public void Aged_Brie_Increases_In_Quality_As_it_Ages()
        {
            IList<InheritItem> items = new List<InheritItem> { new MaturingItem { Name = "Aged Brie", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 11);
        }

        [Test]
        public void Sulfuras_Never_Decreases_In_Quality()
        {
            IList<InheritItem> items = new List<InheritItem> { new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 80);
        }

        [Test]
        public void Sulfuras_Never_Has_To_Be_Sold()
        {
            IList<InheritItem> items = new List<InheritItem> { new LegendaryItem { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].SellIn, 10);
        }

        [Test]
        public void BackstagePasses_Increase_Quality_1x_If_Sellin_Greater_Than_10()
        {
            IList<InheritItem> items = new List<InheritItem> { new BackstageItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 11);
        }

        [Test]
        public void BackstagePasses_Increase_Quality_2x_If_Sellin_Between_5_And_10()
        {
            IList<InheritItem> items = new List<InheritItem> { new BackstageItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 12);
        }

        [Test]
        public void BackstagePasses_Increase_Quality_3x_If_Sellin_Between_0_And_5()
        {
            IList<InheritItem> items = new List<InheritItem> { new BackstageItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 13);
        }

        [Test]
        public void BackstagePasses_Decrease_Quality_To_0_If_Sellin_Equals_0()
        {
            IList<InheritItem> items = new List<InheritItem> { new BackstageItem { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 0);
        }

        [Test]
        public void Conjured_Decrease_Quality_Twice_As_Fast_As_Normal()
        {
            IList<InheritItem> items = new List<InheritItem> { new ConjuredItem() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            GildedRose app = new GildedRose(items);
            items[0].UpdateQuality();
            Assert.AreEqual(items[0].Quality, 4);
        }
    }
}
