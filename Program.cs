using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sizer
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("Hello");

			//new Eto.Forms.Application().Run(new MyForm());
			//new Application(new Eto.Wpf.Platform()).Run(new MainForm());

			Console.ReadKey();
		}
	}

	class MyForm : Form{

		public MyForm(){

			this.ClientSize = new Eto.Drawing.Size(600, 400);

			this.Title = "Hello, Eto.Forms";


		}

	}

}
