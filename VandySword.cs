using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class VandySword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("This is Vandy's extremely powerful sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 99;
			item.melee = true;
			item.width = 200;
			item.height = 215;
			item.useTime = 60;
			item.useAnimation = 60;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteIngots, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}