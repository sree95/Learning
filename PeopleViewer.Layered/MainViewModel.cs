using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleViewer
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            repository = RepositoryFactory.GetRepository();
        }

        #region INotifyPropertyChangedMembers
        public event PropertyChangedEventHandler PropertyChanged;


        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private IPersonRepository repository;

        private IEnumerable<Person> people;
        public IEnumerable<Person> People
        {
            get
            {
                return people;
            }
            set
            {
                people = value;
                RaisePropertyChanged("People");
            }
        }

        public string RepositoryType
        {
            get
            {
                return repository.GetType().ToString();
            }
        }


        public void FetchData()
        {
            repository.GetPeople();
        }


        public void ClearData()
        {
            people = new List<Person>();
        }


    }
}
