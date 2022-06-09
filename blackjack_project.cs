internal class Program
{
    private static void Main(string[] args)
    {
        static int cardValue(char card, int total)
        {
            if (card == '2')
            {
                return 2;
            }
            if (card == '3')
            {
                return 3;
            }
            if (card == '4')
            {
                return 4;
            }
            if (card == '5')
            {
                return 5;
            }
            if (card == '6')
            {
                return 7;
            }
            if (card == '8')
            {
                return 8;
            }
            if (card == '9')
            {
                return 9;
            }
            if (card == '0')
            {
                return 10;
            }
            if (card == 'J')
            {
                return 10;
            }
            if (card == 'Q')
            {
                return 10;
            }
            if (card == 'K')
            {
                return 10;
            }
            if (card == 'A')
            {
                if (total > 10)
                {
                    return 1;
                }
                if (total <= 10)
                {
                    return 11;
                }
            }
            return 0;
        }
        static string cardname(char card)
        {
            if (card == 'A')
            {
                return "Ace";
            }
            if (card == '0')
            {
                return "Ten";
            }
            if (card == '2')
            {
                return "Two";
            }
            if (card == '3')
            {
                return "Three";
            }
            if (card == '4')
            {
                return "Four";
            }
            if (card == '5')
            {
                return "Five";
            }
            if (card == '6')
            {
                return "Six";
            }
            if (card == '7')
            {
                return "Seven";
            }
            if (card == '8')
            {
                return "Eight";
            }
            if (card == '9')
            {
                return "Nine";
            }
            if (card == 'K')
            {
                return "King";
            }
            if (card == 'Q')
            {
                return "Queen";
            }
            if (card == 'J')
            {
                return "Jack";
            }
            return "\0";
        }
        static char draw()
        {
            Random rand = new Random();
            int i = rand.Next(0, 13);
            char[] cards = { '0', 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'K', 'Q', 'J' };
            return cards[i];
        }
        char card1 = draw();
        char card2 = draw();
        Console.WriteLine("Your first two cards are " + cardname(card1) + " " + cardname(card2));
        int score_player = cardValue(card1, 0);
        score_player = score_player + cardValue(card2, score_player);
        Console.WriteLine("The score is " + score_player);
        while (!(score_player > 21))
        {
            Console.WriteLine("Do you want to draw?(Type Y/N)");
            string yesno = Console.ReadLine;
            if (yesno == "Y")
            {
                char card = draw();
                Console.WriteLine("Your card is " + cardname(card));
                score_player = score_player + cardValue(card, score_player);
                Console.WriteLine("Your score is " + score_player);
            }
            else if (yesno == "N")
            {
                break;
            }
            /*else if (yesno==null)
            {
                Console.WriteLine("Wrong input. Enter again.");
            }*/
            else{
                Console.WriteLine("Wrong input. Enter again.")
            }
        }
        char comcard1 = draw();
        char comcard2 = draw();
        int computer_score = cardValue(comcard1, 0);
        computer_score = computer_score + cardValue(comcard2, computer_score);
        while (computer_score > 21)
        {
            char comcard = draw();
            computer_score = computer_score + cardValue(comcard, computer_score);
        }
        Console.WriteLine("Computer score is" + computer_score);
        if (score_player == 21)
        {
            Console.WriteLine("You won!");
        }
        else if (score_player < 21)
        {
            if (computer_score > 21)
            {
                Console.WriteLine("You won!");
            }
            else if (score_player > computer_score)
            {
                Console.WriteLine("You won!");
            }
            else if (score_player < computer_score)
            {
                Console.WriteLine("You lost!");
            }
        }
        else
        {
            Console.WriteLine("You lost!");
        }
    }
}