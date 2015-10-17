using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.GUI.ViewModels.Dialogs
{
    public class InfoDialogViewModel : DialogViewModelBase
    {

        #region Properties


        private String m_Text;
        public String Text
        {
            get { return m_Text; }
            set
            {
                if (m_Text != value)
                {
                    m_Text = value;
                    onPropertyChanged("Text");
                }
            }
        }

        #endregion

        #region Constructor

        public InfoDialogViewModel() : base("besondere Fragestellung")
        {
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()) == false) throw new InvalidOperationException("only Designer");
            Text = "Das ist eine Info mit ganz viel Inhalt.";
        }

        public InfoDialogViewModel(String title, String info) : base(title)
        {
            Text = info;
        }

        #endregion

    }
}
