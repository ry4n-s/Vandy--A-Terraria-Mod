using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Vandy.Items
{
	public class VandySpear : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Vandy Spear"); 
			Tooltip.SetDefault("");
		}
		public override void SetDefaults() 
		{
			item.CloneDefaults(ItemID.Spear);
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 28;
			item.useAnimation = 28;
			item.knockBack = 7;
			item.value = 5500;
			item.rare = 1; 
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("HeroicSpearProjectile");
		}

        public override bool CanUseItem(Player player)
        {
			return player.ownedProjectileCounts[mod.ProjectileType("HeroicSpearProjectile")] < 1;
        }

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldIngots, 35);
			recipe.AddIngredient(ItemID.SilverIngots, 35);
			recipe.AddIngredient(ItemID.DemoniteIngots, 35);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}