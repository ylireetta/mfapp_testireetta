using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MFilesAPI;
using MFiles.VAF.Common;
using MFiles.VAF.Configuration;


namespace TestiAppMF
{
    public partial class Form1 : Form
    {
        // Vault-objekti perustetaan popup-ikkunassa, mistä se välitetään main formille
        public Vault vault;

        
        public Form1()
        {
            InitializeComponent();
        }

        // Enabloidaan disabloidut napit sen jälkeen, kun vault connection on muodostettu popupin kautta
        public void ButtonsEnabled(bool yesOrNo)
        {
            hakuButton.Enabled = yesOrNo;
            pdLuokkaMapButton.Enabled = yesOrNo;
            kayttamattomatPDtButton.Enabled = yesOrNo;
        }

        public void SetSelectedVaultLabel(string vaultName)
        {
            this.selectedVault.Text = vaultName;
        }


        public void ClearLists()
        {
            // Tyhjennetään ominaisuus- ja luokkalistoihin tehdyt valinnat ja listojen sisältö
            // Tyhjennetään tulosboksin sisältö

            this.pdLista.SelectedIndex = -1;
            this.luokkaSelect.SelectedIndex = -1;
            this.textBox1.Clear();
            this.pdLista.Items.Clear();
            this.luokkaSelect.Items.Clear();
        }


        private void HaeButton_Click(object sender, EventArgs e)
        {
            if (luokkaSelect.SelectedItem != null)
            {
                int selectedClass = ParseToNumber(luokkaSelect.SelectedItem.ToString());


                if (selectedClass != -1)
                {
                    var searchResults = Search(selectedClass);

                    var associatedPropertyDefs = vault.ClassOperations.GetObjectClass(selectedClass).AssociatedPropertyDefs;
                    

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Valittuun luokkaan kuuluvia kohteita on varastossa " + searchResults.Count + " kappaletta.");
                    sb.AppendLine();
                    sb.AppendLine("Luokan ominaisuudet:");
                    sb.AppendLine();


                    foreach (AssociatedPropertyDef assDef in associatedPropertyDefs)
                    {
                        string pdName = vault.PropertyDefOperations.GetPropertyDef(assDef.PropertyDef).Name;

                        if (assDef.PropertyDef == 0 || assDef.PropertyDef > 1000)
                        {
                            sb.AppendLine(assDef.PropertyDef + " (" + pdName + ")");
                        }
                        
                    }


                    textBox1.Text = sb.ToString();

                }


            }
        }




        
        private ObjectSearchResults Search(int luokkaID)
        {

            var searchBuilder = new MFSearchBuilder(vault);

            searchBuilder.Class(luokkaID);

            searchBuilder.Deleted(false);

            var searchResults = searchBuilder.Find();


            return searchResults;
        }




        private int ParseToNumber(string input)
        {

            // Selitys: poista inputista kaikki merkit, jotka eivät ole numeroita välillä 0-9
            // ^ = negaatio; tarkoitetaan merkkejä, jotka eivät sisälly hakasulkeissa määriteltyyn merkkiryhmään

            // if-blokki: jos valittu luokka on sisäänrakennettu Tehtävänanto tai Raportti, ei korvata niiden ID:ssä olevaa miinusmerkkiä
            // else-blokki: jos valitun luokan ID joku muu kuin -100 tai -101, poistetaan stringistä viivat
            // Luokkien nimessä saattaa olla tavuviivoja, joten ne täytyy poistaa. Muutoin luokan ID käsitetään negatiiviseksi, ja ohjelma feilaa haun

            if (input.Contains("-100") || input.Contains("-101"))
            {
                input = Regex.Replace(input, "[^0-9-]", "");
            }
            else
            {
                input = Regex.Replace(input, "[^0-9]", "");
            }

            

            if (Int32.TryParse(input, out int returnValue))
            {
                return returnValue;
            } else
            {
                return -1;
            }
            
        }

        
        

