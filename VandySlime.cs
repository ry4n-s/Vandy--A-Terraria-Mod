using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System;

namespace Vandy.Enemies
{
    public class VandySlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dr. Vandy");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 15;
            npc.damage = 11;
            npc.defense = 3;
            npc.lifeMax = 22;
            npc.value = 500f;
            npc.aiStyle = 1;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            aiType = NPCID.GreenSlime;
            animationType = NPCID.GreenSlime;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.2f;
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter++;
            if (npc.frameCounter >= 20)
            {
                npc.frameCounter = 0;
            }
            npc.frame.Y = (int)npc.frameCounter / 10 * frameHeight;
        }
        public override void NPCLoot()
        {
            Random rnd = new Random();

            int rnd2 = rnd.Next(0, 100);

            if ( rnd2 <= 50)
            {
                Item.NewItem(npc.getRect(), ItemID.GangstaHat, Main.rand.Next(1, 2));
            }
            Item.NewItem(npc.getRect(), ItemID.Acorn, Main.rand.Next(5, 10));
        }
    }



}