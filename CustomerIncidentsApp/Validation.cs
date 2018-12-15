using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerIncidentsApp
{
    public static class Validation
    {
	    public static bool IsPresent(string value, string name)
	    {
		    if (string.IsNullOrEmpty(value))
		    {
			    MessageBox.Show($"{name} is a required field", $"{name} Required");
			    return false;
		    }
		    return true;
	    }

	    public static bool IsSelected(ComboBox comboBox, string name)
	    {
		    if (comboBox.SelectedIndex == -1)
		    {
			    MessageBox.Show($"{name} is a required field", $"{name} Required");
			    return false;
		    }

		    return true;
        }
    }
}
