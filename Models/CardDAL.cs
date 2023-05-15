using RestSharp;



namespace DeckOfCardsAPI.Models
{
    public class CardDAL
    {
        public Deck GetDeck()
        {
            string URL = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            RestClient client = new RestClient(URL);
            RestRequest request = new RestRequest();
            Deck response = client.Get<Deck>(request);

            return response; 
        }
        public Deck GetHand(string id)
        {
            string URL = $"https://deckofcardsapi.com/api/deck/{id}/draw/?count=5";
            RestClient client = new RestClient(URL);
            RestRequest request = new RestRequest();
            Deck response = client.Get<Deck>(request);

            return response;
        }
        
    }
}
