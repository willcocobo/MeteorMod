using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modding2.Items
{
    public class Steel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.rare = 1;
            item.value = Item.sellPrice(silver: 25);
            item.maxStack = 99;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar, 2);
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddIngredient(mod.ItemType("ArmorScraps"));
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();

        }
    }
}


    