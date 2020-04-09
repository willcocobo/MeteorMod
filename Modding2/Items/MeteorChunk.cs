using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Modding2.Items
{
    class MeteorChunk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meteor Chunk");
        }

        public override void SetDefaults()
        {
            item.width = 6;
            item.height = 6;
            item.rare = 1;
            item.value = Item.sellPrice(silver: 25);
            item.maxStack = 999;
        }
        
        
    }
}
