using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adressbok
{
    public class Addressbook
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string PostalNumber { get; set; }
        public string City { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Addressbook(string name, string street, string postalnumber, string postalcity, string telephone, string email)
        {
            this.Name = name;
            this.StreetAddress = street;
            this.PostalNumber = postalnumber;
            this.City = postalcity;
            this.Telephone = telephone;
            this.Email = email;
        }


        public string CheckInfo() // kollar att alla fält är ifyllda
        {
            string checkedInfo = "";

            if (Name == "" || StreetAddress == "" || PostalNumber == "" || City == "" || Telephone == "" || Email == "")
            {
                string[] infoMessage = new string[5];
                for (int i = 0; i < infoMessage.Length; i++)
                {
                    if (Name == "")
                    {
                        infoMessage[i] += "\nNamn";
                    }
                    if (StreetAddress == "")
                    {
                        infoMessage[i] += "\nGatuadress";
                    }
                    if (PostalNumber == "")
                    {
                        infoMessage[i] += "\nPostnummer";
                    }
                    if (City == "")
                    {
                        infoMessage[i] += "\nPostort";
                    }
                    if (Telephone == "")
                    {
                        infoMessage[i] += "\nTelefonnummer";
                    }
                    if (Email == "")
                    {
                        infoMessage[i] += "\nEmail";
                    }
                    return "\n" + infoMessage[i];
                }
            }
            return checkedInfo;
        }

        public string SearchCheckFields()
        {
            string checkedSearch = "";

            if (Name == "" ||  City == "")
            {
                string[] infoMessageSearch = new string[2];
                for (int i = 0; i < infoMessageSearch.Length; i++)
                {
                    if (Name == "")
                    {
                        infoMessageSearch[i] += "\nNamn";
                    }
                    if (City == "")
                    {
                        infoMessageSearch[i] += "\nPostort";
                    }
                    return "\n" + infoMessageSearch[i];
                }
            }
            return checkedSearch;


        }
    }
}
