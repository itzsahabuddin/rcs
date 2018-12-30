namespace RajCycleStores
{
    partial class Form3
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PartyName = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.PDetails = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Amnt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PAmnt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TmpAmnt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PartyName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(79, 115);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 23);
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Party Name";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(79, 188);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonLabel2.Size = new System.Drawing.Size(136, 23);
            this.kryptonLabel2.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Purchasing Details";
            this.kryptonLabel2.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonLabel2_Paint);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(79, 345);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonLabel3.Size = new System.Drawing.Size(66, 23);
            this.kryptonLabel3.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Amount";
            // 
            // PartyName
            // 
            this.PartyName.DropDownWidth = 121;
            this.PartyName.Location = new System.Drawing.Point(231, 115);
            this.PartyName.Name = "PartyName";
            this.PartyName.Size = new System.Drawing.Size(145, 21);
            this.PartyName.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartyName.TabIndex = 3;
            this.PartyName.SelectedIndexChanged += new System.EventHandler(this.PartyName_SelectedIndexChanged);
            // 
            // PDetails
            // 
            this.PDetails.Location = new System.Drawing.Point(216, 172);
            this.PDetails.Multiline = true;
            this.PDetails.Name = "PDetails";
            this.PDetails.Size = new System.Drawing.Size(183, 72);
            this.PDetails.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDetails.TabIndex = 4;
            // 
            // Amnt
            // 
            this.Amnt.Location = new System.Drawing.Point(231, 345);
            this.Amnt.Name = "Amnt";
            this.Amnt.Size = new System.Drawing.Size(145, 29);
            this.Amnt.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amnt.TabIndex = 5;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(80, 420);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(110, 36);
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Image = global::RajCycleStores.Properties.Resources.Save24;
            this.kryptonButton1.Values.Text = "  Save";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(401, 420);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(97, 36);
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 7;
            this.kryptonButton2.Values.Image = global::RajCycleStores.Properties.Resources.Home24;
            this.kryptonButton2.Values.Text = "  Back";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // PAmnt
            // 
            this.PAmnt.Enabled = false;
            this.PAmnt.Location = new System.Drawing.Point(231, 276);
            this.PAmnt.Name = "PAmnt";
            this.PAmnt.Size = new System.Drawing.Size(100, 32);
            this.PAmnt.StateCommon.Content.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAmnt.TabIndex = 8;
            this.PAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TmpAmnt
            // 
            this.TmpAmnt.Enabled = false;
            this.TmpAmnt.Location = new System.Drawing.Point(412, 188);
            this.TmpAmnt.Name = "TmpAmnt";
            this.TmpAmnt.Size = new System.Drawing.Size(100, 20);
            this.TmpAmnt.TabIndex = 9;
            this.TmpAmnt.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(79, 276);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonLabel4.Size = new System.Drawing.Size(96, 23);
            this.kryptonLabel4.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 11;
            this.kryptonLabel4.Values.Text = "Due Amount";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(246, 420);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(97, 36);
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 12;
            this.kryptonButton3.Values.Image = global::RajCycleStores.Properties.Resources.New24;
            this.kryptonButton3.Values.Text = "  Clear";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(129, 8);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonLabel5.Size = new System.Drawing.Size(325, 50);
            this.kryptonLabel5.StateNormal.ShortText.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 13;
            this.kryptonLabel5.Values.Text = "Purchasing Details";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 499);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonButton3);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.TmpAmnt);
            this.Controls.Add(this.PAmnt);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.Amnt);
            this.Controls.Add(this.PDetails);
            this.Controls.Add(this.PartyName);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Party Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartyName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox PartyName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PDetails;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Amnt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PAmnt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TmpAmnt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}