using System;
using System.Collections.Generic;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using WpfApplication1;

namespace test
{
    [System.Runtime.InteropServices.Guid("efe72d01-5dfe-428e-afe9-fd82d5dbb2df")]
    public class testCommand : Command
    {
        public testCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static testCommand Instance
        {
            get; private set;
        }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "testCommand"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            System.Windows.Window my = new WpfApplication1.MainWindow();
            new System.Windows.Interop.WindowInteropHelper(my).Owner = Rhino.RhinoApp.MainWindowHandle();
            my.Show();
            //bool? result = my.ShowDialog();
            return Result.Success;
        }
    }
}
