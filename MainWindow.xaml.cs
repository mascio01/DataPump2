using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mascella.nicolo._5g.DataPump2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Avvia_Click(object sender, RoutedEventArgs e)
        {
            Classi tutti = new Classi();

            string t = "INSERT INTO Classe(idclasse,nomeclasse,Specializzazione,Articolazione,CodiceMinisteriale,Aula,Sede,IdDocente)" + "\n" + "VALUES";

            StreamWriter sw = new StreamWriter("Classi.sql");
            foreach (var classe in tutti)
            {
                t = t + "(" + "'" + classe.idclasse + "'" + ", " + "'" + classe.nomeclasse + "'" + ", " + "'" + classe.Specializzazione + "'" + ", " + "'" +classe.Articolazione + "'" + ", " + "'" +classe.CodiceMinisteriale + "'" + ", " + "'" +classe.Aula + "'" + ", " + "'" +classe.Sede + "'" + ", " + "'" +classe.IdDocente + "'" + ")," + "\n";
            }
            sw.Write(t.TrimEnd('\n').TrimEnd(','));
            sw.Close();
            output.Text = "Creazione File Completata";
        }
    }
}
