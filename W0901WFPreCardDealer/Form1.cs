namespace W0901WFPreCardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e)
        {
            Random r = new Random();

            int n = r.Next(52);

            Image? img = Properties.Resources.ResourceManager.GetObject(GetCardName(n)) as Image;

            Card1.Image = img;
        }

        private string GetCardName(int c)
        {
            string shape = "";
            switch (c / 13)
            {
                case 0: shape = "spades"; break;
                case 1: shape = "diamonds"; break;
                case 2: shape = "hearts"; break;
                case 3: shape = "clubs"; break;
                default: shape = "error"; break;
            }

            string number = "";
            switch (c % 13)
            {
                case 0: number = "ace"; break;
                case int n when (n > 0 && n < 10):
                    number = (c % 13 + 1).ToString(); break;
                case 10: number = "jack"; break;
                case 11: number = "queen"; break;
                case 12: number = "king"; break;
                default: number = "error"; break;
            }

            //return number + "_of_" + shape;
            //return string.Format("{0}_of_{1}", number, shape);
            return $"{number}_of_{shape}";
        }
    }
}