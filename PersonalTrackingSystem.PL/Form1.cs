using PersonalTrackingSystem.BL.Concrete;
using PersonalTrackingSystem.Entity.Concrete;

namespace PersonalTrackingSystem.PL
{
    public partial class Form1 : Form
    {
        private BaseManager<PersonalBasis> personalBasisManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Setting Managers
            personalBasisManager = new BaseManager<PersonalBasis>();
            #endregion

            #region Setting DGVs
            DGV_PersonalBasisModule.DataSource = personalBasisManager.GetAll();
            #endregion

        }

        #region PersonalBasisModule
        private void B_Enter_PersonalBasisModule_Click(object sender, EventArgs e)
        {
            int TIN;

            if (string.IsNullOrEmpty(TB_TIN_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_Name_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_Surname_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_City_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_BirthPlace_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_MothersName_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_FathersName_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_MaritalStatus_PersonalBasisModule.Text) &&
                string.IsNullOrEmpty(TB_PhotoPath_PersonalBasisModule.Text) &&
                int.TryParse(TB_TIN_PersonalBasisModule.Text, out TIN))
            {
                PersonalBasis pb = new()
                {
                    TurkishIdentificationNumber = TIN,
                    Name = TB_Name_PersonalBasisModule.Text,
                    Surname = TB_Surname_PersonalBasisModule.Text,
                    City = TB_City_PersonalBasisModule.Text,
                    BirthDate = DTP_BirthDate_PersonalBasisModule.Value,
                    BirthPlace = TB_BirthPlace_PersonalBasisModule.Text,
                    MothersName = TB_MothersName_PersonalBasisModule.Text,
                    FathersName = TB_FathersName_PersonalBasisModule.Text,
                    MaritalStatus = TB_MaritalStatus_PersonalBasisModule.Text
                };

                personalBasisManager.Add(pb);
            }
            else
            {
                MessageBox.Show("Bütün verilerin uygun bir biçimde girildiðinden emin olunuz.");
            }


        }

        private void B_PhotoPath_PersonalBasisModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_PhotoPath_PersonalBasisModule.Text = choofdlog.FileName;
            }
            #endregion
        }
    }
}