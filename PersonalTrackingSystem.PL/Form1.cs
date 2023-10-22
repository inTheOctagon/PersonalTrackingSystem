using Microsoft.IdentityModel.Tokens;
using PersonalTrackingSystem.BL.Concrete;
using PersonalTrackingSystem.Entity.Concrete;

namespace PersonalTrackingSystem.PL
{
    public partial class Form1 : Form
    {
        private BaseManager<PersonalBasis> personalBasisManager;
        private BaseManager<PersonalFile> personalFileManager;
        private BaseManager<PersonalEducation> personalEducationManager;
        private BaseManager<PersonalPosition> personalPositionManager;
        private List<Panel> panels;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panels = new List<Panel>() { P_PersonalBasisModule, P_PersonalFileModule };

            #region Setting Managers
            personalBasisManager = new BaseManager<PersonalBasis>();
            personalFileManager = new BaseManager<PersonalFile>();
            personalEducationManager = new BaseManager<PersonalEducation>();
            personalPositionManager = new BaseManager<PersonalPosition>();
            #endregion

            #region Setting DGVs
            DGV_PersonalBasisModule.DataSource = personalBasisManager.GetAll();
            DGV_PersonalFileModule.DataSource = personalFileManager.GetAll();
            DGV_PersonalEducationModule.DataSource = personalEducationManager.GetAll();
            DGV_PersonalPositionModule.DataSource = personalPositionManager.GetAll();
            #endregion

            FillComboBoxes();

            panels[0].BringToFront();
        }

        #region PersonalBasisModule
        private void B_Enter_PersonalBasisModule_Click(object sender, EventArgs e)
        {
            int TIN;

            if (!string.IsNullOrEmpty(TB_TIN_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_Name_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_Surname_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_City_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_BirthPlace_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_MothersName_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_FathersName_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_MaritalStatus_PersonalBasisModule.Text) &&
                !string.IsNullOrEmpty(TB_PhotoPath_PersonalBasisModule.Text) &&
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

                DGV_PersonalBasisModule.DataSource = personalBasisManager.GetAll();

                FillComboBoxes();
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
        }

        private void B_NextPage_PersonalBasisModule_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
        }

        #endregion

        #region PersonalFileModule
        private void B_Enter_PersonalFileModule_Click(object sender, EventArgs e)
        {
            int PID;

            if (!string.IsNullOrEmpty(TB_Address_PersonalFileModule.Text) &&
                !string.IsNullOrEmpty(TB_HealthRecord_PersonalFileModule.Text) &&
                !string.IsNullOrEmpty(TB_CriminalRecord_PersonalFileModule.Text) &&
                !string.IsNullOrEmpty(TB_DrivingLicence_PersonalFileModule.Text) &&
                !string.IsNullOrEmpty(TB_CorporateAgreement_PersonalFileModule.Text) &&
                !string.IsNullOrEmpty(TB_CV_PersonalFileModule.Text) &&
                int.TryParse(CB_ID_PersonalFileModule.Text, out PID)
                )

            {
                PersonalFile pf = new()
                {
                    PersonalID = PID,

                    ResidenceAddress = TB_Address_PersonalFileModule.Text,
                    HealthReportPath = TB_HealthRecord_PersonalFileModule.Text,
                    CriminalRecordPath = TB_CriminalRecord_PersonalFileModule.Text,
                    DrivingLicencePath = TB_DrivingLicence_PersonalFileModule.Text,
                    CorporateAgreementPath = TB_CorporateAgreement_PersonalFileModule.Text,
                    CVPath = TB_CV_PersonalFileModule.Text,
                };

                personalFileManager.Add(pf);
                DGV_PersonalFileModule.DataSource = personalBasisManager.GetAll();
            }
            else
            {
                MessageBox.Show("Bütün verilerin uygun bir biçimde girildiðinden emin olunuz.");
            }
        }

