using System;
using Eto.Forms;

namespace Sizer
{
    public class Program{
		[STAThread]
		public static void Main(string[] args){
			Console.WriteLine("TEst");


			new Eto.Forms.Application().Run(new MyForm());

		}
	}


	class MyForm : Eto.Forms.Form {
		public MyForm() {
			// sets the client (inner) size of the window for your content
			this.ClientSize = new Eto.Drawing.Size(600, 400);

			this.Title = "Hello, Eto.Forms";

			Menu = new MenuBar{
				Items = {
					new ButtonMenuItem{
						Text = "&File",
						Items = {
							new MCommand(),

							new ButtonMenuItem {
								Text = "Click me button"
							}
						}
					}

				}


			};

			Menu.QuitItem = new Command((sender, e) => Application.Instance.Quit()){
				MenuText = "Quit",
				Shortcut = Application.Instance.CommonModifier | Keys.Q
			};


			var aboutItem = new ButtonMenuItem{Text = "About"};
			aboutItem.Click += (sender, e) => {
				
				Dialog dlg = new Dialog{
					Content = new Label{Text = "About"},
					ClientSize = new Eto.Drawing.Size(200, 200)
				};
				dlg.ShowModal(this);

			};

			Menu.AboutItem = aboutItem;


			ToolBar = new ToolBar{
				Items = {
					new MCommand(),
					new SeparatorToolItem(),
					new ButtonToolItem{Text = "Teee mit Zucker"}
				}
			};

		}
	}


	class MCommand : Command {

		public MCommand(){
			MenuText = "Click Me!!";
			ToolBarText = "HEHEH Toolbar click";
			ToolTip = "TToool tipp?";
			
			Shortcut = Application.Instance.CommonModifier | Keys.M;
		}

		protected override void OnExecuted(EventArgs e){
			base.OnExecuted(e);

			MessageBox.Show(Application.Instance.MainForm, "Clicked hahaha!!", "Tutle", MessageBoxType.Information);
		}


	}

}