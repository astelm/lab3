using Family.Model;
using System.Windows.Forms;

namespace Family.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            InitCommands();
            FamilyData = new FamilyData();
        }

        private void InitCommands()
        {
            NewFileCommand = new NewFileCommand(this);
            OpenFileCommand = new OpenFileCommand(this);
            SaveFileCommand = new SaveFileCommand(this);
            ExitCommand = new ExitCommand(this);
        }

        public void NewFile()
        {
            FamilyData.Clear();
        }
        public void OpenFile()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Xml file (*.xml*)|*.xml*";
            openFD.FilterIndex = 1;
            openFD.Multiselect = false;

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string path = openFD.FileName;
                FamilyData.LoadFromXML(path);
            }
        }
        public void SaveFile()
        {
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Xml file (*.xml*)|*.xml*";
            saveFD.FilterIndex = 1;

            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                string path = saveFD.FileName;

                if (!path.EndsWith(".xml"))
                {
                    path += ".xml";
                }

                FamilyData.SaveToXML(path);
            }
        }
        public void Exit()
        {

        }

        #region Commands
        public NewFileCommand NewFileCommand { get; private set; }
        public OpenFileCommand OpenFileCommand { get; private set; }
        public SaveFileCommand SaveFileCommand { get; private set; }
        public ExitCommand ExitCommand { get; private set; }
        #endregion

        public FamilyData FamilyData { get; private set; }
    }
}