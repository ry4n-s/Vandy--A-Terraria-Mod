using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace Vandy.Items
{
	public class VandyStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy's Staff"); 
			Tooltip.SetDefault("Casts a ball of true heroism");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.damage = 24;
			item.mana = 4;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 29;
			item.useAnimation = 29;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 32000;
			item.rare = 1; 
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("HeroicProjectile");
			item.shootSpeed = 5f;
			item.noMelee = true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 offset = new Vector2(speedX * 6, speedY * 6);
			position += offset;
			return true;
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