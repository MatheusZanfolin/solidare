using Solidare.Core;
using System.Windows.Forms;

namespace Solidare.Feature.Menu
{
    public partial class MenuForm : Form, View<MenuController>
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuController CreateController()
        {
            return new MenuController();
        }
    }
}
