
namespace Adressbok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelStreetAddress = new System.Windows.Forms.Label();
            this.labelPostalNumber = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostalNumber = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelTitel = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelClearFields = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.labelClearList = new System.Windows.Forms.Label();
            this.labelAddresslist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(44, 77);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Namn";
            // 
            // labelStreetAddress
            // 
            this.labelStreetAddress.AutoSize = true;
            this.labelStreetAddress.Location = new System.Drawing.Point(44, 118);
            this.labelStreetAddress.Name = "labelStreetAddress";
            this.labelStreetAddress.Size = new System.Drawing.Size(65, 15);
            this.labelStreetAddress.TabIndex = 1;
            this.labelStreetAddress.Text = "Gatuadress";
            // 
            // labelPostalNumber
            // 
            this.labelPostalNumber.AutoSize = true;
            this.labelPostalNumber.Location = new System.Drawing.Point(44, 159);
            this.labelPostalNumber.Name = "labelPostalNumber";
            this.labelPostalNumber.Size = new System.Drawing.Size(76, 15);
            this.labelPostalNumber.TabIndex = 2;
            this.labelPostalNumber.Text = "Postnummer";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(44, 200);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(45, 15);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "Postort";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(44, 241);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(45, 15);
            this.labelTelephone.TabIndex = 4;
            this.labelTelephone.Text = "Telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(44, 282);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(141, 74);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(254, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxStreetAddress
            // 
            this.textBoxStreetAddress.Location = new System.Drawing.Point(141, 115);
            this.textBoxStreetAddress.Name = "textBoxStreetAddress";
            this.textBoxStreetAddress.Size = new System.Drawing.Size(254, 23);
            this.textBoxStreetAddress.TabIndex = 7;
            // 
            // textBoxPostalNumber
            // 
            this.textBoxPostalNumber.Location = new System.Drawing.Point(141, 156);
            this.textBoxPostalNumber.Name = "textBoxPostalNumber";
            this.textBoxPostalNumber.Size = new System.Drawing.Size(254, 23);
            this.textBoxPostalNumber.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(141, 197);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(254, 23);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(141, 238);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(254, 23);
            this.textBoxTelephone.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(141, 279);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(254, 23);
            this.textBoxEmail.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(315, 337);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Spara";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(674, 337);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Ta bort kontakt";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(228, 337);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(79, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Uppdatera";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelTitel
            // 
            this.labelTitel.AutoSize = true;
            this.labelTitel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitel.Location = new System.Drawing.Point(44, 25);
            this.labelTitel.Name = "labelTitel";
            this.labelTitel.Size = new System.Drawing.Size(106, 25);
            this.labelTitel.TabIndex = 16;
            this.labelTitel.Text = "Adressbok";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(141, 337);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(79, 23);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Sök";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelClearFields
            // 
            this.labelClearFields.AutoSize = true;
            this.labelClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClearFields.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClearFields.ForeColor = System.Drawing.Color.Blue;
            this.labelClearFields.Location = new System.Drawing.Point(322, 305);
            this.labelClearFields.Name = "labelClearFields";
            this.labelClearFields.Size = new System.Drawing.Size(79, 15);
            this.labelClearFields.TabIndex = 18;
            this.labelClearFields.Text = "Rensa alla fält";
            this.labelClearFields.Click += new System.EventHandler(this.labelClearFields_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 15;
            this.listBoxResult.Location = new System.Drawing.Point(453, 73);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(318, 229);
            this.listBoxResult.TabIndex = 15;
            this.listBoxResult.SelectedIndexChanged += new System.EventHandler(this.listBoxResult_SelectedIndexChanged);
            // 
            // labelClearList
            // 
            this.labelClearList.AutoSize = true;
            this.labelClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClearList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClearList.ForeColor = System.Drawing.Color.Blue;
            this.labelClearList.Location = new System.Drawing.Point(702, 305);
            this.labelClearList.Name = "labelClearList";
            this.labelClearList.Size = new System.Drawing.Size(69, 15);
            this.labelClearList.TabIndex = 19;
            this.labelClearList.Text = "Rensa listan";
            this.labelClearList.Click += new System.EventHandler(this.labelClearList_Click);
            // 
            // labelAddresslist
            // 
            this.labelAddresslist.AutoSize = true;
            this.labelAddresslist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddresslist.Location = new System.Drawing.Point(453, 53);
            this.labelAddresslist.Name = "labelAddresslist";
            this.labelAddresslist.Size = new System.Drawing.Size(71, 17);
            this.labelAddresslist.TabIndex = 20;
            this.labelAddresslist.Text = "Adresslista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 409);
            this.Controls.Add(this.labelAddresslist);
            this.Controls.Add(this.labelClearList);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.labelClearFields);
            this.Controls.Add(this.labelTitel);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxPostalNumber);
            this.Controls.Add(this.textBoxStreetAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPostalNumber);
            this.Controls.Add(this.labelStreetAddress);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = " Adressbok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStreetAddress;
        private System.Windows.Forms.Label labelPostalNumber;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxStreetAddress;
        private System.Windows.Forms.TextBox textBoxPostalNumber;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelTitel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelClearFields;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label labelClearList;
        private System.Windows.Forms.Label labelAddresslist;
    }
}

