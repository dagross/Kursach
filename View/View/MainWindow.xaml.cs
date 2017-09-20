using Excell_Reader;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ExcelReader er = new ExcelReader();
            var rows = er.ExcelReaderTry().Tables[2].AsEnumerable().Skip(10);
            // DataView dw = new DataView(er.ExcelReaderTry().Tables[2].AsEnumerable().Skip(10));       
            
            DataTable dt = er.ExcelReaderTry().Tables[2];
            var ttt = dt.Rows.Cast<DataRow>().Skip(10).Take(20).Select(x =>
            new Table_1(Convert.ToInt32(x[0].ToString()), (string)x[2], (string)x[3])).ToList();
            DGTable.ItemsSource = ttt;





            //44 new DataView(er.ExcelReaderTry().Tables[2]);

            // DGTable.ItemsSource = st.AsEnumerable();
        }
    }
}
