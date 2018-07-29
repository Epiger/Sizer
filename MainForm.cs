using System;
using Eto.Forms;
using Eto.Drawing;

namespace Sizer {

    public class MainForm : Form{

        public MainForm(){

            Menu = new MenuBar();

            //var nativeControl = new MyNativeControl().ToEto();

            
/* 
            Content = new TableLayout(){
                
                Padding = new Padding(10),
                Spacing = new Size(5, 5),

                Rows = {
                    nativeControl,
					null,
					new TableLayout(new TableRow(null, new Button { Text = "An Eto.Forms button" })),
                }
            
            };*/

        }


    }


}