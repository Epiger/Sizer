using System;

namespace Sizer
{
    public class Program{
		[STAThread]
		public static void Main(string[] args){
			Console.WriteLine("TEst");


			new Eto.Forms.Application().Run(new MyForm());

		}
	}


	class MyForm : Eto.Forms.Form
{
	public MyForm()
	{
		// sets the client (inner) size of the window for your content
		this.ClientSize = new Eto.Drawing.Size(600, 400);

		this.Title = "Hello, Eto.Forms";
	}
}

}