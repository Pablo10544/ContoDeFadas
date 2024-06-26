using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClassMAUIChallenge6.Resources.Model
{
    partial class ContoDeFadasViewModel:ObservableObject
{
        [ObservableProperty]
        public ObservableCollection<ContoDeFadas> contosDeFadas = new ObservableCollection<ContoDeFadas>() {
new ContoDeFadas{Name = "A casa mal assombrada",ReadTime=new TimeSpan(0,5,0),isSaved=true, Image="spookyhouse.png" },
new ContoDeFadas{Name = "Cinderela",ReadTime=new TimeSpan(0,25,0),isSaved=true, Image="cinderela.jpg" },
new ContoDeFadas{Name = "João e Maria",ReadTime=new TimeSpan(0,13,0),isSaved=true, Image="casajoao.png" }
            };
        [ObservableProperty]
        public ObservableCollection<ContoDeFadas> contosDeFadas2 = new ObservableCollection<ContoDeFadas>() {
new ContoDeFadas{Name = "A casa mal assombrada",ReadTime=new TimeSpan(0,5,0),isSaved=true, Image="spookyhouse.png" },
new ContoDeFadas{Name = "Cinderela",ReadTime=new TimeSpan(0,25,0),isSaved=true, Image="cinderela.jpg" },
new ContoDeFadas{Name = "João e Maria",ReadTime=new TimeSpan(0,13,0),isSaved=true, Image="casajoao.png" }
            };
        private void InitializeTales()
        {
            
        }
    }
}
