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

namespace UPDesckop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.workerReq);
        }

        public enum pages
        {
            auth,
            requests,
            changingReq,
            workerReq,
            histories,
            userAddReq,
            otchet
        }

        public void OpenPage(pages page, int? userId = null)
        {
            if (page == pages.auth)
                frame.Navigate(new Pages.Authorization(this));
            if (page == pages.requests)
                frame.Navigate(new Pages.RequestPage.Request(this));
            if (page == pages.changingReq)
                frame.Navigate(new Pages.RequestPage.RequestsChanging(this));
            if (page == pages.workerReq)
                frame.Navigate(new Pages.RequestPage.WorkerRequest(this));
            if (page == pages.histories)
                frame.Navigate(new Pages.HistoriesPage(this));
            if(page == pages.userAddReq)
                frame.Navigate(new Pages.RequestPage.AddRequest(this, userId));
            if (page == pages.otchet)
                frame.Navigate(new Pages.Otchet(this));
        }
    }
}