namespace ZıplayanTop_2_
{
    
    public partial class Form1 : Form
    {
        
        private int genislik = 50;
        private int yükseklik = 50;
        private int ballPosX = 0;
        private int ballPosY = 0;
        private int moveStepX = 2;
        private int moveStepY = 2;

        // constructor
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint, true
               
               );

        }
            //Burda pozisyon-genişlik-yükseklik alıp topu çizdiren fonksiyon
        private void PaintCricle(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Black,
                ballPosX, ballPosY,
                genislik, yükseklik);
        }
            //topun x ve y eksenindeki hareketlerini hesaplayan fonksiyon
            // client size: form ölçülerini tutuyor 
            // topun pozisyonu movestepX kadar artıyor if bloku  top pozisyonu 0 dan küçükse veya top pozisyonu + genişlik client size dan büyük ise movestepX tersine eşitleniyor köşelere geldiğinde movestepX tam tersine eşitleniyor
            // 2. if de aynıları y ekseninde geçerli kılınıyor
        private void MoveBall(object sender, EventArgs e)
        {
            // update coordinates
            ballPosX += moveStepX;
            if (
                ballPosX < 0 ||
                ballPosX + genislik > this.ClientSize.Width
                )
            {
                
                // X eksenine top her çarptığında açılan form tanımladık
                moveStepX = -moveStepX;
                Form2 form = new Form2();
                form.Show();
            }

            ballPosY += moveStepY;
            if (
                ballPosY < 0 ||
                ballPosY + yükseklik > this.ClientSize.Height
                )
            {
                // Y eksenine top her çarptığında açılan form tanımladık
                moveStepY = -moveStepY;
                Form2 form = new Form2();
                form.Show();
            }

            // Form hareket ettikçe yenilenir
            // update painting
            this.Refresh();
        }
    }
}