using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Vandy.Items
{
	public class HeroicPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Pickaxe"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 5000;
			item.rare = 1; 
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.pick = 53;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 15);
			recipe.AddIngredient(ItemID.SilverIngots, 15);
			recipe.AddIngredient(ItemID.DemoniteIngots, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}