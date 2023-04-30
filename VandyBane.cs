using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class VandyBane : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy's Bane"); 
			Tooltip.SetDefault("Shoots two arrows instantaneously");
		}


        public override void SetDefaults() 
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 20000;
			item.rare = 1; 
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.useAmmo = AmmoID.Arrow;
			item.shootSpeed = 6.5f;
			item.noMelee = true;
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
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 offset = new Vector2(speedX * 3, speedY * 3);
			position += offset;
			for (var i = 0; i < 2; i++)
            {
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.ToRadians(10*i));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
		public override Vector2? HoldoutOffset()
        {
			Vector2 offset = new Vector2(4,0);
			return offset;
        }

    }
}