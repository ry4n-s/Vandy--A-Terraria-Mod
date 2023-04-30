using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Vandy.Items
{
	public class VandyShotgun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy's Shotgun"); 
			Tooltip.SetDefault("Shoots a spread of bullets\nConverts normal bullets into heroic bullets");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.knockBack = 0.1f;
			item.value = 30000;
			item.rare = 1;
			item.UseSound = SoundID.Item36;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 5.5f;
			item.noMelee = true;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 1, speedY * 1);
			position += offset;
			if (type == ProjectileID.Bullet)
			{
				type = mod.ProjectileType("HeroicBulletProjectile");
			}
			for (var i = 0; i < Main.rand.Next(3,4); i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(25));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
        }
        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 65);
			recipe.AddIngredient(ItemID.SilverIngots, 65);
			recipe.AddIngredient(ItemID.DemoniteIngots, 65);
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