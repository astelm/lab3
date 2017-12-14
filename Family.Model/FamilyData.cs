using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Family.Model
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("FamilyData")]
    public class FamilyData : INotifyPropertyChanged
    {
        public FamilyData()
        {
            Families = new ObservableCollection<Family>();
        }

        public void LoadFromXML(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            Family[] flocksArray;
            XmlSerializer serializer = new XmlSerializer(typeof(Family[]));

            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    flocksArray = (Family[])serializer.Deserialize(reader);
                }
                catch (InvalidOperationException e)
                {
                    return;
                }
            }

            Families = new ObservableCollection<Family>(flocksArray);
        }
        public void SaveToXML(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Family[]));

            using (StreamWriter wr = new StreamWriter(path))
            {
                xs.Serialize(wr, Families.ToArray<Family>());
            }
        }
        public void Clear()
        {
            Families.Clear();
        }

        public ObservableCollection<Family> Families
        {
            get
            {
                return _families;
            }
            private set
            {
                _families = value;
                OnPropertyChanged("Families");
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Family> _families;
    }
}