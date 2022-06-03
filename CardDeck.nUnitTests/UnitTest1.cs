namespace CardDeck.nUnitTests;

public class CardDeckTests
{
    private HIC_Tech.CardDeck deck1;
    private HIC_Tech.CardDeck deck2;

    [SetUp]
    public void Setup()
    {
        deck1 = new HIC_Tech.CardDeck();
        deck2 = new HIC_Tech.CardDeck();
    }

    [Test]
    public void CanShuffle()
    {
        deck1.Shuffle();

        Assert.That($"{deck2.Deck[0].FaceValue} {deck2.Deck[0].Suit}", Is.Not.EqualTo($"{deck1.Deck[0].FaceValue} {deck1.Deck[0].Suit}"));
    }

    [Test]
    public void CanSort()
    {
        deck1.Shuffle();
        deck1.Sort();

        Assert.That($"{deck2.Deck[0].FaceValue} {deck2.Deck[0].Suit}", Is.EqualTo($"{deck1.Deck[0].FaceValue} {deck1.Deck[0].Suit}"));
    }

    [Test]
    public void CanDealTopCard()
    {
        Assert.That($"{deck1.DealTopCard().FaceValue} {deck1.DealTopCard().Suit}", Is.EqualTo($"{deck1.Deck[0].FaceValue} {deck1.Deck[0].Suit}"));
    }
}
