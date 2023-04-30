using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Vandy.Items
{
	public class VandyPistol : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy's Revolver"); 
			Tooltip.SetDefault("Converts normal bullets into heroic bullets");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 0.1f;
			item.value = 22500;
			item.rare = 2; 
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 6.5f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 3, speedY * 3);
			position += offset;
			if (type == ProjectileID.Bullet)
            {
				type = mod.ProjectileType("HeroicBulletProjectile");
            }
			return true;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 55);
			recipe.AddIngredient(ItemID.SilverIngots, 55);
			recipe.AddIngredient(ItemID.DemoniteIngots, 55);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new Vector2(6, 0);
			return offset;
		}

	}
}