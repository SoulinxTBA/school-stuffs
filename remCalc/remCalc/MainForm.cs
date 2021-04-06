using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace remCalc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Double result = 0;
		String opUsed = "";
		bool activeOp = false;
		public MainForm()
		{
			InitializeComponent();
		}
		void num(object sender, EventArgs e)
		{
			Button userInput = (Button) sender;
			if (textBox1.Text == "0" || (activeOp)){
				textBox1.Clear();
			}
			if (userInput.Text == "."){
				if (!textBox1.Text.Contains(".")){
					textBox1.Text = textBox1.Text + userInput.Text;
				}
			}else
			textBox1.Text = textBox1.Text + userInput.Text;
			activeOp = false;
		}
		void opr(object sender, EventArgs e)
		{
			Button userInput = (Button) sender;
			if (result != 0){
				if (textBox1.Text == result.ToString()){
					result = Double.Parse(textBox1.Text);
				}
				button16.PerformClick();
				opUsed = userInput.Text;
				activeOp = true;
			}else{
				opUsed = userInput.Text;
				result = Double.Parse(textBox1.Text);
				activeOp = true;
			}
			
		}
		void Button16Click(object sender, EventArgs e)
		{
			switch(opUsed){
				case "+":
					textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString ();
					break;
				case "-":
					textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString ();
					break;
				case "*":
					textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString ();
					break;
				case "/":
					textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString ();
					break;
				default:
					break;
			}
			result = Double.Parse(textBox1.Text);
			activeOp = false;
			if (textBox1.Text == result.ToString()){
				result = Double.Parse(textBox1.Text);
			}
		}
	}
}
