namespace Labirint
{
    public partial class Form2 : Form
    {
       public Form2()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            // you also can create the event KeyDown from proprieties
        }


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (label5.Location == label7.Location)
                    label5.Location = label6.Location;   
                
            }
            if (e.KeyCode == Keys.Down)
            {
               if (label5.Location==label6.Location)
                   label5.Location = label7.Location;
               
            }
            if (e.KeyCode == Keys.Right)
            {
                if (label5.Location.Y == 60 && label5.Location.X == 0)
                     label5.Location=label6.Location;
            }
            if (e.KeyCode == Keys.Left)
            {
                if (label5.Location == label6.Location)
                    label5.Location = label27.Location;
            }
        }
    }
}
