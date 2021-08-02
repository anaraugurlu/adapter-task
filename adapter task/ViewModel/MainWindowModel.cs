using adapter_task.Command;
using adapter_task.Extention;
using adapter_task.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace adapter_task.ViewModel
{
    class Application
    {
        private readonly Adapter  _converter;

        public Application(IAdapter adapter)
        {
            _converter = new Adapter(adapter);
        }

        public void Start(User user)
        {
            _converter.Serialize(user );
          

        }
    }

    class MainWindowModel :Base
    {
          public MainWindow MainWindow { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public User User { get; set; }
        public MainWindowModel() 
        {
            IAdapter adapter;
            SaveCommand = new RelayCommand
                ((save) =>
                {
                    
                    if (MainWindow .xml.IsChecked ==true)
                    {
                        adapter = new XmlAdapter(new XmlDb());
                        
                    }
                    else
                    {
                        adapter = new JsonAdapter(new JsonDb());

                    }
                    User = new User
                    {
                        Email = MainWindow .email .Text ,
                        Surname = MainWindow.surname .Text,
                        Name = MainWindow.name.Text
                    };
                    Application app = new Application(adapter);
                    app.Start(User);
                   
                },

                (save2) =>
                {
                    if (MainWindow .name  != null && MainWindow .surname .Text  != null && MainWindow .email .Text  != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                );
        }


    }
}
