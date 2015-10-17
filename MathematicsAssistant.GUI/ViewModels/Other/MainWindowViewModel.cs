using MathematicsAssistant.GUI.Events;
using MathematicsAssistant.GUI.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MathematicsAssistant.GUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<TabViewModelBase> m_tabs;
        public ObservableCollection<TabViewModelBase> Tabs
        {
            get { return m_tabs; }
            set
            {
                if (m_tabs != value)
                {
                    if (m_tabs != null)
                    {
                        m_tabs.CollectionChanged -= m_tabs_CollectionChanged;
                    }
                    if (value != null)
                    {
                        value.CollectionChanged += m_tabs_CollectionChanged;
                    }
                    m_tabs = value;
                    onPropertyChanged("Tabs");
                }
            }
        }

        #region Properties

        private TabViewModelBase m_SelectedTab;
        public TabViewModelBase SelectedTab
        {
            get { return m_SelectedTab; }
            set
            {
                if (m_SelectedTab != value)
                {
                    m_SelectedTab = value;
                    onPropertyChanged("SelectedTab");
                }
            }
        }

        #endregion

        #region Methods

        private void AddTab(TabViewModelBase tab)
        {
            m_tabs.Add(tab);
            SelectedTab = tab;
        }

        #endregion

        #region Event-Handling

        private void m_tabs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (TabViewModelBase item in e.NewItems)
                {
                    item.RequestClose += Item_RequestClose;
                    item.RequestTab += Item_RequestTab;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (TabViewModelBase item in e.OldItems)
                {
                    item.RequestClose -= Item_RequestClose;
                    item.RequestTab -= Item_RequestTab;
                }
            }
        }

        private void Item_RequestTab(object sender, RequestTabEventArgs e)
        {
            AddTab(e.TabToOpen);
        }

        private void Item_RequestClose(object sender, EventArgs e)
        {
            TabViewModelBase realSender = (TabViewModelBase)sender;
            m_tabs.Remove(realSender);
        }

        private void Item_OpenTab(object sender, EventArgs e)
        {
            TabViewModelBase realSender = (TabViewModelBase)sender;
            m_tabs.Add(realSender);
        }

        #endregion

        #region Events

        #endregion

        #region Commands

        public ICommand OpenMainTabCommand { get; private set; }
        private void onOpenMainTabExecuted(Object parameter)
        {
            AddTab(new MainTabViewModel());
        }

        public ICommand OpenTriangleCalculationTabCommand { get; private set; }
        private void onOpenTriangleTabExecuted(Object parameter)
        {
            AddTab(new TriangleCalculationTabViewModel());
        }
        #endregion

        #region Constructor

        public MainWindowViewModel()
        {
            Tabs = new ObservableCollection<TabViewModelBase>();
            OpenMainTabCommand = new RelayCommand(onOpenMainTabExecuted);
            OpenTriangleCalculationTabCommand = new RelayCommand(onOpenTriangleTabExecuted);
            if (System.ComponentModel.DesignerProperties.GetIsInDesignMode(new DependencyObject()) == true)
            {

                Tabs.Add(new MainTabViewModel());
                Tabs.Add(new MainTabViewModel());
                Tabs.Add(new MainTabViewModel());
            }
            else
            {
                Tabs.Add(new MainTabViewModel());
            }
        }

        #endregion
    }
}
