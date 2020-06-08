using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFilesAPI;

namespace TestiAppMF
{
    public partial class Popup : Form
    {
        private MFilesServerApplication localServer = new MFilesServerApplication();
        
        public Popup()
        {
            InitializeComponent();
        }




        private Form1 mainForm;



        // Otetaan täällä popupin käyttöön parent form, jotta voidaan mm. enabloida napit vault connectionin muodostamisen jälkeen
        public Popup(Form1 callingForm)
        {
            mainForm = callingForm;
            InitializeComponent();
        }

        private void Popup_Load(object sender, EventArgs e)
        {
            this.loginTypesList.SelectedText = "Tämänhetkinen Windows-käyttäjä";
            
            this.localServer.Connect(
                MFAuthType.MFAuthTypeLoggedOnWindowsUser);

            VaultsOnServer onlineVaults = localServer.GetOnlineVaults();

            StringBuilder sb = new StringBuilder();

            foreach (VaultOnServer oneVault in onlineVaults)
            {
                vaultList.Items.Add(oneVault.Name + " (" + oneVault.GUID + ")");
                
            }

            
        }



        private void OkButton_Click(object sender, EventArgs e)
        {

            if (vaultList.SelectedItem != null)
            {
                
                mainForm.ClearLists();



                var mfServerApplication = new MFilesServerApplication();

                string selectedGUID = ExtractGUID(vaultList.SelectedItem.ToString());

                if (mainForm.vault != null)
                {
                    mainForm.vault.LogOutSilent();
                }

                if (this.loginTypesList.SelectedIndex == 0)
                {
                    string username = this.username.Text;
                    string password = this.password.Text;

                    // Connect to a local server using the default parameters (TCP/IP, localhost),
                    // using an M-Files user for authentication.
                    // https://www.m-files.com/api/documentation/latest/index.html#MFilesAPI~MFilesServerApplication~Connect.html
                    mfServerApplication.Connect(
                                    MFAuthType.MFAuthTypeSpecificMFilesUser,
                                    UserName: username,
                                    Password: password);
                    
                    // Note: this will except if the vault is not found.
                    mainForm.vault = mfServerApplication.LogInToVault(selectedGUID);
                }
                else
                {
                    mfServerApplication.Connect(MFAuthType.MFAuthTypeLoggedOnWindowsUser);
                    mainForm.vault = mfServerApplication.LogInToVault(selectedGUID);
                }

                mainForm.SetSelectedVaultLabel(vaultList.SelectedItem.ToString());
                mainForm.Populoi();
                mainForm.ButtonsEnabled(true);

                this.Close();
            }
        }
        

        private string ExtractGUID(string input)
        {
            string GUID = input.Substring(input.Length - 39, 38);

            return GUID;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loginTypesList.SelectedItem.ToString() == "Tämänhetkinen Windows-käyttäjä")
            {
                this.password.Enabled = false;
                this.username.Enabled = false;
            }
            else if (loginTypesList.SelectedItem.ToString() == "M-Files-käyttäjä")
            {
                this.password.Enabled = true;
                this.username.Enabled = true;
            }
        }

        private void VaultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vaultList.SelectedItem != null)
            {
                this.loginTypesList.Enabled = true;
                
            }
        }
    }
}
