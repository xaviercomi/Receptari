namespace Receptari
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxFavorito = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBotons = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonFavorito = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPreparacio = new System.Windows.Forms.TextBox();
            this.pictureBoxRecepta = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorito)).BeginInit();
            this.panelBotons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecepta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBoxFavorito);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelBotons);
            this.panel1.Controls.Add(this.textBoxCat);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Controls.Add(this.textBoxPreparacio);
            this.panel1.Controls.Add(this.pictureBoxRecepta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(171, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 415);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxFavorito
            // 
            this.pictureBoxFavorito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxFavorito.InitialImage = null;
            this.pictureBoxFavorito.Location = new System.Drawing.Point(469, 3);
            this.pictureBoxFavorito.Name = "pictureBoxFavorito";
            this.pictureBoxFavorito.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFavorito.TabIndex = 12;
            this.pictureBoxFavorito.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ref.";
            // 
            // panelBotons
            // 
            this.panelBotons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBotons.BackColor = System.Drawing.Color.Transparent;
            this.panelBotons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBotons.Controls.Add(this.buttonBuscar);
            this.panelBotons.Controls.Add(this.buttonFavorito);
            this.panelBotons.Controls.Add(this.buttonEditar);
            this.panelBotons.Controls.Add(this.buttonAgregar);
            this.panelBotons.Controls.Add(this.buttonEliminar);
            this.panelBotons.ForeColor = System.Drawing.Color.Transparent;
            this.panelBotons.Location = new System.Drawing.Point(336, 358);
            this.panelBotons.Name = "panelBotons";
            this.panelBotons.Size = new System.Drawing.Size(406, 45);
            this.panelBotons.TabIndex = 2;
            this.panelBotons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.BackgroundImage")));
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonBuscar.Location = new System.Drawing.Point(327, 3);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 39);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // buttonFavorito
            // 
            this.buttonFavorito.BackColor = System.Drawing.Color.Transparent;
            this.buttonFavorito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFavorito.BackgroundImage")));
            this.buttonFavorito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFavorito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFavorito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonFavorito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonFavorito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavorito.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFavorito.Location = new System.Drawing.Point(246, 3);
            this.buttonFavorito.Name = "buttonFavorito";
            this.buttonFavorito.Size = new System.Drawing.Size(75, 39);
            this.buttonFavorito.TabIndex = 4;
            this.buttonFavorito.UseVisualStyleBackColor = false;
            this.buttonFavorito.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEditar.Location = new System.Drawing.Point(165, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 39);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.BackgroundImage")));
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.Location = new System.Drawing.Point(84, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 39);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.Location = new System.Drawing.Point(3, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 39);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // textBoxCat
            // 
            this.textBoxCat.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCat.Location = new System.Drawing.Point(74, 39);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(152, 16);
            this.textBoxCat.TabIndex = 9;
            this.textBoxCat.TextChanged += new System.EventHandler(this.textBoxCat_TextChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNom.Location = new System.Drawing.Point(44, 17);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(186, 16);
            this.textBoxNom.TabIndex = 8;
            // 
            // textBoxPreparacio
            // 
            this.textBoxPreparacio.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxPreparacio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPreparacio.Location = new System.Drawing.Point(265, 178);
            this.textBoxPreparacio.Name = "textBoxPreparacio";
            this.textBoxPreparacio.Size = new System.Drawing.Size(244, 16);
            this.textBoxPreparacio.TabIndex = 7;
            // 
            // pictureBoxRecepta
            // 
            this.pictureBoxRecepta.Location = new System.Drawing.Point(265, 1);
            this.pictureBoxRecepta.Name = "pictureBoxRecepta";
            this.pictureBoxRecepta.Size = new System.Drawing.Size(244, 155);
            this.pictureBoxRecepta.TabIndex = 6;
            this.pictureBoxRecepta.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Preparació";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantitat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.16996F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.83004F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.47191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.52809F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 310);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorito)).EndInit();
            this.panelBotons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecepta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPreparacio;
        private System.Windows.Forms.PictureBox pictureBoxRecepta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Panel panelBotons;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonFavorito;
        private System.Windows.Forms.PictureBox pictureBoxFavorito;
    }
}

