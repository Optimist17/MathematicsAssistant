using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsAssistant.GUI.ViewModels.Dialogs
{
    public class QuestionDialogViewModel : DialogViewModelBase
    {

        #region Properties

        private String m_Question;
        public String Question
        {
            get { return m_Question; }
            set
            {
                if (m_Question != value)
                {
                    m_Question = value;
                    onPropertyChanged("Question");
                }
            }
        }

        #endregion

        #region Constructor

        //public QuestionDialogViewModel() : base("besondere Fragestellung")
        //{
        //    if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(System.Windows.DependencyObject()) == false) throw new InvalidOperationException("only Designer");
        //    Question = "Das ist eine Textfrage mit ganz viel Inhalt.";
        //}

        public QuestionDialogViewModel(String title, String question) : base(title)
        {
            Question = question;
        }

        #endregion

    }
}
