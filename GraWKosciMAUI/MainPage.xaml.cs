namespace GraWKosciMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int pointsSum = 0;
        private void PlayTheGame(object sender, EventArgs e)
        {
            int points = 0;
            int check = 0;

            Random dice = new Random();
            int[] rolled = new int[5];

            rolled[0] = dice.Next(1, 7);
            Dice1.Source = "score" + rolled[0] + ".jpg";
            rolled[1] = dice.Next(1, 7);
            Dice2.Source = "score" + rolled[1] + ".jpg";
            rolled[2] = dice.Next(1, 7);
            Dice3.Source = "score" + rolled[2] + ".jpg";
            rolled[3] = dice.Next(1, 7);
            Dice4.Source = "score" + rolled[3] + ".jpg";
            rolled[4] = dice.Next(1, 7);
            Dice5.Source = "score" + rolled[4] + ".jpg";

            for (int z = 1; z <= 6; z++)
            {
                for (int j = 0; j < rolled.Length; j++)
                {
                    if (rolled[j] == z)
                    {
                        check += 1;
                    }
                }
                if (check > 1)
                {
                    points += z * check;
                }
                check = 0;
            }
            pointsSum += points;
            RecentPoints.Text = "Wynik tego losowania: " + points;
            SumPoints.Text = "Wynik gry: " + pointsSum;

        }
        private void ResetTheScore(object sender, EventArgs e)
        {
            Dice1.Source = "unnown.jpg";
            Dice2.Source = "unnown.jpg";
            Dice3.Source = "unnown.jpg";
            Dice4.Source = "unnown.jpg";
            Dice5.Source = "unnown.jpg";
            pointsSum = 0;
            RecentPoints.Text = "Wynik tego losowania: 0";
            SumPoints.Text = "Wynik gry: 0";
        }
    }

}
