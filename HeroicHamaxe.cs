using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class HeroicHamaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Hamaxe"); 
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 8500;
			item.rare = 1; 
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.axe = 12;
			item.hammer = 45;
			item.useTurn = true;
			item.scale = 1.2f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 20);
			recipe.AddIngredient(ItemID.SilverIngots, 20);
			recipe.AddIngredient(ItemID.DemoniteIngots, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}