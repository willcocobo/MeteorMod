
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Modding2.Items
{
    public class Paladin : ModNPC
    {
        private bool faceTarget;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("pala");

            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {

            npc.width = 36;
            npc.height = 90;

            npc.lifeMax = 300;

            npc.damage = 25;
            npc.defense = 15;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;

            npc.value = 10f;

            npc.knockBackResist = 0.05F;

            npc.aiStyle = 3;
            aiType = NPCID.Krampus;

            
            


        }


        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.DungeonNormal.Chance * 0.20f;
        }

        public override void NPCLoot()
        {
            
            {
                Item.NewItem(npc.position, mod.ItemType("ArmorScraps"), 2);
            }
        }
    }   

}



