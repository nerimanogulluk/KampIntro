using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer() { Id = 1, BirthYear = 1994, FirstName = "NERİMAN", LastName = "OĞULLUK", IdentityNumber = 12345 };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            Gamer gamer2 = new Gamer() { Id = 2, BirthYear = 2020, FirstName = "İREM", LastName = "OĞULLUK", IdentityNumber = 78940 };

            Game game1 = new Game() { Id = 2, GameName = "PUBG", GamePrice = 350 };
            Game game2 = new Game() { Id = 3, GameName = "MARIO", GamePrice = 50 };
            Game game3 = new Game() { Id = 4, GameName = "CS-GO", GamePrice = 150 };


            Campaign campaign1 = new Campaign() { CampaignName = "BAHAR KAMPANYASI", DiscountRate = 30, CampaignId = 1 };
            Campaign campaign2 = new Campaign() { CampaignName = "TATİL KAMPANYASI", DiscountRate = 35, CampaignId = 2 };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.UpDate(campaign1);
            campaignManager.UpDate(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game3, gamer2);
            salesManager.CampaignSales(game2, gamer1, campaign2);

        }
    }
}
