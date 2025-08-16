/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 15/08/2025
 * Hora: 21:12
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace carroBatido
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			cones.Parent = rua;
			cones.Top = 25;
			cones.Left = 740;
			
			carroNormal.Parent = rua;
			carroNormal.Top = 0;
			carroNormal.Left = 0;
			
			timer1.Enabled = false;
			

		}
		int acelero = 0;
		void MoverBTNClick(object sender, EventArgs e)
		{	
			acelero = 0;
			carroNormal.Load("carro_normal.png");
			carroNormal.Top = 0;
			carroNormal.Left = 0;
			timer1.Enabled = true;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			carroNormal.Left += 5 + acelero;
			if (carroNormal.Left < -150){
				timer1.Enabled = false;
				MessageBox.Show("parabens zé Zerou");
			}
			if (carroNormal.Bounds.IntersectsWith(cones.Bounds)) {
			    	timer1.Enabled = false;
			    	carroNormal.Load("kevin_acidentado.png");
			    	MessageBox.Show("REPROVOU NA AUTOESCOLA ZÉ KKKKKKKK");
			}
		}
		void AceleroBTNClick(object sender, EventArgs e)
		{
		
		}
		void AceleroBTNMouseDown(object sender, MouseEventArgs e)
		{
			acelero += 10;
			timer1.Interval = 8;
		}
		void AceleroBTNMouseUp(object sender, MouseEventArgs e)
		{
			acelero -= 10;
			timer1.Interval = 16;
		}
		void ReBTNClick(object sender, EventArgs e)
		{
			acelero -= -10;
		}
		void ReBTNMouseDown(object sender, MouseEventArgs e)
		{
			acelero -= 20;
		}
		void ReBTNMouseUp(object sender, MouseEventArgs e)
		{
			acelero = 0;
		}

	}
}
