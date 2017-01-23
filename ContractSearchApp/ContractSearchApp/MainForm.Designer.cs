namespace ContractSearchApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstUserInformation = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PayedMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payed_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payed_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtId = new System.Windows.Forms.TextBox();
            this.CBContractNumber = new System.Windows.Forms.CheckBox();
            this.CBFiN = new System.Windows.Forms.CheckBox();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.CBDateTime = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(820, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstUserInformation
            // 
            this.lstUserInformation.BackColor = System.Drawing.Color.White;
            this.lstUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUserInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.Surname,
            this.Pin,
            this.Phone,
            this.Mail,
            this.Adress,
            this.PayedMoney,
            this.Payed_Status,
            this.Payed_Date});
            this.lstUserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUserInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstUserInformation.FullRowSelect = true;
            this.lstUserInformation.GridLines = true;
            this.lstUserInformation.Location = new System.Drawing.Point(3, 318);
            this.lstUserInformation.Name = "lstUserInformation";
            this.lstUserInformation.Size = new System.Drawing.Size(1201, 352);
            this.lstUserInformation.TabIndex = 2;
            this.lstUserInformation.UseCompatibleStateImageBehavior = false;
            this.lstUserInformation.View = System.Windows.Forms.View.Details;
            this.lstUserInformation.SelectedIndexChanged += new System.EventHandler(this.lstUserInformation_SelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.Text = "Ad";
            this.firstName.Width = 102;
            // 
            // Surname
            // 
            this.Surname.Text = "Soyad";
            this.Surname.Width = 106;
            // 
            // Pin
            // 
            this.Pin.Text = "FIN";
            this.Pin.Width = 84;
            // 
            // Phone
            // 
            this.Phone.Text = "Elaqe_tel";
            this.Phone.Width = 116;
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 120;
            // 
            // Adress
            // 
            this.Adress.Text = "Ünvan";
            this.Adress.Width = 136;
            // 
            // PayedMoney
            // 
            this.PayedMoney.Text = "Ödənilən Məbləğ";
            this.PayedMoney.Width = 164;
            // 
            // Payed_Status
            // 
            this.Payed_Status.Text = "Ödənilmə Statusu";
            this.Payed_Status.Width = 177;
            // 
            // Payed_Date
            // 
            this.Payed_Date.Text = "Ödəmə Tarixi";
            this.Payed_Date.Width = 208;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(586, 90);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(228, 29);
            this.txtId.TabIndex = 3;
            // 
            // CBContractNumber
            // 
            this.CBContractNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.CBContractNumber.FlatAppearance.BorderSize = 0;
            this.CBContractNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBContractNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBContractNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBContractNumber.Location = new System.Drawing.Point(16, 26);
            this.CBContractNumber.Name = "CBContractNumber";
            this.CBContractNumber.Size = new System.Drawing.Size(274, 23);
            this.CBContractNumber.TabIndex = 4;
            this.CBContractNumber.Text = "Kontraktın Nömrəsinə görə axtarış ";
            this.CBContractNumber.UseVisualStyleBackColor = false;
            this.CBContractNumber.CheckedChanged += new System.EventHandler(this.CBContractNumber_CheckedChanged);
            // 
            // CBFiN
            // 
            this.CBFiN.AutoSize = true;
            this.CBFiN.FlatAppearance.BorderSize = 0;
            this.CBFiN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBFiN.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFiN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBFiN.Location = new System.Drawing.Point(16, 58);
            this.CBFiN.Name = "CBFiN";
            this.CBFiN.Size = new System.Drawing.Size(158, 20);
            this.CBFiN.TabIndex = 5;
            this.CBFiN.Text = "FİN-ə görə axtarış";
            this.CBFiN.UseVisualStyleBackColor = true;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "yyyy-MM-dd";
            this.dtFrom.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(408, 28);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 29);
            this.dtFrom.TabIndex = 6;
            // 
            // dtToDate
            // 
            this.dtToDate.CustomFormat = "yyyy-MM-dd";
            this.dtToDate.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(614, 29);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 29);
            this.dtToDate.TabIndex = 7;
            // 
            // CBDateTime
            // 
            this.CBDateTime.AutoSize = true;
            this.CBDateTime.FlatAppearance.BorderSize = 0;
            this.CBDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBDateTime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CBDateTime.Location = new System.Drawing.Point(16, 87);
            this.CBDateTime.Name = "CBDateTime";
            this.CBDateTime.Size = new System.Drawing.Size(176, 20);
            this.CBDateTime.TabIndex = 10;
            this.CBDateTime.Text = "Zamana görə axtarış";
            this.CBDateTime.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.CBContractNumber);
            this.panel1.Controls.Add(this.CBFiN);
            this.panel1.Controls.Add(this.CBDateTime);
            this.panel1.Location = new System.Drawing.Point(922, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 308);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(820, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Axtar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1207, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.lstUserInformation);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "MainForm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstUserInformation;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Pin;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Adress;
        private System.Windows.Forms.ColumnHeader PayedMoney;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ColumnHeader Payed_Status;
        private System.Windows.Forms.ColumnHeader Payed_Date;
        private System.Windows.Forms.CheckBox CBContractNumber;
        private System.Windows.Forms.CheckBox CBFiN;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.CheckBox CBDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

