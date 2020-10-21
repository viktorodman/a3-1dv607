﻿
namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : INewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            a_dealer.DealCard(a_player, true);
            a_dealer.DealCard(a_dealer, true);
            a_dealer.DealCard(a_player, true);
            a_dealer.DealCard(a_dealer, false);

            return true;
        }
    }
}
