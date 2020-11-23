using Solidare.Core;
using System.Windows.Forms;

namespace Solidare.Feature.Profile
{
    public partial class ProfileForm : Form, View<ProfileController>
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileController CreateController()
        {
            return new ProfileController();
        }
    }
}
