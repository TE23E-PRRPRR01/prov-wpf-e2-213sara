using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prov_wpf_e2_213sara;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    string aktivitet = txbAktivitet.Text;
    string langd = txbLangd.Text;
    int tid = TryParse(out, int langd);
    string intensitet = txbIntensitet.Text;

    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        if (int langd = 5 - 180)
        {
        }
        else
        {
            MessageBox.Show("Felaktig längd! Ange ett heltal mellan 5 och 180.");
        }
        if (string aktivitet = "")
        {
            MessageBox.Show("Aktivitet får inte vara tom!");
        }
        if (string intensitet = ("Låg", "Medel", "Hög");)
        {
        }
        else if (string intesitet == "")
        {
            MessageBox.Show("Felaktig intensitet! Välj Låg, Medel eller Hög.");
        }


    }

    private void KlickSpara(object sender, RoutedEventArgs e)
    {
        List<string> passLista =[ langd ","  aktivitet "," intensitet];
    }

    private void KlickVisaPass(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Passet" {aktivitet} "är sparat!");
    }

    private void KlickVisaStatistik(object sender, RoutedEventArgs e)
    {
         MessageBox.Show()
    }
}