namespace GissaTal_Inlamning;

public partial class Form1 : Form
{
    private int slumptal;
private int antalForsok;

public Form1()
{
    InitializeComponent();
    Random random = new Random();
    slumptal = random.Next(1, 101);
    antalForsok = 0;
}

}


