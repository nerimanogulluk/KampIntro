﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
        class SalesManager : ISalesService
        {
            public void Sales(Game game, Gamer gamer)
            {
                Console.WriteLine(gamer.FirstName + game.GameName + " oyununu aldı.");
            }
            public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
            {
                Console.WriteLine(gamer.FirstName + campaign.CampaignName + " ile " + game.GameName + " oyununu aldı.");
            }
        }
}
