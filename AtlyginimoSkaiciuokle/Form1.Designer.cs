namespace AtlyginimoSkaiciuokle
{
    partial class Form1
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
            this.tabAtlyginimas = new System.Windows.Forms.TabControl();
            this.tabBruto = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJustTxt = new System.Windows.Forms.Label();
            this.lstBoxPensija = new System.Windows.Forms.ListBox();
            this.lbNPD = new System.Windows.Forms.Label();
            this.lbGMP = new System.Windows.Forms.Label();
            this.lbIRankas = new System.Windows.Forms.Label();
            this.lbDrdvSodra = new System.Windows.Forms.Label();
            this.lbSodraVSDpens = new System.Windows.Forms.Label();
            this.lbSodraPSD = new System.Windows.Forms.Label();
            this.tBoxAtlyginimas = new System.Windows.Forms.TextBox();
            this.tabNeto = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNetoJustTxt = new System.Windows.Forms.Label();
            this.tBoxNeto = new System.Windows.Forms.TextBox();
            this.lstBoxNetoPensija = new System.Windows.Forms.ListBox();
            this.lblNetoNPD = new System.Windows.Forms.Label();
            this.lblNetoGPM = new System.Windows.Forms.Label();
            this.lblNetoAntPop = new System.Windows.Forms.Label();
            this.lblNetoDrdvSodra = new System.Windows.Forms.Label();
            this.lblNetoSodraVSDpens = new System.Windows.Forms.Label();
            this.lblNetoSodraPSD = new System.Windows.Forms.Label();
            this.tabAtlyginimas.SuspendLayout();
            this.tabBruto.SuspendLayout();
            this.tabNeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAtlyginimas
            // 
            this.tabAtlyginimas.Controls.Add(this.tabBruto);
            this.tabAtlyginimas.Controls.Add(this.tabNeto);
            this.tabAtlyginimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAtlyginimas.Location = new System.Drawing.Point(12, 26);
            this.tabAtlyginimas.Name = "tabAtlyginimas";
            this.tabAtlyginimas.SelectedIndex = 0;
            this.tabAtlyginimas.Size = new System.Drawing.Size(535, 313);
            this.tabAtlyginimas.TabIndex = 0;
            // 
            // tabBruto
            // 
            this.tabBruto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabBruto.Controls.Add(this.label1);
            this.tabBruto.Controls.Add(this.lblJustTxt);
            this.tabBruto.Controls.Add(this.lstBoxPensija);
            this.tabBruto.Controls.Add(this.lbNPD);
            this.tabBruto.Controls.Add(this.lbGMP);
            this.tabBruto.Controls.Add(this.lbIRankas);
            this.tabBruto.Controls.Add(this.lbDrdvSodra);
            this.tabBruto.Controls.Add(this.lbSodraVSDpens);
            this.tabBruto.Controls.Add(this.lbSodraPSD);
            this.tabBruto.Controls.Add(this.tBoxAtlyginimas);
            this.tabBruto.Location = new System.Drawing.Point(4, 27);
            this.tabBruto.Name = "tabBruto";
            this.tabBruto.Padding = new System.Windows.Forms.Padding(3);
            this.tabBruto.Size = new System.Drawing.Size(527, 282);
            this.tabBruto.TabIndex = 0;
            this.tabBruto.Text = "Bruto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kaupiu pensijai papildomai:";
            // 
            // lblJustTxt
            // 
            this.lblJustTxt.AutoSize = true;
            this.lblJustTxt.BackColor = System.Drawing.Color.Black;
            this.lblJustTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustTxt.ForeColor = System.Drawing.Color.White;
            this.lblJustTxt.Location = new System.Drawing.Point(7, 220);
            this.lblJustTxt.Name = "lblJustTxt";
            this.lblJustTxt.Size = new System.Drawing.Size(212, 16);
            this.lblJustTxt.TabIndex = 10;
            this.lblJustTxt.Text = "Išmokamas atlyginimas \"į rankas\":";
            // 
            // lstBoxPensija
            // 
            this.lstBoxPensija.FormattingEnabled = true;
            this.lstBoxPensija.ItemHeight = 18;
            this.lstBoxPensija.Items.AddRange(new object[] {
            "Nekaupiu",
            "1.8%",
            "3.0%"});
            this.lstBoxPensija.Location = new System.Drawing.Point(162, 20);
            this.lstBoxPensija.Name = "lstBoxPensija";
            this.lstBoxPensija.Size = new System.Drawing.Size(69, 58);
            this.lstBoxPensija.TabIndex = 8;
            this.lstBoxPensija.SelectedIndexChanged += new System.EventHandler(this.tBoxAtlyginimas_TextChanged);
            // 
            // lbNPD
            // 
            this.lbNPD.AutoSize = true;
            this.lbNPD.BackColor = System.Drawing.Color.Black;
            this.lbNPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNPD.ForeColor = System.Drawing.Color.White;
            this.lbNPD.Location = new System.Drawing.Point(7, 70);
            this.lbNPD.Name = "lbNPD";
            this.lbNPD.Size = new System.Drawing.Size(105, 16);
            this.lbNPD.TabIndex = 7;
            this.lbNPD.Text = "Pritaikytas NPD:";
            // 
            // lbGMP
            // 
            this.lbGMP.AutoSize = true;
            this.lbGMP.BackColor = System.Drawing.Color.Black;
            this.lbGMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGMP.ForeColor = System.Drawing.Color.White;
            this.lbGMP.Location = new System.Drawing.Point(7, 98);
            this.lbGMP.Name = "lbGMP";
            this.lbGMP.Size = new System.Drawing.Size(176, 16);
            this.lbGMP.TabIndex = 6;
            this.lbGMP.Text = "Gyventojų pajamų mokestis:";
            // 
            // lbIRankas
            // 
            this.lbIRankas.AutoSize = true;
            this.lbIRankas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbIRankas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIRankas.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRankas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbIRankas.Location = new System.Drawing.Point(231, 216);
            this.lbIRankas.Name = "lbIRankas";
            this.lbIRankas.Size = new System.Drawing.Size(27, 21);
            this.lbIRankas.TabIndex = 5;
            this.lbIRankas.Text = "0";
            // 
            // lbDrdvSodra
            // 
            this.lbDrdvSodra.AutoSize = true;
            this.lbDrdvSodra.BackColor = System.Drawing.Color.Black;
            this.lbDrdvSodra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrdvSodra.ForeColor = System.Drawing.Color.White;
            this.lbDrdvSodra.Location = new System.Drawing.Point(7, 194);
            this.lbDrdvSodra.Name = "lbDrdvSodra";
            this.lbDrdvSodra.Size = new System.Drawing.Size(248, 16);
            this.lbDrdvSodra.TabIndex = 4;
            this.lbDrdvSodra.Text = "Darbdavio sumokami mokesčiai. Sodra:";
            // 
            // lbSodraVSDpens
            // 
            this.lbSodraVSDpens.AutoSize = true;
            this.lbSodraVSDpens.BackColor = System.Drawing.Color.Black;
            this.lbSodraVSDpens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSodraVSDpens.ForeColor = System.Drawing.Color.White;
            this.lbSodraVSDpens.Location = new System.Drawing.Point(7, 156);
            this.lbSodraVSDpens.Name = "lbSodraVSDpens";
            this.lbSodraVSDpens.Size = new System.Drawing.Size(203, 16);
            this.lbSodraVSDpens.TabIndex = 3;
            this.lbSodraVSDpens.Text = "Sodra. Pensijų ir soc. draudimas:";
            // 
            // lbSodraPSD
            // 
            this.lbSodraPSD.AutoSize = true;
            this.lbSodraPSD.BackColor = System.Drawing.Color.Black;
            this.lbSodraPSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSodraPSD.ForeColor = System.Drawing.Color.White;
            this.lbSodraPSD.Location = new System.Drawing.Point(7, 126);
            this.lbSodraPSD.Name = "lbSodraPSD";
            this.lbSodraPSD.Size = new System.Drawing.Size(181, 16);
            this.lbSodraPSD.TabIndex = 2;
            this.lbSodraPSD.Text = "Sodra. Sveikatos draudimas:";
            // 
            // tBoxAtlyginimas
            // 
            this.tBoxAtlyginimas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxAtlyginimas.Location = new System.Drawing.Point(6, 20);
            this.tBoxAtlyginimas.Name = "tBoxAtlyginimas";
            this.tBoxAtlyginimas.Size = new System.Drawing.Size(106, 29);
            this.tBoxAtlyginimas.TabIndex = 1;
            this.tBoxAtlyginimas.TextChanged += new System.EventHandler(this.tBoxAtlyginimas_TextChanged);
            // 
            // tabNeto
            // 
            this.tabNeto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabNeto.Controls.Add(this.label2);
            this.tabNeto.Controls.Add(this.lblNetoJustTxt);
            this.tabNeto.Controls.Add(this.tBoxNeto);
            this.tabNeto.Controls.Add(this.lstBoxNetoPensija);
            this.tabNeto.Controls.Add(this.lblNetoNPD);
            this.tabNeto.Controls.Add(this.lblNetoGPM);
            this.tabNeto.Controls.Add(this.lblNetoAntPop);
            this.tabNeto.Controls.Add(this.lblNetoDrdvSodra);
            this.tabNeto.Controls.Add(this.lblNetoSodraVSDpens);
            this.tabNeto.Controls.Add(this.lblNetoSodraPSD);
            this.tabNeto.Location = new System.Drawing.Point(4, 27);
            this.tabNeto.Name = "tabNeto";
            this.tabNeto.Padding = new System.Windows.Forms.Padding(3);
            this.tabNeto.Size = new System.Drawing.Size(527, 282);
            this.tabNeto.TabIndex = 1;
            this.tabNeto.Text = "Neto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kaupiu pensijai papildomai:";
            // 
            // lblNetoJustTxt
            // 
            this.lblNetoJustTxt.AutoSize = true;
            this.lblNetoJustTxt.BackColor = System.Drawing.Color.Black;
            this.lblNetoJustTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoJustTxt.ForeColor = System.Drawing.Color.White;
            this.lblNetoJustTxt.Location = new System.Drawing.Point(7, 220);
            this.lblNetoJustTxt.Name = "lblNetoJustTxt";
            this.lblNetoJustTxt.Size = new System.Drawing.Size(264, 16);
            this.lblNetoJustTxt.TabIndex = 21;
            this.lblNetoJustTxt.Text = "Priskaičiuotas atlyginimas \"ant popieriaus\":";
            // 
            // tBoxNeto
            // 
            this.tBoxNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNeto.Location = new System.Drawing.Point(6, 20);
            this.tBoxNeto.Name = "tBoxNeto";
            this.tBoxNeto.Size = new System.Drawing.Size(106, 29);
            this.tBoxNeto.TabIndex = 20;
            this.tBoxNeto.TextChanged += new System.EventHandler(this.tBoxNeto_TextChanged);
            // 
            // lstBoxNetoPensija
            // 
            this.lstBoxNetoPensija.FormattingEnabled = true;
            this.lstBoxNetoPensija.ItemHeight = 18;
            this.lstBoxNetoPensija.Items.AddRange(new object[] {
            "Nekaupiu",
            "1.8%",
            "3.0%"});
            this.lstBoxNetoPensija.Location = new System.Drawing.Point(162, 20);
            this.lstBoxNetoPensija.Name = "lstBoxNetoPensija";
            this.lstBoxNetoPensija.Size = new System.Drawing.Size(69, 58);
            this.lstBoxNetoPensija.TabIndex = 19;
            this.lstBoxNetoPensija.SelectedIndexChanged += new System.EventHandler(this.lstBoxNetoPensija_SelectedIndexChanged);
            // 
            // lblNetoNPD
            // 
            this.lblNetoNPD.AutoSize = true;
            this.lblNetoNPD.BackColor = System.Drawing.Color.Black;
            this.lblNetoNPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoNPD.ForeColor = System.Drawing.Color.White;
            this.lblNetoNPD.Location = new System.Drawing.Point(7, 70);
            this.lblNetoNPD.Name = "lblNetoNPD";
            this.lblNetoNPD.Size = new System.Drawing.Size(105, 16);
            this.lblNetoNPD.TabIndex = 18;
            this.lblNetoNPD.Text = "Pritaikytas NPD:";
            // 
            // lblNetoGPM
            // 
            this.lblNetoGPM.AutoSize = true;
            this.lblNetoGPM.BackColor = System.Drawing.Color.Black;
            this.lblNetoGPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoGPM.ForeColor = System.Drawing.Color.White;
            this.lblNetoGPM.Location = new System.Drawing.Point(7, 98);
            this.lblNetoGPM.Name = "lblNetoGPM";
            this.lblNetoGPM.Size = new System.Drawing.Size(176, 16);
            this.lblNetoGPM.TabIndex = 17;
            this.lblNetoGPM.Text = "Gyventojų pajamų mokestis:";
            // 
            // lblNetoAntPop
            // 
            this.lblNetoAntPop.AutoSize = true;
            this.lblNetoAntPop.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblNetoAntPop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetoAntPop.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoAntPop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNetoAntPop.Location = new System.Drawing.Point(282, 216);
            this.lblNetoAntPop.Name = "lblNetoAntPop";
            this.lblNetoAntPop.Size = new System.Drawing.Size(27, 21);
            this.lblNetoAntPop.TabIndex = 16;
            this.lblNetoAntPop.Text = "0";
            // 
            // lblNetoDrdvSodra
            // 
            this.lblNetoDrdvSodra.AutoSize = true;
            this.lblNetoDrdvSodra.BackColor = System.Drawing.Color.Black;
            this.lblNetoDrdvSodra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoDrdvSodra.ForeColor = System.Drawing.Color.White;
            this.lblNetoDrdvSodra.Location = new System.Drawing.Point(7, 194);
            this.lblNetoDrdvSodra.Name = "lblNetoDrdvSodra";
            this.lblNetoDrdvSodra.Size = new System.Drawing.Size(248, 16);
            this.lblNetoDrdvSodra.TabIndex = 15;
            this.lblNetoDrdvSodra.Text = "Darbdavio sumokami mokesčiai. Sodra:";
            // 
            // lblNetoSodraVSDpens
            // 
            this.lblNetoSodraVSDpens.AutoSize = true;
            this.lblNetoSodraVSDpens.BackColor = System.Drawing.Color.Black;
            this.lblNetoSodraVSDpens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoSodraVSDpens.ForeColor = System.Drawing.Color.White;
            this.lblNetoSodraVSDpens.Location = new System.Drawing.Point(7, 156);
            this.lblNetoSodraVSDpens.Name = "lblNetoSodraVSDpens";
            this.lblNetoSodraVSDpens.Size = new System.Drawing.Size(203, 16);
            this.lblNetoSodraVSDpens.TabIndex = 14;
            this.lblNetoSodraVSDpens.Text = "Sodra. Pensijų ir soc. draudimas:";
            // 
            // lblNetoSodraPSD
            // 
            this.lblNetoSodraPSD.AutoSize = true;
            this.lblNetoSodraPSD.BackColor = System.Drawing.Color.Black;
            this.lblNetoSodraPSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoSodraPSD.ForeColor = System.Drawing.Color.White;
            this.lblNetoSodraPSD.Location = new System.Drawing.Point(7, 126);
            this.lblNetoSodraPSD.Name = "lblNetoSodraPSD";
            this.lblNetoSodraPSD.Size = new System.Drawing.Size(181, 16);
            this.lblNetoSodraPSD.TabIndex = 13;
            this.lblNetoSodraPSD.Text = "Sodra. Sveikatos draudimas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(563, 357);
            this.Controls.Add(this.tabAtlyginimas);
            this.Name = "Form1";
            this.Text = "Atlyginimo skaiciuokle";
            this.tabAtlyginimas.ResumeLayout(false);
            this.tabBruto.ResumeLayout(false);
            this.tabBruto.PerformLayout();
            this.tabNeto.ResumeLayout(false);
            this.tabNeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAtlyginimas;
        private System.Windows.Forms.TabPage tabBruto;
        private System.Windows.Forms.TabPage tabNeto;
        private System.Windows.Forms.Label lbSodraPSD;
        private System.Windows.Forms.TextBox tBoxAtlyginimas;
        private System.Windows.Forms.Label lbSodraVSDpens;
        private System.Windows.Forms.Label lbDrdvSodra;
        private System.Windows.Forms.Label lbIRankas;
        private System.Windows.Forms.Label lbGMP;
        private System.Windows.Forms.Label lbNPD;
        private System.Windows.Forms.ListBox lstBoxPensija;
        private System.Windows.Forms.Label lblJustTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNetoJustTxt;
        private System.Windows.Forms.TextBox tBoxNeto;
        private System.Windows.Forms.ListBox lstBoxNetoPensija;
        private System.Windows.Forms.Label lblNetoNPD;
        private System.Windows.Forms.Label lblNetoGPM;
        private System.Windows.Forms.Label lblNetoAntPop;
        private System.Windows.Forms.Label lblNetoDrdvSodra;
        private System.Windows.Forms.Label lblNetoSodraVSDpens;
        private System.Windows.Forms.Label lblNetoSodraPSD;
    }
}

