// See https://aka.ms/new-console-template for more information

using HIC_Tech;

CardDeck deck1 = new CardDeck();

//deck1.Shuffle();
//deck1.Sort();
//Console.WriteLine($"Dealt Cards: {deck1.DealTopCard()} - {deck1.DealTopCard()}");
foreach (Card card in deck1.Deck)
    Console.Write($"{card} ");

Console.ReadLine();