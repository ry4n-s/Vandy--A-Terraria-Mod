using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class BigVWarhammer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestSword"); 
			Tooltip.SetDefault("This is Big V's not so powerful warhammer.");
		}

		public override void SetDefaults() 
		{
			item.damage = 101;
			item.melee = true;
			item.width = 40;
			item.height = 80;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverIngots, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
