using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = "Adresser.txt";

        
        List<Addressbook> listOfContacts = new List<Addressbook>(); 
        List<int> indexOfSearchHit = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {  
            Addressbook addressbook = new Addressbook(textBoxName.Text, textBoxStreetAddress.Text, textBoxPostalNumber.Text, 
                textBoxCity.Text, textBoxTelephone.Text, textBoxEmail.Text);

            List<string> temporaryListSaveFunction = new List<string>(); 

            string checkFieldsSave = addressbook.CheckInfo();

            if (checkFieldsSave == "")
            {
                
                var name = (addressbook.Name = textBoxName.Text);
                var street = (addressbook.StreetAddress = textBoxStreetAddress.Text);
                var postNo = (addressbook.PostalNumber = textBoxPostalNumber.Text);
                var city = (addressbook.City = textBoxCity.Text);
                var phone = (addressbook.Telephone = textBoxTelephone.Text);
                var email = (addressbook.Email = textBoxEmail.Text);
                temporaryListSaveFunction.Add("\n" + name + "," + street + "," + postNo + "," + city + "," + phone + "," + email);
                var showInListBox = name + ", " + city + " - Ny kontakt!";

                MessageBox.Show("Sparat!");

                listBoxResult.Items.Add(showInListBox);

                File.AppendAllText(filePath, string.Join(Environment.NewLine, temporaryListSaveFunction));

                var clearEmptyLines = File.ReadAllLines(filePath).Where(x => !string.IsNullOrWhiteSpace(x)); 
                File.WriteAllLines(filePath, clearEmptyLines);

            }
            else
            {
                MessageBox.Show("Följande information saknas: " + checkFieldsSave + "\n\nVänligen fyll i alla fält.");
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Addressbook addressbook = new Addressbook(textBoxName.Text, textBoxStreetAddress.Text, textBoxPostalNumber.Text,
                textBoxCity.Text, textBoxTelephone.Text, textBoxEmail.Text);

            List<string> temporaryListUpdateFunction = File.ReadAllLines(filePath).ToList(); 

            int contactIndexUpdate = 0;

            for (int i = 0; i < indexOfSearchHit.Count; i++) 
            {
                contactIndexUpdate = indexOfSearchHit[i];
            }

            string checkFieldsSave = addressbook.CheckInfo();

            if (checkFieldsSave == "")
            {
                temporaryListUpdateFunction.RemoveAt(contactIndexUpdate); 

                var name = (addressbook.Name = textBoxName.Text);
                var street = (addressbook.StreetAddress = textBoxStreetAddress.Text);
                var postNo = (addressbook.PostalNumber = textBoxPostalNumber.Text);
                var city = (addressbook.City = textBoxCity.Text);
                var phone = (addressbook.Telephone = textBoxTelephone.Text);
                var email = (addressbook.Email = textBoxEmail.Text);
                string updateContactString = (name + "," + street + "," + postNo + "," + city + "," + phone + "," + email);


                temporaryListUpdateFunction.Insert(contactIndexUpdate, updateContactString); 

                File.WriteAllLines(filePath, temporaryListUpdateFunction.ToArray()); 

                MessageBox.Show("Kontakt uppdaterad!");
            }
            else
            {
                MessageBox.Show("Följande information saknas: " + checkFieldsSave + "\n\nVänligen fyll i alla fält.");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<string> temporaryListDeleteFunction = File.ReadAllLines(filePath).ToList(); 

            if (MessageBox.Show("Är du säker på att du vill ta bort kontakten?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contactIndexDelete = 0;    

                for (int i = 0; i < indexOfSearchHit.Count; i++) 
                {
                    contactIndexDelete = indexOfSearchHit[i];
                }
                temporaryListDeleteFunction.RemoveAt(contactIndexDelete); 
                File.WriteAllLines(filePath, temporaryListDeleteFunction.ToArray()); 

                listBoxResult.Items.Clear();

                MessageBox.Show("Kontakten är borttagen", " ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kontakten är inte borttagen", " ", MessageBoxButtons.OK);
            }

        }

        private void labelClearFields_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxStreetAddress.Clear();
            textBoxPostalNumber.Clear();
            textBoxCity.Clear();
            textBoxTelephone.Clear();
            textBoxEmail.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listOfContacts.Clear();
            listBoxResult.Items.Clear();

            Addressbook addressbook = new Addressbook(textBoxName.Text, textBoxStreetAddress.Text, textBoxPostalNumber.Text,
                textBoxCity.Text, textBoxTelephone.Text, textBoxEmail.Text);

            string[] toList = new string[2];
            toList[0] = (addressbook.Name = textBoxName.Text);
            toList[1] = (addressbook.City = textBoxCity.Text);

            string checkFieldsSearch = addressbook.SearchCheckFields(); 

            if (checkFieldsSearch == "")
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    string line; 
                    while ((line = reader.ReadLine()) != null) 
                    {
                        string[] add = line.Split(","); 
                        listOfContacts.Add(new Addressbook(add[0], add[1], add[2], add[3], add[4], add[5]));
                    }
                    
                    foreach (var item in listOfContacts)
                    {
                        var searchHitName = listOfContacts.Where(x => x.Name.ToLower().Contains(toList[0]) && x.City.ToLower().Contains(toList[1])).ToList();

                        for (int i = 0; i < searchHitName.Count; i++)
                        {
                            listBoxResult.Items.Add(searchHitName[i].Name + "," + searchHitName[i].City + "," + searchHitName[i].Email);

                        }

                        if (listBoxResult.Items.Count == 0)
                        {
                            MessageBox.Show("Inga sparade adresser matchar din sökning.");

                        }

                        break;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Följande information måste anges vid sökning: " + checkFieldsSearch + "\n\nVänligen fyll i alla fält.");
            }
            
        }

        private void listBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            Addressbook addressbook = new Addressbook(textBoxName.Text, textBoxStreetAddress.Text, textBoxPostalNumber.Text,
                textBoxCity.Text, textBoxTelephone.Text, textBoxEmail.Text);

            string[] moveItems = listBoxResult.SelectedItem.ToString().Split(","); 

            foreach (var item in listOfContacts)  
            {
                var result = listOfContacts.FindIndex(x => x.Name.Equals(moveItems[0]) && x.City.Equals(moveItems[1]) && x.Email.Equals(moveItems[2]));
                indexOfSearchHit.Add(result);
            }


            int contactIndex = 0;

            for (int i = 0; i < indexOfSearchHit.Count; i++)
            {
                contactIndex = indexOfSearchHit[i];
            }


            textBoxName.Text = listOfContacts[contactIndex].Name;
            textBoxStreetAddress.Text = listOfContacts[contactIndex].StreetAddress;
            textBoxPostalNumber.Text = listOfContacts[contactIndex].PostalNumber;
            textBoxCity.Text = listOfContacts[contactIndex].City;
            textBoxTelephone.Text = listOfContacts[contactIndex].Telephone;
            textBoxEmail.Text = listOfContacts[contactIndex].Email;

        }

        private void labelClearList_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
        }
    }
}
