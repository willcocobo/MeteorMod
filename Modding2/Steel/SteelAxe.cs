using IL.Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Modding2.Items
{
	public class SteelAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("ExampleSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic Axe.");
		}

		public override void SetDefaults()
		{
			item.Size = new Vector2(56);
			item.rare = ItemRarityID.Blue;

			item.useStyle = ItemUseStyleID.SwingThrow;

			item.autoReuse = true;
			item.useTime = 17;
			item.useAnimation = 25;
			item.useTurn = true;
			item.UseSound = SoundID.Item1;

			item.melee = true;
			item.damage = 14;
			item.knockBack = 3.25f;

			item.axe = 60;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient (mod.ItemType("Steel"), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}