        private void B_HealthRecord_PersonalFileModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_HealthRecord_PersonalFileModule.Text = choofdlog.FileName;
            }
        }

        private void B_CriminalRecord_PersonalFileModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_CriminalRecord_PersonalFileModule.Text = choofdlog.FileName;
            }
        }

        private void B_DrivingLicence_PersonalFileModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_DrivingLicence_PersonalFileModule.Text = choofdlog.FileName;
            }
        }

        private void B_CorporateAgreement_PersonalFileModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_CorporateAgreement_PersonalFileModule.Text = choofdlog.FileName;
            }
        }

        private void B_CV_PersonalFileModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_CV_PersonalFileModule.Text = choofdlog.FileName;
            }
        }

        private void B_PreviousPage_PersonalFileModule_Click(object sender, EventArgs e)
        {
            panels[0].BringToFront();
        }

        private void B_NextPage_PersonalFileModule_Click(object sender, EventArgs e)
        {
            panels[2].BringToFront();
        }
        #endregion

        #region HelperMethods
        private void FillComboBoxes()
        {
            var allPersonel = personalBasisManager.GetAll();

            foreach (var personal in allPersonel)
            {
                CB_ID_PersonalFileModule.Items.Add(personal.ID);
            }
        }

        #endregion

        #region PersonalEducationModule
        private void B_CertificatePath_PersonalEducationModule_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                TB_CertificatePath_PersonalEducationModule.Text = choofdlog.FileName;
            }
        }

        private void B_Enter_PersonalEducationModule_Click(object sender, EventArgs e)
        {
            int PID;

            if (!string.IsNullOrEmpty(TB_InstutionName_PersonalEducationModule.Text) &&
                !string.IsNullOrEmpty(TB_EducationType_PersonalEducationModule.Text) &&
                !string.IsNullOrEmpty(TB_CertificatePath_PersonalEducationModule.Text) &&
                int.TryParse(CB_ID_PersonalEducationModule.Text, out PID)
                )

            {
                PersonalEducation pe = new()
                {
                    PersonalID = PID,
                    InstitutionName = TB_InstutionName_PersonalEducationModule.Text,
                    EducationType = TB_EducationType_PersonalEducationModule.Text,
                    CertificatePath = TB_CertificatePath_PersonalEducationModule.Text
                };

                personalEducationManager.Add(pe);
                DGV_PersonalEducationModule.DataSource = personalBasisManager.GetAll();
            }
            else
            {
                MessageBox.Show("Bütün verilerin uygun bir biçimde girildiðinden emin olunuz.");
            }
        }

        private void B_PreviousPage_PersonalEducationModule_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
        }

        private void B_NextPage_PersonalEducationModule_Click(object sender, EventArgs e)
        {
            panels[3].BringToFront();
        }

        #endregion

        private void B_Enter_PersonalPositionModule_Click(object sender, EventArgs e)
        {
            int PID;
            decimal salary;

            if (!string.IsNullOrEmpty(TB_Department_PersonalPositionModule.Text) &&
                !string.IsNullOrEmpty(TB_Job_PersonalPositionModule.Text) &&
                !string.IsNullOrEmpty(TB_Salary_PersonalPositionModule.Text) &&
                decimal.TryParse(TB_Salary_PersonalPositionModule.Text, out salary) &&
                int.TryParse(CB_ID_PersonalPositionModule.Text, out PID)
                )

            {
                PersonalPosition pp = new()
                {
                    PersonalID = PID,
                    Job = TB_InstutionName_PersonalEducationModule.Text,
                    Salary = salary,
                    Department = TB_Department_PersonalPositionModule.Text
                };

                personalPositionManager.Add(pp);
                DGV_PersonalPositionModule.DataSource = personalPositionManager.GetAll();
            }
            else
            {
                MessageBox.Show("Bütün verilerin uygun bir biçimde girildiðinden emin olunuz.");
            }
        }

        private void B_PreviousPage_PersonalPositionModule_Click(object sender, EventArgs e)
        {
            panels[2].BringToFront();
        }

        private void B_NextPage_PersonalPositionModule_Click(object sender, EventArgs e)
        {
            panels[4].BringToFront();
        }
    }
}