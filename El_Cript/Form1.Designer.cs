
namespace El_Cript
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.descript_box = new System.Windows.Forms.TextBox();
			this.cript_box = new System.Windows.Forms.TextBox();
			this.label_descript = new System.Windows.Forms.Label();
			this.label_cript = new System.Windows.Forms.Label();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_cript = new System.Windows.Forms.Button();
			this.btn_descript = new System.Windows.Forms.Button();
			this.label_key = new System.Windows.Forms.Label();
			this.key_box = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label_error = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// descript_box
			// 
			this.descript_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descript_box.Location = new System.Drawing.Point(13, 40);
			this.descript_box.Multiline = true;
			this.descript_box.Name = "descript_box";
			this.descript_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descript_box.ShortcutsEnabled = false;
			this.descript_box.Size = new System.Drawing.Size(251, 262);
			this.descript_box.TabIndex = 0;
			// 
			// cript_box
			// 
			this.cript_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.cript_box.Location = new System.Drawing.Point(274, 40);
			this.cript_box.Multiline = true;
			this.cript_box.Name = "cript_box";
			this.cript_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.cript_box.Size = new System.Drawing.Size(251, 262);
			this.cript_box.TabIndex = 1;
			// 
			// label_descript
			// 
			this.label_descript.AutoSize = true;
			this.label_descript.Font = new System.Drawing.Font("Consolas", 11F);
			this.label_descript.Location = new System.Drawing.Point(75, 20);
			this.label_descript.Name = "label_descript";
			this.label_descript.Size = new System.Drawing.Size(136, 18);
			this.label_descript.TabIndex = 2;
			this.label_descript.Text = "Descriptografado";
			// 
			// label_cript
			// 
			this.label_cript.AutoSize = true;
			this.label_cript.Font = new System.Drawing.Font("Consolas", 11F);
			this.label_cript.Location = new System.Drawing.Point(345, 20);
			this.label_cript.Name = "label_cript";
			this.label_cript.Size = new System.Drawing.Size(112, 18);
			this.label_cript.TabIndex = 3;
			this.label_cript.Text = "Criptografado";
			// 
			// btn_clear
			// 
			this.btn_clear.Font = new System.Drawing.Font("Consolas", 11F);
			this.btn_clear.Location = new System.Drawing.Point(13, 310);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(251, 47);
			this.btn_clear.TabIndex = 4;
			this.btn_clear.Text = "Limpar";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_cript
			// 
			this.btn_cript.Font = new System.Drawing.Font("Consolas", 11F);
			this.btn_cript.Location = new System.Drawing.Point(13, 364);
			this.btn_cript.Name = "btn_cript";
			this.btn_cript.Size = new System.Drawing.Size(121, 36);
			this.btn_cript.TabIndex = 5;
			this.btn_cript.Text = "Criptar";
			this.btn_cript.UseVisualStyleBackColor = true;
			this.btn_cript.Click += new System.EventHandler(this.btn_cript_Click);
			// 
			// btn_descript
			// 
			this.btn_descript.Font = new System.Drawing.Font("Consolas", 11F);
			this.btn_descript.Location = new System.Drawing.Point(142, 364);
			this.btn_descript.Name = "btn_descript";
			this.btn_descript.Size = new System.Drawing.Size(121, 36);
			this.btn_descript.TabIndex = 6;
			this.btn_descript.Text = "Descriptar";
			this.btn_descript.UseVisualStyleBackColor = true;
			this.btn_descript.Click += new System.EventHandler(this.btn_descript_Click);
			// 
			// label_key
			// 
			this.label_key.AutoSize = true;
			this.label_key.Font = new System.Drawing.Font("Consolas", 11F);
			this.label_key.Location = new System.Drawing.Point(278, 348);
			this.label_key.Name = "label_key";
			this.label_key.Size = new System.Drawing.Size(56, 18);
			this.label_key.TabIndex = 7;
			this.label_key.Text = "Chave:";
			// 
			// key_box
			// 
			this.key_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.key_box.Location = new System.Drawing.Point(331, 348);
			this.key_box.Name = "key_box";
			this.key_box.Size = new System.Drawing.Size(117, 22);
			this.key_box.TabIndex = 8;
			this.key_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(471, 362);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(54, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label_error
			// 
			this.label_error.AutoSize = true;
			this.label_error.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_error.Location = new System.Drawing.Point(299, 375);
			this.label_error.Name = "label_error";
			this.label_error.Size = new System.Drawing.Size(0, 15);
			this.label_error.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 417);
			this.Controls.Add(this.label_error);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.key_box);
			this.Controls.Add(this.label_key);
			this.Controls.Add(this.btn_descript);
			this.Controls.Add(this.btn_cript);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.label_cript);
			this.Controls.Add(this.label_descript);
			this.Controls.Add(this.cript_box);
			this.Controls.Add(this.descript_box);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "El_Cript Security - Beta Version";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox descript_box;
		private System.Windows.Forms.TextBox cript_box;
		private System.Windows.Forms.Label label_descript;
		private System.Windows.Forms.Label label_cript;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_cript;
		private System.Windows.Forms.Button btn_descript;
		private System.Windows.Forms.Label label_key;
		private System.Windows.Forms.TextBox key_box;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label_error;
	}
}

