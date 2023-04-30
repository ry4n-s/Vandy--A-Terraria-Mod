using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Vandy.Items
{
	public class VandyChainGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy's Chaingun"); 
			Tooltip.SetDefault("Isn't very effective\nMaybe try something else...");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.knockBack = 0.1f;
			item.value = 500;
			item.rare = 1;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 7.5f;
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
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
			Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			return false;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinIngots, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			Vector2 offset = new Vector2(6, 4);
			return offset;
		}

	}
}