        public void Populoi()
        {
            if (vault != null)
            {
                if (luokkaSelect.Items.Count > 0)
                {
                    luokkaSelect.Items.Clear();
                }
                

                ObjectClasses objClasses = GetObjectClassesFromVault();

                foreach (ObjectClass objClass in objClasses)
                {
                    // adding the name of classes into the listbox
                    luokkaSelect.Items.Add(objClass.Name + " (ID: " + objClass.ID + ")");
                }



                PropertyDefs allPDs = vault.PropertyDefOperations.GetPropertyDefs();

                foreach (PropertyDef onePD in allPDs)
                {
                    pdLista.Items.Add(onePD.Name + " (ID: " + onePD.ID + ")");
                }

                // Aakkosjärjestykseen
                luokkaSelect.Sorted = true;
                pdLista.Sorted = true;
            }
            
        }





        private void KayttamattomatPDtButton_Click(object sender, EventArgs e)
        {
            if (vault != null)
            {
                List<int> pdList = new List<int>();

                PropertyDefs allPDs = vault.PropertyDefOperations.GetPropertyDefs();

                // Lisätään listaan kaikki varaston property defit, jotka eivät ole sisäänrakennettuja
                foreach (PropertyDef onePD in allPDs)
                {
                    if (onePD.ID > 1000 && !onePD.Name.Contains("Omistaja"))
                    {
                        pdList.Add(onePD.ID);
                    }

                }

                ObjectClasses objClasses = GetObjectClassesFromVault();

                foreach (ObjectClass objClass in objClasses)
                {
                    AssociatedPropertyDefs assDefs = objClass.AssociatedPropertyDefs;

                    // Jos pd on liitetty johonkin luokkaan, otetaan se pois pdListasta
                    foreach (AssociatedPropertyDef oneDef in assDefs)
                    {
                        if (pdList.Contains(oneDef.PropertyDef))
                        {
                            pdList.Remove(oneDef.PropertyDef);
                        }
                    }
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Ominaisuudet, joita ei ole liitetty mihinkään luokkaan:");
                sb.AppendLine();

                foreach (int defID in pdList)
                {
                    string defName = vault.PropertyDefOperations.GetPropertyDef(defID).Name;
                    sb.AppendLine(defID + " (" + defName + ")");
                }


                textBox1.Text = sb.ToString();
            }
            


            
        }




        private void PdLuokkaMapButton_Click(object sender, EventArgs e)
        {
            if (pdLista.SelectedItem != null)
            {
                int selectedPD = ParseToNumber(pdLista.SelectedItem.ToString());

                if (selectedPD != -1)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Ominaisuus " + pdLista.SelectedItem.ToString() + " löytyy seuraavista luokista:");
                    sb.AppendLine();

                    ObjectClasses objClasses = GetObjectClassesFromVault();

                    foreach(ObjectClass oneClass in objClasses)
                    {
                        AssociatedPropertyDefs associatedPropertyDefs = oneClass.AssociatedPropertyDefs;

                        if (AssDefsContainPropertyDef(associatedPropertyDefs, selectedPD))
                        {
                            sb.AppendLine(oneClass.ID + " (" + oneClass.Name + ")");
                        }
                    }
                    
                    textBox1.Text = sb.ToString();
                }

            }
        }


        private ObjectClasses GetObjectClassesFromVault()
        {
            ObjectClasses allClasses = new ObjectClasses();

            if (vault != null)
            {
                

                // Listing all object types
                ObjTypesAdmin objTypesAdmin = vault.ObjectTypeOperations.GetObjectTypesAdmin();

                foreach (ObjTypeAdmin obj in objTypesAdmin)
                {

                    // with the object type ID i'll get all classes
                    ObjectClasses objClasses = vault.ClassOperations.GetObjectClasses(obj.ObjectType.ID);

                    foreach (ObjectClass oneClass in objClasses)
                    {
                        allClasses.Add(-1, oneClass);
                    }

                }
            }
            
            return allClasses;
            
        }

        private bool AssDefsContainPropertyDef(AssociatedPropertyDefs assDefs, int propertyID)
        {
            bool returnValue = false;
            foreach(AssociatedPropertyDef oneAssDef in assDefs)
            {
                if (oneAssDef.PropertyDef.Equals(propertyID))
                {
                    returnValue = true;
                    break;
                }
            }

            return returnValue;
        }

        private void UusiYhteysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Avataan uusi popup-ikkuna, jolle välitetään tämä form this:in avulla
            var formPopup = new Popup(this);
            formPopup.ShowDialog();
            
            
        }

        private void LopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
