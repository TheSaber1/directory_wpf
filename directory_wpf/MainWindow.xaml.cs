using System.Windows;

namespace directory_wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void eklebutton_Click(object sender, RoutedEventArgs e)
        {
            
            string ad = textboxad.Text.Trim();
            string soyad = textboxsoyad.Text.Trim();
            string yas = textboxyas.Text.Trim();

            
            if (string.IsNullOrEmpty (ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(yas))
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();
                return;
            }

            if (!int.TryParse(yas, out int yasInt) || yasInt <= 0)
            {
                yaspopup yaspopup = new yaspopup();
                yaspopup.Owner = this;
                yaspopup.ShowDialog();
              
                return;
            }

            
            bilgilerlistbox.Items.Add($"Ad: {ad}, Soyad: {soyad}, Yaş: {yasInt}");

           
            textboxad.Clear();
            textboxsoyad.Clear();
            textboxyas.Clear();
        }

      
        private void kaldirbutton_Click(object sender, RoutedEventArgs e)
        {
           
            if (bilgilerlistbox.SelectedItem != null)
            {
                bilgilerlistbox.Items.Remove(bilgilerlistbox.SelectedItem);
            }
            else
            {
                kaldirpopup popup = new kaldirpopup();
                popup.Owner = this;
                popup.ShowDialog();
            }
        }
    }
}
