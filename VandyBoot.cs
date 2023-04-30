using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RiptideMod;

namespace Vandy.Accessories
{
	public class VandyBoot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy's New Kicks"); 
			Tooltip.SetDefault("Allows the user to run very fast");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.value = 42500;
			item.rare = 2;
			item.accessory = true;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.moveSpeed += 4.3f;
			player.accRunSpeed += 0.25f;
			player.GetModPlayer<WoodSlime>().slimeShoes = true;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 75);
			recipe.AddIngredient(ItemID.SilverIngots, 75);
			recipe.AddIngredient(ItemID.DemoniteIngots, 75);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}