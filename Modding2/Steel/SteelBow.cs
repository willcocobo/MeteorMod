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
	class SteelBow : ModItem
	{

		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(12, 24);
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(silver: 25);

			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.Item5;

			item.noMelee = true;
			item.ranged = true;
			item.damage = 16;

			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 7.5f;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WhiteString);
			recipe.AddIngredient(mod.ItemType("Steel"), 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}