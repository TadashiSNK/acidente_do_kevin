/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 15/08/2025
 * Hora: 21:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace carroBatido
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox rua;
		private System.Windows.Forms.PictureBox floresta;
		private System.Windows.Forms.PictureBox carroNormal;
		private System.Windows.Forms.PictureBox cones;
		private System.Windows.Forms.Button moverBTN;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button aceleroBTN;
		private System.Windows.Forms.Button reBTN;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.rua = new System.Windows.Forms.PictureBox();
			this.floresta = new System.Windows.Forms.PictureBox();
			this.carroNormal = new System.Windows.Forms.PictureBox();
			this.cones = new System.Windows.Forms.PictureBox();
			this.moverBTN = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.aceleroBTN = new System.Windows.Forms.Button();
			this.reBTN = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.rua)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.floresta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carroNormal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cones)).BeginInit();
			this.SuspendLayout();
			// 
			// rua
			// 
			this.rua.BackColor = System.Drawing.Color.Transparent;
			this.rua.Image = ((System.Drawing.Image)(resources.GetObject("rua.Image")));
			this.rua.Location = new System.Drawing.Point(0, 284);
			this.rua.Name = "rua";
			this.rua.Size = new System.Drawing.Size(1242, 175);
			this.rua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.rua.TabIndex = 0;
			this.rua.TabStop = false;
			// 
			// floresta
			// 
			this.floresta.BackColor = System.Drawing.Color.Transparent;
			this.floresta.Image = ((System.Drawing.Image)(resources.GetObject("floresta.Image")));
			this.floresta.Location = new System.Drawing.Point(1, 1);
			this.floresta.Name = "floresta";
			this.floresta.Size = new System.Drawing.Size(1242, 284);
			this.floresta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.floresta.TabIndex = 1;
			this.floresta.TabStop = false;
			// 
			// carroNormal
			// 
			this.carroNormal.BackColor = System.Drawing.Color.Transparent;
			this.carroNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.carroNormal.Image = ((System.Drawing.Image)(resources.GetObject("carroNormal.Image")));
			this.carroNormal.Location = new System.Drawing.Point(25, 306);
			this.carroNormal.Name = "carroNormal";
			this.carroNormal.Size = new System.Drawing.Size(211, 127);
			this.carroNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.carroNormal.TabIndex = 2;
			this.carroNormal.TabStop = false;
			// 
			// cones
			// 
			this.cones.BackColor = System.Drawing.Color.Transparent;
			this.cones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cones.Image = ((System.Drawing.Image)(resources.GetObject("cones.Image")));
			this.cones.Location = new System.Drawing.Point(850, 306);
			this.cones.Name = "cones";
			this.cones.Size = new System.Drawing.Size(197, 127);
			this.cones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.cones.TabIndex = 3;
			this.cones.TabStop = false;
			// 
			// moverBTN
			// 
			this.moverBTN.BackColor = System.Drawing.Color.Transparent;
			this.moverBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.moverBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.moverBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.moverBTN.Location = new System.Drawing.Point(660, 12);
			this.moverBTN.Name = "moverBTN";
			this.moverBTN.Size = new System.Drawing.Size(186, 59);
			this.moverBTN.TabIndex = 4;
			this.moverBTN.Text = "mover";
			this.moverBTN.UseVisualStyleBackColor = false;
			this.moverBTN.Click += new System.EventHandler(this.MoverBTNClick);
			// 
			// timer1
			// 
			this.timer1.Interval = 16;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// aceleroBTN
			// 
			this.aceleroBTN.BackColor = System.Drawing.Color.Transparent;
			this.aceleroBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.aceleroBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.aceleroBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aceleroBTN.Location = new System.Drawing.Point(870, 12);
			this.aceleroBTN.Name = "aceleroBTN";
			this.aceleroBTN.Size = new System.Drawing.Size(186, 59);
			this.aceleroBTN.TabIndex = 5;
			this.aceleroBTN.Text = "Acelero";
			this.aceleroBTN.UseVisualStyleBackColor = false;
			this.aceleroBTN.Click += new System.EventHandler(this.AceleroBTNClick);
			this.aceleroBTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AceleroBTNMouseDown);
			this.aceleroBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AceleroBTNMouseUp);
			// 
			// reBTN
			// 
			this.reBTN.BackColor = System.Drawing.Color.Transparent;
			this.reBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.reBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reBTN.Location = new System.Drawing.Point(776, 77);
			this.reBTN.Name = "reBTN";
			this.reBTN.Size = new System.Drawing.Size(186, 59);
			this.reBTN.TabIndex = 6;
			this.reBTN.Text = "ré";
			this.reBTN.UseVisualStyleBackColor = false;
			this.reBTN.Click += new System.EventHandler(this.ReBTNClick);
			this.reBTN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReBTNMouseDown);
			this.reBTN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReBTNMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1242, 459);
			this.Controls.Add(this.reBTN);
			this.Controls.Add(this.aceleroBTN);
			this.Controls.Add(this.moverBTN);
			this.Controls.Add(this.cones);
			this.Controls.Add(this.carroNormal);
			this.Controls.Add(this.rua);
			this.Controls.Add(this.floresta);
			this.Name = "MainForm";
			this.Text = "carroBatido";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			((System.ComponentModel.ISupportInitialize)(this.rua)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.floresta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carroNormal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cones)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
