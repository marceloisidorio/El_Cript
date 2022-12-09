using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Cript {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {
			label_error.Text = "";
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			MessageBox.Show("El_Cript Security - Beta Version\n\nBy Marcelo Isidorio\nGitHub: /marceloisidorio");

		} // end pictureBox1_Click

		private void btn_clear_Click(object sender, EventArgs e) {
			key_box.Text = string.Empty;
			cript_box.Text = string.Empty;
			label_error.Text = string.Empty;
			descript_box.Text = string.Empty;
			Console.Beep(); // sound

		} // end btn_clear_Click

		private void btn_cript_Click(object sender, EventArgs e) {
			if (key_box.Text == "") {
				label_error.Text = "*Insira a chave";
				Console.Beep(); // sound
			}else {
				cript_box.Text = string.Empty;
				int key = Convert.ToInt32(key_box.Text);

				for (int i = 0; i < descript_box.Text.Length; i++) {
					int descript = (int)descript_box.Text[i];
					int cript = descript + key;

					cript_box.Text += char.ConvertFromUtf32(cript);
				} // end for
			}
		} // end btn_cript_Click

		private void btn_descript_Click(object sender, EventArgs e) {
			if (key_box.Text == "")
			{
				label_error.Text = "*Insira a chave";
				Console.Beep(); // sound
			}else {
				descript_box.Text = string.Empty;
				int key = Convert.ToInt32(key_box.Text);

				for (int i = 0; i < cript_box.Text.Length; i++) {
					int cript = (int)cript_box.Text[i];
					int descript = cript - key;

					descript_box.Text += char.ConvertFromUtf32(descript);
				}
			}
		} // end btn_descript_Click
	}
} // end namespace