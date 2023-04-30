using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class HeroicBullet : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heroic Bullet"); 
			Tooltip.SetDefault("Reflects off of walls");
		}

		public override void SetDefaults() 
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.knockBack = 2;
			item.value = 15000;
			item.rare = 1;
			item.consumable = true;
			item.shoot = mod.ProjectileType("HeroicBulletProjectile");
			item.ammo = AmmoID.Bullet;
			item.maxStack = 999;
			item.shootSpeed = 7.5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 40);
			recipe.AddIngredient(ItemID.SilverIngots, 40);
			recipe.AddIngredient(ItemID.DemoniteIngots, 40);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}