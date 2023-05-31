namespace Programa_de_Vendas
{
    partial class FormVENDAS
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVALORTOTAL = new System.Windows.Forms.Label();
            this.dataGridViewvendaRealizada = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            this.buttonPESQUISAR = new System.Windows.Forms.Button();
            this.dataGridViewVENDA = new System.Windows.Forms.DataGridView();
            this.comboBoxCLIENTES = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDATA = new System.Windows.Forms.Label();
            this.buttonVENDA = new System.Windows.Forms.Button();
            this.buttonFINALIZAR = new System.Windows.Forms.Button();
            this.buttonCANCELAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvendaRealizada)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVENDA)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVALORTOTAL
            // 
            this.labelVALORTOTAL.BackColor = System.Drawing.Color.White;
            this.labelVALORTOTAL.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVALORTOTAL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelVALORTOTAL.Location = new System.Drawing.Point(475, 380);
            this.labelVALORTOTAL.Name = "labelVALORTOTAL";
            this.labelVALORTOTAL.Size = new System.Drawing.Size(176, 50);
            this.labelVALORTOTAL.TabIndex = 1;
            this.labelVALORTOTAL.Text = "R$ 1.500,00";
            this.labelVALORTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewvendaRealizada
            // 
            this.dataGridViewvendaRealizada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewvendaRealizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewvendaRealizada.Location = new System.Drawing.Point(370, 104);
            this.dataGridViewvendaRealizada.Name = "dataGridViewvendaRealizada";
            this.dataGridViewvendaRealizada.Size = new System.Drawing.Size(281, 273);
            this.dataGridViewvendaRealizada.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPESQUISA);
            this.panel1.Controls.Add(this.buttonPESQUISAR);
            this.panel1.Controls.Add(this.dataGridViewVENDA);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 390);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::Programa_de_Vendas.Properties.Resources.lupa1;
            this.label3.Location = new System.Drawing.Point(243, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 36);
            this.label3.TabIndex = 10;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Location = new System.Drawing.Point(3, 25);
            this.textBoxPESQUISA.Multiline = true;
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(281, 31);
            this.textBoxPESQUISA.TabIndex = 4;
            // 
            // buttonPESQUISAR
            // 
            this.buttonPESQUISAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPESQUISAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPESQUISAR.Location = new System.Drawing.Point(3, 62);
            this.buttonPESQUISAR.Name = "buttonPESQUISAR";
            this.buttonPESQUISAR.Size = new System.Drawing.Size(234, 38);
            this.buttonPESQUISAR.TabIndex = 4;
            this.buttonPESQUISAR.Text = "Pesquisar";
            this.buttonPESQUISAR.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVENDA
            // 
            this.dataGridViewVENDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVENDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVENDA.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewVENDA.Name = "dataGridViewVENDA";
            this.dataGridViewVENDA.Size = new System.Drawing.Size(281, 273);
            this.dataGridViewVENDA.TabIndex = 4;
            // 
            // comboBoxCLIENTES
            // 
            this.comboBoxCLIENTES.FormattingEnabled = true;
            this.comboBoxCLIENTES.Location = new System.Drawing.Point(447, 38);
            this.comboBoxCLIENTES.Name = "comboBoxCLIENTES";
            this.comboBoxCLIENTES.Size = new System.Drawing.Size(204, 21);
            this.comboBoxCLIENTES.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // labelDATA
            // 
            this.labelDATA.AutoSize = true;
            this.labelDATA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDATA.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDATA.Location = new System.Drawing.Point(516, 9);
            this.labelDATA.Name = "labelDATA";
            this.labelDATA.Size = new System.Drawing.Size(135, 19);
            this.labelDATA.TabIndex = 9;
            this.labelDATA.Text = "30/05/2023 - 20:05";
            // 
            // buttonVENDA
            // 
            this.buttonVENDA.BackColor = System.Drawing.Color.Transparent;
            this.buttonVENDA.BackgroundImage = global::Programa_de_Vendas.Properties.Resources.seta_direita__1_;
            this.buttonVENDA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonVENDA.FlatAppearance.BorderSize = 0;
            this.buttonVENDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVENDA.Location = new System.Drawing.Point(298, 104);
            this.buttonVENDA.Name = "buttonVENDA";
            this.buttonVENDA.Size = new System.Drawing.Size(66, 287);
            this.buttonVENDA.TabIndex = 5;
            this.buttonVENDA.UseVisualStyleBackColor = false;
            // 
            // buttonFINALIZAR
            // 
            this.buttonFINALIZAR.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonFINALIZAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFINALIZAR.FlatAppearance.BorderSize = 0;
            this.buttonFINALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFINALIZAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFINALIZAR.ForeColor = System.Drawing.Color.White;
            this.buttonFINALIZAR.Location = new System.Drawing.Point(1, 433);
            this.buttonFINALIZAR.Name = "buttonFINALIZAR";
            this.buttonFINALIZAR.Size = new System.Drawing.Size(291, 36);
            this.buttonFINALIZAR.TabIndex = 10;
            this.buttonFINALIZAR.Text = "Finalizar Venda";
            this.buttonFINALIZAR.UseVisualStyleBackColor = false;
            // 
            // buttonCANCELAR
            // 
            this.buttonCANCELAR.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCANCELAR.FlatAppearance.BorderSize = 0;
            this.buttonCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCANCELAR.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCANCELAR.ForeColor = System.Drawing.Color.White;
            this.buttonCANCELAR.Location = new System.Drawing.Point(370, 433);
            this.buttonCANCELAR.Name = "buttonCANCELAR";
            this.buttonCANCELAR.Size = new System.Drawing.Size(291, 36);
            this.buttonCANCELAR.TabIndex = 11;
            this.buttonCANCELAR.Text = "Cancelar Venda";
            this.buttonCANCELAR.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nova Venda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVENDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCANCELAR);
            this.Controls.Add(this.buttonFINALIZAR);
            this.Controls.Add(this.labelDATA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCLIENTES);
            this.Controls.Add(this.buttonVENDA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewvendaRealizada);
            this.Controls.Add(this.labelVALORTOTAL);
            this.Name = "FormVENDAS";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvendaRealizada)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVENDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVALORTOTAL;
        private System.Windows.Forms.DataGridView dataGridViewvendaRealizada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewVENDA;
        private System.Windows.Forms.Button buttonPESQUISAR;
        private System.Windows.Forms.TextBox textBoxPESQUISA;
        private System.Windows.Forms.Button buttonVENDA;
        private System.Windows.Forms.ComboBox comboBoxCLIENTES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDATA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFINALIZAR;
        private System.Windows.Forms.Button buttonCANCELAR;
        private System.Windows.Forms.Button button1;
    }
}

