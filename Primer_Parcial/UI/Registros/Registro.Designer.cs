namespace Primer_Parcial.UI.Registros
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.GrupoBox = new System.Windows.Forms.TextBox();
            this.IntegranteBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IdNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.FechaTool = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.IdNum)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoBoton.Image")));
            this.NuevoBoton.Location = new System.Drawing.Point(49, 185);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(95, 52);
            this.NuevoBoton.TabIndex = 2;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBoton.Image")));
            this.GuardarBoton.Location = new System.Drawing.Point(150, 185);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(94, 52);
            this.GuardarBoton.TabIndex = 3;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBoton.Image")));
            this.EliminarBoton.Location = new System.Drawing.Point(250, 185);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(96, 52);
            this.EliminarBoton.TabIndex = 4;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBoton.Image")));
            this.BuscarBoton.Location = new System.Drawing.Point(274, 36);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(100, 32);
            this.BuscarBoton.TabIndex = 5;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscrBoton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad de Estudiantes:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Grupos desedos:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cada Grupo contara con un total de:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estudiantes";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(77, 10);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(134, 20);
            this.NombreBox.TabIndex = 11;
            this.NombreBox.TextChanged += new System.EventHandler(this.NombreBox_TextChanged);
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(173, 75);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(38, 20);
            this.CantidadBox.TabIndex = 12;
            this.CantidadBox.TextChanged += new System.EventHandler(this.CantidadBox_TextChanged);
            // 
            // GrupoBox
            // 
            this.GrupoBox.Location = new System.Drawing.Point(120, 109);
            this.GrupoBox.Name = "GrupoBox";
            this.GrupoBox.Size = new System.Drawing.Size(38, 20);
            this.GrupoBox.TabIndex = 13;
            this.GrupoBox.TextChanged += new System.EventHandler(this.GrupoBox_TextChanged);
            // 
            // IntegranteBox
            // 
            this.IntegranteBox.Location = new System.Drawing.Point(250, 141);
            this.IntegranteBox.Name = "IntegranteBox";
            this.IntegranteBox.Size = new System.Drawing.Size(55, 20);
            this.IntegranteBox.TabIndex = 14;
            this.IntegranteBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Grupo ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // IdNum
            // 
            this.IdNum.Location = new System.Drawing.Point(325, 79);
            this.IdNum.Name = "IdNum";
            this.IdNum.Size = new System.Drawing.Size(48, 20);
            this.IdNum.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Descripcion:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.Location = new System.Drawing.Point(94, 42);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(117, 20);
            this.DescripcionBox.TabIndex = 19;
            this.DescripcionBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // FechaTool
            // 
            this.FechaTool.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaTool.Location = new System.Drawing.Point(274, 10);
            this.FechaTool.Name = "FechaTool";
            this.FechaTool.Size = new System.Drawing.Size(113, 20);
            this.FechaTool.TabIndex = 20;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 258);
            this.Controls.Add(this.FechaTool);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IntegranteBox);
            this.Controls.Add(this.GrupoBox);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox CantidadBox;
        private System.Windows.Forms.TextBox GrupoBox;
        private System.Windows.Forms.TextBox IntegranteBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown IdNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.DateTimePicker FechaTool;
    }
}