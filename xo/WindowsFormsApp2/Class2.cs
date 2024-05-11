namespace WindowsFormsApp2
{
   public class playerWin
    {
        int score;
        public int Score
        {
            set { score = value; }
            get { return score; }
        }
        public playerWin() { }
        public playerWin(int score)
        {
            this.score = score;
        }


    }
    public class playerDraw : playerWin
    {
        public playerDraw(int score):base(score) { }
        
    }

}
