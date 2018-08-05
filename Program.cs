using System;
using Eto.Forms;
using Eto.Drawing;

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


			TableLayout layout = new TableLayout();
			layout.Spacing = new Size(5,5);
			layout.Padding = new Padding(10,10,10,10);


			layout.Rows.Add(new TableRow(
				new TableCell(new Label{Text = "First Column"}, true),
				new TableCell(new ListBox{Style = "main-list"}, true),
				new Label{Text = "Third Column"}
			));

			layout.Rows.Add(new TableRow(
				new TextBox { Text = "Some Text" },
				new DropDown { Items = { "Item 1", "Item 2", "Item 3" } },
				new CheckBox { Text = "A checkbox" }
			));

			layout.Rows.Add(new TableRow{ScaleHeight = true});


			Content = layout;


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